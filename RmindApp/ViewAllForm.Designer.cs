
namespace RmindApp
{
    partial class ViewAllForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvAllReminders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(129, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvAllReminders
            // 
            this.dgvAllReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllReminders.Location = new System.Drawing.Point(33, 30);
            this.dgvAllReminders.Name = "dgvAllReminders";
            this.dgvAllReminders.RowTemplate.Height = 25;
            this.dgvAllReminders.Size = new System.Drawing.Size(636, 348);
            this.dgvAllReminders.TabIndex = 1;
            // 
            // ViewAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.dgvAllReminders);
            this.Controls.Add(this.btnBack);
            this.Name = "ViewAllForm";
            this.Text = "ViewAllForm";
            this.Load += new System.EventHandler(this.ViewAllForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvAllReminders;
    }
}