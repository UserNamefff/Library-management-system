using LibraryDB_BusinessLayer;
using LMS.Global_Classes;
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
    public partial class ctrlMemberInfoWithFillter : UserControl
    {
         clsMember Member;
        public clsMember SelectedMember{get{return Member; } }

        public event Action<int >  dlGetMemberID;
        protected void GetMemberID(int ID)
        {
            Action<int>  Handling=dlGetMemberID;

            if (Handling != null)
                Handling(ID);
        }

        public ctrlMemberInfoWithFillter()
        {
            InitializeComponent();
        }

        private void txtMemberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            LoadMemberData(Convert.ToInt32(txtMemberID.Text.Trim()));

        }

        private void txtMemberID_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtMemberID.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMemberID, "This Field is required .");
            }
            else
            {
                // e.Cancel = false;
                errorProvider1.SetError(txtMemberID,null);

            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            frmAddUpdateMember frm = new frmAddUpdateMember();
            frm.DataBack += GetMemberData;

            frm.ShowDialog();

            //frm.Close();
        }

        void LoadMemberData(int MemberID)
        {

             Member = clsMember.FindByMemberID(MemberID);

            if (Member == null)
            {
                MessageBox.Show("Error :  Member with ID = {txtMemberID.Text} does not exist -:( ", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ctrlPersonCard11.LoadPersonInfo(Member.PersonID);
            lblCreatedBy.Text = Member.UserInfo.UserName;
            lblExpirationDate.Text = clsFormat.DateToShort(Member.ExpiredDateMembership);
            lblJoinDate.Text = clsFormat.DateToShort(Member.JoinDate);
            lblMemberID.Text = txtMemberID.Text;
            GetMemberID(Member.MemberID);
        }

        void GetMemberData(object sender , int MemberID)
        {
            LoadMemberData(MemberID);
            txtMemberID.Text = MemberID.ToString();
        }
    }
}
