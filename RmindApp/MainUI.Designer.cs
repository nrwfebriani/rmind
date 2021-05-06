
namespace RmindApp
{
    partial class MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dtpExpired = new System.Windows.Forms.DateTimePicker();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.chkMed = new System.Windows.Forms.CheckBox();
            this.chkBeauty = new System.Windows.Forms.CheckBox();
            this.chkFNB = new System.Windows.Forms.CheckBox();
            this.chkDoc = new System.Windows.Forms.CheckBox();
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "r m i n d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expired Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reminder Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Notes";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(141, 79);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(196, 23);
            this.tbTitle.TabIndex = 6;
            // 
            // dtpExpired
            // 
            this.dtpExpired.Location = new System.Drawing.Point(141, 115);
            this.dtpExpired.Name = "dtpExpired";
            this.dtpExpired.Size = new System.Drawing.Size(143, 23);
            this.dtpExpired.TabIndex = 7;
            this.dtpExpired.ValueChanged += new System.EventHandler(this.dtpExpired_ValueChanged);
            // 
            // dtpReminder
            // 
            this.dtpReminder.Location = new System.Drawing.Point(141, 150);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(143, 23);
            this.dtpReminder.TabIndex = 8;
            this.dtpReminder.ValueChanged += new System.EventHandler(this.dtpReminder_ValueChanged);
            // 
            // chkMed
            // 
            this.chkMed.AutoSize = true;
            this.chkMed.Location = new System.Drawing.Point(141, 189);
            this.chkMed.Name = "chkMed";
            this.chkMed.Size = new System.Drawing.Size(86, 19);
            this.chkMed.TabIndex = 9;
            this.chkMed.Text = "Medication";
            this.chkMed.UseVisualStyleBackColor = true;
            this.chkMed.CheckedChanged += new System.EventHandler(this.chkMed_CheckedChanged);
            // 
            // chkBeauty
            // 
            this.chkBeauty.AutoSize = true;
            this.chkBeauty.Location = new System.Drawing.Point(141, 214);
            this.chkBeauty.Name = "chkBeauty";
            this.chkBeauty.Size = new System.Drawing.Size(107, 19);
            this.chkBeauty.TabIndex = 10;
            this.chkBeauty.Text = "Beauty product";
            this.chkBeauty.UseVisualStyleBackColor = true;
            this.chkBeauty.CheckedChanged += new System.EventHandler(this.chkBeauty_CheckedChanged);
            // 
            // chkFNB
            // 
            this.chkFNB.AutoSize = true;
            this.chkFNB.Location = new System.Drawing.Point(255, 189);
            this.chkFNB.Name = "chkFNB";
            this.chkFNB.Size = new System.Drawing.Size(117, 19);
            this.chkFNB.TabIndex = 11;
            this.chkFNB.Text = "Food - Beverages";
            this.chkFNB.UseVisualStyleBackColor = true;
            this.chkFNB.CheckedChanged += new System.EventHandler(this.chkFNB_CheckedChanged);
            // 
            // chkDoc
            // 
            this.chkDoc.AutoSize = true;
            this.chkDoc.Location = new System.Drawing.Point(255, 214);
            this.chkDoc.Name = "chkDoc";
            this.chkDoc.Size = new System.Drawing.Size(82, 19);
            this.chkDoc.TabIndex = 12;
            this.chkDoc.Text = "Document";
            this.chkDoc.UseVisualStyleBackColor = true;
            this.chkDoc.CheckedChanged += new System.EventHandler(this.chkDoc_CheckedChanged);
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.Location = new System.Drawing.Point(141, 239);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(61, 19);
            this.chkOthers.TabIndex = 14;
            this.chkOthers.Text = "Others";
            this.chkOthers.UseVisualStyleBackColor = true;
            this.chkOthers.CheckedChanged += new System.EventHandler(this.chkOthers_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter title:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(141, 280);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(243, 96);
            this.rtbNotes.TabIndex = 18;
            this.rtbNotes.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Reminder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(158, 405);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(276, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(447, 115);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(177, 23);
            this.tbSearch.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(447, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search Reminder";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(447, 188);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(131, 23);
            this.btnViewAll.TabIndex = 24;
            this.btnViewAll.Text = "View All Reminders";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 447);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkOthers);
            this.Controls.Add(this.chkDoc);
            this.Controls.Add(this.chkFNB);
            this.Controls.Add(this.chkBeauty);
            this.Controls.Add(this.chkMed);
            this.Controls.Add(this.dtpReminder);
            this.Controls.Add(this.dtpExpired);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.Load += new System.EventHandler(this.MainUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.DateTimePicker dtpExpired;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.CheckBox chkMed;
        private System.Windows.Forms.CheckBox chkBeauty;
        private System.Windows.Forms.CheckBox chkFNB;
        private System.Windows.Forms.CheckBox chkDoc;
        private System.Windows.Forms.CheckBox chkOthers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}

