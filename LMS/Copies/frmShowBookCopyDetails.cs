using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Copies
{
    public partial class frmShowBookCopyDetails : Form
    {
        int CopyID;
        public frmShowBookCopyDetails(int CopyID)
        {
            InitializeComponent();
            this.CopyID = CopyID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookCopyDetails_Load(object sender, EventArgs e)
        {
            ctrlBookCopyInfo1.LoadBookCopyInfo(CopyID);
        }
    }
}
