using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RmindApp
{
    public partial class MainUI : Form
    {
        SqlConnection conn = new SqlConnection(@"Database=ReminderList;Data Source=NRWFEBRIANI;Initial Catalog=ReminderList;Integrated Security=true");
        SqlCommand command;
        Entry entry = new Entry();
        public DateTime dateReminder = DateTime.Now;
        public DateTime dateExpired = DateTime.Now;
        public static string searchtext = "";
        public static string title2, dater2, datex2, category2, note2;
        public MainUI()
        {
            InitializeComponent();
        }

        private void GetCategory(RadioButton rb)
        {
            if (rb.Checked)
            {
                entry.reminderCategory = rb.Text;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "";
            rtbNotes.Text = "";
            rbOthers.Checked = false;
            rbMed.Checked = false;
            rbFNB.Checked = false;
            rbDoc.Checked = false;
            rbBeauty.Checked = false;
            dtpExpired.Value = DateTime.Now;
            dtpReminder.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpExpired_ValueChanged(object sender, EventArgs e)
        {
            dateExpired = dtpExpired.Value;
        }

        private void dtpReminder_ValueChanged(object sender, EventArgs e)
        {
            dateReminder = dtpReminder.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            entry.title = tbTitle.Text;
            entry.reminderDate = dateReminder;
            entry.expiredDate = dateExpired;
            entry.note = rtbNotes.Text;

            GetCategory(rbBeauty);
            GetCategory(rbDoc);
            GetCategory(rbFNB);
            GetCategory(rbMed);
            GetCategory(rbOthers);

            conn.Open();
            command = new SqlCommand("INSERT INTO Reminders(Title,[Expired Date], [Reminder Date], Category, Notes) VALUES(@Title, @Expired_Date, @Reminder_Date, @Category, @Notes)", conn);

            command.Parameters.AddWithValue("@Title", tbTitle.Text);
            command.Parameters.AddWithValue("@Expired_Date", dtpExpired.Text);
            command.Parameters.AddWithValue("@Reminder_Date", dtpReminder.Text);
            command.Parameters.AddWithValue("@Category", entry.reminderCategory);
            command.Parameters.AddWithValue("@Notes", rtbNotes.Text);
            command.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Reminder saved!");
            tbTitle.Text = "";
            rtbNotes.Text = "";
            dtpExpired.Value = DateTime.Now;
            dtpReminder.Value = DateTime.Now;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            SearchForm viewAllForm = new SearchForm();
            viewAllForm.Show();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            Notification notiForm = new Notification();
            notiForm.Show();
            //if (dateReminder == DateTime.Now)
            //{
            //    MessageBox.Show("Reminder for today:\nTitle: " + dataReader["Title"].ToString());

            //}
            //else if (dateExpired == DateTime.Now)
            //{
            //    MessageBox.Show("expired for today.");
            //}
            //else
            //{
            //    MessageBox.Show("There is no reminder for today.");
            //}
        }
    }
}
