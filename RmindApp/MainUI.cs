using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RmindApp
{
    public partial class MainUI : Form
    {
        Entry entry = new Entry();
        public string dateReminder = DateTime.Now.ToString("dd-MM-yyyy");
        public string dateExpired = DateTime.Now.ToString("dd-MM-yyyy");
        public MainUI()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chkMed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMed.Checked == true)
            {
                chkBeauty.Checked = false;
                chkDoc.Checked = false;
                chkFNB.Checked = false;
                chkOthers.Checked = false;
                entry.reminderCategory = "Medication";
            }
        }

        private void chkBeauty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBeauty.Checked == true)
            {
                chkMed.Checked = false;
                chkDoc.Checked = false;
                chkFNB.Checked = false;
                chkOthers.Checked = false;
                entry.reminderCategory = "Beauty product";
            }
        }

        private void chkFNB_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFNB.Checked == true)
            {
                chkBeauty.Checked = false;
                chkDoc.Checked = false;
                chkMed.Checked = false;
                chkOthers.Checked = false;
                entry.reminderCategory = "Food-Beverages";
            }
        }

        private void chkDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoc.Checked == true)
            {
                chkBeauty.Checked = false;
                chkMed.Checked = false;
                chkFNB.Checked = false;
                chkOthers.Checked = false;
                entry.reminderCategory = "Document";
            }
        }

        private void chkOthers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOthers.Checked == true)
            {
                chkBeauty.Checked = false;
                chkDoc.Checked = false;
                chkFNB.Checked = false;
                chkMed.Checked = false;
                entry.reminderCategory = "Others";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "";
            rtbNotes.Text = "";
            chkBeauty.Checked = false;
            chkDoc.Checked = false;
            chkFNB.Checked = false;
            chkMed.Checked = false;
            chkOthers.Checked = false;
            //pbPic.Image.Dispose();
            dtpExpired.Value = DateTime.Now;
            dtpReminder.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpExpired_ValueChanged(object sender, EventArgs e)
        {
            dateExpired = dtpExpired.Value.ToString("dd-MM-yyyy");
        }

        private void dtpReminder_ValueChanged(object sender, EventArgs e)
        {
            dateReminder = dtpReminder.Value.ToString("dd-MM-yyyy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            entry.title = tbTitle.Text;
            entry.reminderDate = dateReminder;
            entry.expiredDate = dateExpired;
            entry.note = rtbNotes.Text;
            //pbPic.Image


            //add to database

            MessageBox.Show("Reminder saved!");
            tbTitle.Text = "";
            rtbNotes.Text = "";
            chkBeauty.Checked = false;
            chkDoc.Checked = false;
            chkFNB.Checked = false;
            chkMed.Checked = false;
            chkOthers.Checked = false;
            //pbPic.Image.Dispose();
            dtpExpired.Value = DateTime.Now;
            dtpReminder.Value = DateTime.Now;
        }


            private void btnChoose_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewAllForm viewAllForm = new ViewAllForm();
            viewAllForm.Show();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
