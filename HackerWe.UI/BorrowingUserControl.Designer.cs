namespace HackerWe.UI
{
    partial class BorrowingUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpBorrowingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDueReturningdate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpBorrowingDate
            // 
            this.dtpBorrowingDate.Location = new System.Drawing.Point(168, 59);
            this.dtpBorrowingDate.Name = "dtpBorrowingDate";
            this.dtpBorrowingDate.Size = new System.Drawing.Size(250, 27);
            this.dtpBorrowingDate.TabIndex = 0;
            this.dtpBorrowingDate.ValueChanged += new System.EventHandler(this.dtpBorrowingDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrowing Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client";
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(168, 149);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(250, 28);
            this.cmbBooks.TabIndex = 3;
            // 
            // cmbClients
            // 
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(168, 105);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(250, 28);
            this.cmbClients.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book";
            // 
            // lblDueReturningdate
            // 
            this.lblDueReturningdate.AutoSize = true;
            this.lblDueReturningdate.Location = new System.Drawing.Point(184, 213);
            this.lblDueReturningdate.Name = "lblDueReturningdate";
            this.lblDueReturningdate.Size = new System.Drawing.Size(143, 20);
            this.lblDueReturningdate.TabIndex = 6;
            this.lblDueReturningdate.Text = "Due Returning Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Due Returning Date:";
            // 
            // BorrowingUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDueReturningdate);
            this.Controls.Add(this.cmbClients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBorrowingDate);
            this.Name = "BorrowingUserControl";
            this.Size = new System.Drawing.Size(844, 609);
            this.Load += new System.EventHandler(this.BorrowingUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBorrowingDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDueReturningdate;
        private System.Windows.Forms.Label label4;
    }
}
