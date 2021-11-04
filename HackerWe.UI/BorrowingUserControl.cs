using HackerWe.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackerWe.UI
{
    public partial class BorrowingUserControl : UserControl
    {
        Borowing borowing = new Borowing();

        public BorrowingUserControl()
        {
            InitializeComponent();
        }

        private void BorrowingUserControl_Load(object sender, EventArgs e)
        {
            dtpBorrowingDate.MinDate = DateTime.Now;
            dtpBorrowingDate.MaxDate = DateTime.Now.AddDays(2);
        }

        private void dtpBorrowingDate_ValueChanged(object sender, EventArgs e)
        {
            borowing.BorowingDate=dtpBorrowingDate.Value;
            lblDueReturningdate.Text = borowing.DueReturningDate.ToString("dd/MM/yyyy");
        }
    }
}
