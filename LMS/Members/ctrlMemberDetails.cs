using LibraryDB_Business;
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
    public partial class ctrlMemberDetails : UserControl
    {
        public ctrlMemberDetails()
        {
            InitializeComponent();
        }

        public void LoadMemberInfo(int memberId)
        {
            clsMember Member = clsMember.FindByMemberID(memberId);

            if (Member != null)
            {
                ctrlPersonCard11.LoadPersonInfo(Member.PersonID);
                lblCreatedBy.Text = clsUser.FindByUserID(Member.CreatedBy).UserName;
                lblExpirationDate.Text = clsFormat.DateToShort(Member.ExpiredDateMembership);
                lblJoinDate.Text = clsFormat.DateToShort(Member.JoinDate);
                lblMemberID.Text = Member.MemberID.ToString();
                
            }
        }
    }
}
