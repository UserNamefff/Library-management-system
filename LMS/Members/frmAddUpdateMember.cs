
using LibraryDB_Business;
using LibraryDB_BusinessLayer;
using LMS.Global_Classes;
using LMS.People.Controls;
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
    public partial class frmAddUpdateMember : Form
    {


        clsMember Member;
        int PersonID;
        int MemberID;

        public enum enMode { AddNew = 0, Update = 1 };
        
        public delegate void GetBackData(object sender, int MemberID);
        public event GetBackData DataBack;

        enMode _Mode = enMode.AddNew;
        public frmAddUpdateMember()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateMember(int MemberID)
        {
            InitializeComponent();

            this. MemberID = MemberID;
            _Mode = enMode.Update;
        }
        private void frmAddUpdateMember_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            dtpExpirationDate.MinDate = DateTime.Now;
            dtpExpirationDate.MaxDate = DateTime.Now.AddYears(10);
            dtpExpirationDate.Value = dtpExpirationDate.MinDate;

            if ( _Mode == enMode.Update)
            {
                _LoadData();
                return;
            }

            lblExpirationDate.Text = clsFormat.DateToShort(DateTime.Now);
            lblJoinDate.Text = clsFormat.DateToShort(DateTime.Now);
            if (clsGlobal.CurrentUser != null)
            {
                lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
                return;
            }
            
            lblCreatedBy.Text = clsUser.FindByUserID(clsGlobal.UserID).UserName ;
            

        }

        void _LoadData()
        {
            clsMember member = clsMember.FindByMemberID(MemberID);

            if (member == null)
            {
                MessageBox.Show($"Member with ID = {MemberID}  does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtpExpirationDate.Enabled = false;

            ctrlPersonCardWithFillter11.LoadPersonInfo(Member.PersonID);
            ctrlPersonCardWithFillter11.FilterEnabled = false;

            lblCreatedBy.Text = clsUser.FindByUserID(Member.CreatedBy).UserName;
            lblExpirationDate.Text = clsFormat.DateToShort(Member.JoinDate);
            dtpExpirationDate.Value = Member.ExpiredDateMembership;

            lblJoinDate.Text = clsFormat.DateToShort(DateTime.Now);
            ckbxIsActive.Checked = member.IsActive;

        }

        private void ctrlPersonCardWithFillter11_OnPersonSelected(int obj)
        {
            PersonID = obj;
            if (obj < 0)
            {
                MessageBox.Show("No there exit Person ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            
            btnSave.Enabled = true;

            Member = new clsMember();
            Member.PersonID = PersonID;
            Member.JoinDate = DateTime.Now;
            Member.ExpiredDateMembership = DateTime.Now.AddYears(10);
            Member.IsActive = ckbxIsActive.Checked;
            Member.CreatedBy = clsGlobal.UserID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsMember.IsMemberExistByPersonID(PersonID))
            {
                MessageBox.Show(" This Member is already exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Member.PersonID = PersonID;
            Member.JoinDate = DateTime.Now;
            Member.ExpiredDateMembership = dtpExpirationDate.Value;
            Member.IsActive = ckbxIsActive.Checked;
            Member.CreatedBy = clsGlobal.UserID;

            if (Member.Save())
            {
                MessageBox.Show("Member Save successfully .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 lblMemberID .Text = Member.MemberID.ToString() ;

                if(DataBack != null)
                {
                    DataBack?.Invoke(this, Member.MemberID);
                    this.Close();

                }
                    
                return;
            }
            
            MessageBox.Show("Faild during save ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

        }



        /*
            this.MemberID = MemberID;
            Member.PersonID = PersonID;
            Member.JoinDate = JoinDate;
            Member.ExpiredDateMembership = ExpiredDateMembership;
            Member.IsActive = IsActive;
            Member.CreatedBy = CreatedBy;
         */
    }
}
