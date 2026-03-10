using LibraryDB_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Reservation
{
    public partial class frmListReservations : Form
    {
        BindingSource bindingSource = new BindingSource();
        public frmListReservations()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListReservations_Load(object sender, EventArgs e)
        {
            DataTable dt = clsReservation.GetReservations();
            bindingSource.DataSource = dt;
            dgvListReservations.DataSource = bindingSource;
            lblReservationsNo.Text = dgvListReservations.RowCount.ToString();
        }
    }
}
