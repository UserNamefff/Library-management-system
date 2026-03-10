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

namespace LMS.Fines
{
    public partial class frmListManageFines : Form
    {
        BindingSource bindingData = new BindingSource();
        public frmListManageFines()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _Refresh()
        {
            DataTable dt = clsFine.GetFines();
            bindingData.DataSource = dt;
            dgvListFines.DataSource = bindingData;
        }
        private void frmListManageFines_Load(object sender, EventArgs e)
        {
            _Refresh();

        }
    }
}
