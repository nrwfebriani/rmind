using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RmindApp
{
    public partial class Notification : Form
    {
        SqlConnection conn = new SqlConnection(@"Database=ReminderList;Data Source=NRWFEBRIANI;Initial Catalog=ReminderList;Integrated Security=true");
        SqlCommand command;
        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand ("SELECT * from Reminders WHERE [Reminder Date]=@datenow", conn);
            command.Parameters.Add(new SqlParameter("@datenow", DateTime.Today));
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            dgvNotification.DataSource = bSource;
            sda.Update(dbdataset);
            conn.Close();
        }

        private void dgvNotification_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvNotification.Rows[e.RowIndex].Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("There is no reminder for today.");
            }
        }
    }
}
