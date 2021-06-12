using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            SqlCommand command = new SqlCommand("SELECT * from Reminders WHERE Date=@datenow", conn);
            command.Parameters.Add(new SqlParameter("@datenow", DateTime.Now));
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
    }
}
