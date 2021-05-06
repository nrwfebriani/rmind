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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        void load_table()
        {
            
            string strConnect = @"Database=ReminderList;Data Source=NRWFEBRIANI;Initial Catalog=ReminderList;Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConnect);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * from Reminders WHERE Title=@search", conn);
            command.Parameters.Add(new SqlParameter("@search", tbSearch2.Text));
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = command;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            dgvSearch.DataSource = bSource;
            sda.Update(dbdataset);
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            tbSearch2.Text = MainUI.searchtext;
            load_table();
        }
    }
}
