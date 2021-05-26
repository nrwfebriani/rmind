using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RmindApp
{
    public partial class SearchForm : Form
    {
        SqlConnection conn = new SqlConnection( @"Database=ReminderList;Data Source=NRWFEBRIANI;Initial Catalog=ReminderList;Integrated Security=true");
        SqlCommand command;
        Entry entry = new Entry();
        int ID = 0;
        public static string searchtext = "";
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Load_Search()
        {
            conn.Open();
            command = new SqlCommand("SELECT * from Reminders WHERE Title=@search", conn);
            command.Parameters.Add(new SqlParameter("@search", tbSearch2.Text));
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            dgvSearch.DataSource = bSource;
            sda.Update(dbdataset);
            conn.Close();
        }

        void Load_Table()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * from Reminders", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            dgvSearch.DataSource = bSource;
            sda.Update(dbdataset);
            conn.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            Load_Table();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(tbTitle2.Text != "" && ID != 0)
            {
                DialogResult dr = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    GetCategory(rbBeauty);
                    GetCategory(rbDoc);
                    GetCategory(rbFNB);
                    GetCategory(rbMed);
                    GetCategory(rbOthers);

                    command = new SqlCommand("UPDATE Reminders SET Title = @Title, [Expired Date] = @Expired_Date, [Reminder Date] = @Reminder_Date, Category = @Category, Notes = @Notes WHERE ID = @ID", conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@Title", tbTitle2.Text);
                    command.Parameters.AddWithValue("@Expired_Date", dtpExpired2.Value);
                    command.Parameters.AddWithValue("@Reminder_Date", dtpReminder2.Value);
                    command.Parameters.AddWithValue("@Category", entry.reminderCategory);
                    command.Parameters.AddWithValue("@Notes", rtbNotes2.Text);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Entry updated!");
                    conn.Close();
                    Load_Table();
                    ClearData();
                }
            }
            else
            {
                MessageBox.Show("Select a valid entry to update.");
            }
        }
        private void GetCategory(RadioButton rb)
        {
            if (rb.Checked)
            {
                entry.reminderCategory = rb.Text;
            }
        }

        private void CheckCategory(RadioButton rb)
        {
            if (entry.reminderCategory == rb.Text)
            {
                rb.Checked = true;
            }
        }
        private void ClearData()
        {
            ID = 0;
            tbTitle2.Text = "";
            rtbNotes2.Text = "";
            dtpExpired2.Value = DateTime.Now;
            dtpReminder2.Value = DateTime.Now;
            rbOthers.Checked = false;
            rbMed.Checked = false;
            rbFNB.Checked = false;
            rbDoc.Checked = false;
            rbBeauty.Checked = false;
        }

        private void dgvSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvSearch.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                ID = Convert.ToInt32(dgvSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
                tbTitle2.Text = dgvSearch.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpExpired2.Value = (DateTime)dgvSearch.Rows[e.RowIndex].Cells[2].Value;
                dtpReminder2.Value = (DateTime)dgvSearch.Rows[e.RowIndex].Cells[3].Value;
                entry.reminderCategory = dgvSearch.Rows[e.RowIndex].Cells[4].Value.ToString();
                CheckCategory(rbBeauty);
                CheckCategory(rbDoc);
                CheckCategory(rbFNB);
                CheckCategory(rbMed);
                CheckCategory(rbOthers);
                rtbNotes2.Text = dgvSearch.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchtext = tbSearch2.Text;
            Load_Search();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                command = new SqlCommand("DELETE Reminders WHERE ID=@id", conn);
                conn.Open();
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Entry deleted.");
                Load_Table();
                ClearData();
            }
            else
            {
                MessageBox.Show("Select entry to delete.");
            }
        }
    }
}
