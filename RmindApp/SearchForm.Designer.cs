
namespace RmindApp
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.tbSearch2 = new System.Windows.Forms.TextBox();
            this.tbTitle2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpExpired2 = new System.Windows.Forms.DateTimePicker();
            this.dtpReminder2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbNotes2 = new System.Windows.Forms.RichTextBox();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbBeauty = new System.Windows.Forms.RadioButton();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.rbFNB = new System.Windows.Forms.RadioButton();
            this.rbDoc = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Location = new System.Drawing.Point(29, 499);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(63, 25);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Location = new System.Drawing.Point(276, 499);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(79, 25);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Location = new System.Drawing.Point(847, 499);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(276, 64);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowTemplate.Height = 25;
            this.dgvSearch.Size = new System.Drawing.Size(652, 414);
            this.dgvSearch.TabIndex = 3;
            this.dgvSearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_RowHeaderMouseClick);
            // 
            // tbSearch2
            // 
            this.tbSearch2.Location = new System.Drawing.Point(29, 12);
            this.tbSearch2.Name = "tbSearch2";
            this.tbSearch2.PlaceholderText = "Search by title";
            this.tbSearch2.Size = new System.Drawing.Size(233, 23);
            this.tbSearch2.TabIndex = 4;
            // 
            // tbTitle2
            // 
            this.tbTitle2.Location = new System.Drawing.Point(130, 93);
            this.tbTitle2.Name = "tbTitle2";
            this.tbTitle2.Size = new System.Drawing.Size(132, 23);
            this.tbTitle2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Expired Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reminder Date";
            // 
            // dtpExpired2
            // 
            this.dtpExpired2.Location = new System.Drawing.Point(130, 132);
            this.dtpExpired2.Name = "dtpExpired2";
            this.dtpExpired2.Size = new System.Drawing.Size(132, 23);
            this.dtpExpired2.TabIndex = 10;
            // 
            // dtpReminder2
            // 
            this.dtpReminder2.Location = new System.Drawing.Point(130, 168);
            this.dtpReminder2.Name = "dtpReminder2";
            this.dtpReminder2.Size = new System.Drawing.Size(132, 23);
            this.dtpReminder2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Notes";
            // 
            // rtbNotes2
            // 
            this.rtbNotes2.Location = new System.Drawing.Point(29, 356);
            this.rtbNotes2.Name = "rtbNotes2";
            this.rtbNotes2.Size = new System.Drawing.Size(233, 122);
            this.rtbNotes2.TabIndex = 21;
            this.rtbNotes2.Text = "";
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Location = new System.Drawing.Point(3, 19);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(85, 19);
            this.rbMed.TabIndex = 22;
            this.rbMed.TabStop = true;
            this.rbMed.Text = "Medication";
            this.rbMed.UseVisualStyleBackColor = true;
            // 
            // rbBeauty
            // 
            this.rbBeauty.AutoSize = true;
            this.rbBeauty.Location = new System.Drawing.Point(3, 44);
            this.rbBeauty.Name = "rbBeauty";
            this.rbBeauty.Size = new System.Drawing.Size(106, 19);
            this.rbBeauty.TabIndex = 23;
            this.rbBeauty.TabStop = true;
            this.rbBeauty.Text = "Beauty product";
            this.rbBeauty.UseVisualStyleBackColor = true;
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Location = new System.Drawing.Point(3, 70);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(60, 19);
            this.rbOthers.TabIndex = 24;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "Others";
            this.rbOthers.UseVisualStyleBackColor = true;
            // 
            // rbFNB
            // 
            this.rbFNB.AutoSize = true;
            this.rbFNB.Location = new System.Drawing.Point(119, 19);
            this.rbFNB.Name = "rbFNB";
            this.rbFNB.Size = new System.Drawing.Size(110, 19);
            this.rbFNB.TabIndex = 25;
            this.rbFNB.TabStop = true;
            this.rbFNB.Text = "Food-Beverages";
            this.rbFNB.UseVisualStyleBackColor = true;
            // 
            // rbDoc
            // 
            this.rbDoc.AutoSize = true;
            this.rbDoc.Location = new System.Drawing.Point(119, 44);
            this.rbDoc.Name = "rbDoc";
            this.rbDoc.Size = new System.Drawing.Size(81, 19);
            this.rbDoc.TabIndex = 26;
            this.rbDoc.TabStop = true;
            this.rbDoc.Text = "Document";
            this.rbDoc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDoc);
            this.groupBox1.Controls.Add(this.rbMed);
            this.groupBox1.Controls.Add(this.rbFNB);
            this.groupBox1.Controls.Add(this.rbBeauty);
            this.groupBox1.Controls.Add(this.rbOthers);
            this.groupBox1.Location = new System.Drawing.Point(29, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 98);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(29, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 536);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbNotes2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpReminder2);
            this.Controls.Add(this.dtpExpired2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTitle2);
            this.Controls.Add(this.tbSearch2);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Name = "SearchForm";
            this.Text = "rmind";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.TextBox tbSearch2;
        private System.Windows.Forms.TextBox tbTitle2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpExpired2;
        private System.Windows.Forms.DateTimePicker dtpReminder2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbNotes2;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbBeauty;
        private System.Windows.Forms.RadioButton rbOthers;
        private System.Windows.Forms.RadioButton rbFNB;
        private System.Windows.Forms.RadioButton rbDoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
    }
}