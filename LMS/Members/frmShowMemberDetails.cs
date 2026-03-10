using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Members
{
    
    public partial class frmShowMemberDetails : Form
    {
        int MemberID;
        public frmShowMemberDetails(int MemberID )
        {
            InitializeComponent();
            this.MemberID = MemberID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowMemberDetails_Load(object sender, EventArgs e)
        {
            ctrlMemberDetails1.LoadMemberInfo(MemberID);
        }
    }
}
