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
    public partial class ViewAllForm : Form
    {
        public ViewAllForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllForm_Load(object sender, EventArgs e)
        {
            load_table();
        }

        void load_table()
        {
            string strConnect = @"Database=ReminderList;Data Source=NRWFEBRIANI;Initial Catalog=ReminderList;Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * from Reminders", conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            dgvAllReminders.DataSource = bSource;
            sda.Update(dbdataset);
        }
    }
}
