using LibraryDB_Business;
using LibraryDB_BusinessLayer;
using LMS.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.Users
{
    public partial class frmAddUpdateUser : Form
    {
        int PersonID;
        clsUser UserInfo;
        int UserID;
        int Permissions = 0;

        public enum enMode { AddNew = 0, Update = 1 };

        enMode _Mode = enMode.AddNew;
        
        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            btnEditePersonalUserInfo.Visible = false;

        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            _Mode = enMode.Update;

            lblTitle.Text = "Update User Info";
            btnEditePersonalUserInfo.Visible = true;

        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            

            if (_Mode == enMode.Update)
            {
                UserInfo = clsUser.FindByUserID(UserID);
                ctrlPersonCardWithFillter11.LoadPersonInfo(UserInfo.PersonID);
                ctrlPersonCardWithFillter11.FilterEnabled = false;

                cbxFullAccess.Checked = (UserInfo.Permisions & (int)clsUser.ePermisions.FullAccess) == (int)clsUser.ePermisions.FullAccess;
                cbxManageBooks.Checked = (UserInfo.Permisions & (int)clsUser.ePermisions.ManageBooks) == (int)clsUser.ePermisions.ManageBooks;
                cbxManageMembers.Checked  = (UserInfo.Permisions & (int)clsUser.ePermisions.ManageMembers) == (int)clsUser.ePermisions.ManageMembers ;
                cbxManageUsers.Checked = (UserInfo.Permisions & (int)clsUser.ePermisions.ManageUsers) == (int)clsUser.ePermisions.ManageUsers;
                cbxManageCopies.Checked  = (UserInfo.Permisions & (int)clsUser.ePermisions.ManageCopies) == (int)clsUser.ePermisions.ManageCopies;
                cbxManangeBorrowing.Checked  = (UserInfo.Permisions & (int)clsUser.ePermisions.ManageBorowing) == (int)clsUser.ePermisions.ManageBorowing;
                cbxSubscriptions.Checked  = (UserInfo.Permisions & (int)clsUser.ePermisions.ManageSubscriptions) == (int)clsUser.ePermisions.ManageSubscriptions;
                

                lblUserID.Text = UserID.ToString();
                txtUserName.Text = UserInfo.UserName;
                txtPassword.Text = UserInfo.Password;
                cbxIsActive.Checked = UserInfo.IsActive;

                cbxIsActive.Checked = UserInfo.IsActive;
                btnSave.Enabled = true;
                
                return;
            }

            UserInfo = new clsUser();
            btnSave.Enabled = false;
        }
        private void ctrlPersonCardWithFillter11_OnPersonSelected_1(int obj)
        {
            PersonID = obj;

            if (PersonID < 0)
            {

                MessageBox.Show("No Person ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;


                return;
            }

            if (clsUser.IsUserExistByPersonID(PersonID))
            {
                MessageBox.Show(" Select User Is Exists .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnSave.Enabled = true;
            


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;

            }

            UserInfo.Permisions = Permissions;
            UserInfo.PersonID = PersonID;
            UserInfo .IsActive = cbxIsActive.Checked;
            UserInfo.UserName = txtUserName.Text.Trim();
            UserInfo.Password = txtPassword.Text.Trim();


            if (UserInfo.Save())
            {
                MessageBox.Show("Added user successfully ..","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                lblUserID.Text = UserInfo.UserID.ToString();

                return;
            }
            



        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
        private void ValidateUserNameIfExist(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "This field is required!");
            }

            if(_Mode == enMode.AddNew)
            {
                if (clsUser.IsUserExistByUserName(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "User Name is already exist .");
                }

            }
             
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtUserName, null);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddPermitions(object sender, EventArgs e)
        {
            CheckBox Temp = (CheckBox)sender;

            if (Temp.Checked)
            {
                Permissions += Convert.ToInt32 (Temp.Tag);
            }

            else
            {
                Permissions -= Convert.ToInt32(Temp.Tag);

                cbxFullAccess.Checked = false;

            }

        }
        private void cbxFullAccess_CheckedChanged(object sender, EventArgs e)
        {
            

            if(cbxFullAccess.Checked)
            {
                cbxFullAccess.Checked = true;
                cbxManageBooks.Checked = true;
                cbxManageMembers.Checked = true; ;
                cbxManageUsers.Checked = true;
                cbxManageCopies.Checked = true;
                cbxManangeBorrowing.Checked = true;
                cbxSubscriptions.Checked = true;

                //Permissions = (int)cbxManageBooks.Tag + (int)cbxManageMembers.Tag + (int)cbxManageUsers.Tag + (int)cbxManageCopies.Tag + (int)cbxManangeBorrowing.Tag + (int)cbxSubscriptions.Tag;
            }
            else
            {
                cbxFullAccess.Checked = false ;
                cbxManageBooks.Checked = false;
                cbxManageMembers.Checked = false; ;
                cbxManageUsers.Checked = false;
                cbxManageCopies.Checked = false;
                cbxManangeBorrowing.Checked = false;
                cbxSubscriptions.Checked = false;
            }

        }
        private void btnEditePersonalUserInfo_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            ctrlPersonCardWithFillter11.LoadPersonInfo(PersonID);

        }
    

    }
}



