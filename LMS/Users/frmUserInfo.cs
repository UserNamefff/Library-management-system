using LibraryDB_Business;
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
    public partial class frmUserInfo : Form
    {
        
        
        private int _UserID;
        clsUser User;
        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void frmUserInfo_Load_1(object sender, EventArgs e)
        {
             User = clsUser.FindByUserID(_UserID);

            if (User == null)
            {
                MessageBox.Show($"No User with ID { _UserID}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            ctrlPersonCard11.LoadPersonInfo(User.PersonID);

            lblIsActive.Text = User.IsActive ? "Yes" : "No";
            lblUserID.Text = _UserID.ToString();
            lblUserName.Text = User.UserName;

            cbxFullAccess.Checked = (User.Permisions & (int)clsUser.ePermisions.FullAccess) == (int)clsUser.ePermisions.FullAccess;
            cbxManageBooks.Checked = (User.Permisions & (int)clsUser.ePermisions.ManageBooks) == (int)clsUser.ePermisions.ManageBooks;
            cbxManageMembers.Checked = (User.Permisions & (int)clsUser.ePermisions.ManageMembers) == (int)clsUser.ePermisions.ManageMembers;
            cbxManageUsers.Checked = (User.Permisions & (int)clsUser.ePermisions.ManageUsers) == (int)clsUser.ePermisions.ManageUsers;
            cbxManageCopies.Checked = (User.Permisions & (int)clsUser.ePermisions.ManageCopies) == (int)clsUser.ePermisions.ManageCopies;
            cbxManangeBorrowing.Checked = (User.Permisions & (int)clsUser.ePermisions.ManageBorowing) == (int)clsUser.ePermisions.ManageBorowing;
            cbxSubscriptions.Checked = (User.Permisions & (int)clsUser.ePermisions.ManageSubscriptions) == (int)clsUser.ePermisions.ManageSubscriptions;



        }


    }
}
