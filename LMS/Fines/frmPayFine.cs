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

namespace LMS.Fines
{
    public partial class frmPayFine : Form
    {
        int BorrowingID;
        float Amount = 0;
        clsBorrowingRecord _Borrowing;
        clsFine _Fine;
        public frmPayFine(int borrowingID)
        {
            InitializeComponent();
             BorrowingID =  borrowingID;
        }
        public frmPayFine(clsBorrowingRecord borrowing)
        {
            InitializeComponent();
            _Borrowing = borrowing;

        }
        public frmPayFine(clsFine Fine)
        {
            InitializeComponent();
            _Fine = Fine;
            _Borrowing = Fine.BorrowingData;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        bool UpdatePaymentStatus()
        {
            _Fine.PaymentStatus = cbxPaymentStatus.Checked;
            
            return _Fine.Save();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Ensure from Update payment status ......
            if(_Fine != null)
            {
                if(UpdatePaymentStatus())
                     MessageBox.Show("Payed fine successfully ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string Notes = txtNotes.Text ;
            if (_Borrowing.PayFine(cbxPaymentStatus.Checked, Notes, Amount,clsGlobal.UserID))
            {
                MessageBox.Show("Payed fine successfully ...","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            MessageBox.Show("Error Failed Pay fine ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmPayFine_Load(object sender, EventArgs e)
        {
            if(_Borrowing == null) 
                 ctrlBorrowingDetails1.LoadBorrowingData(BorrowingID);

            else
                ctrlBorrowingDetails1.LoadBorrowingData(_Borrowing);

            TimeSpan LateDays = ctrlBorrowingDetails1.SelectedBorrowingInfo.DueDate- DateTime.Now;
            int LateDay = Convert .ToInt32(LateDays.Days);
            
            if (LateDay >= 0)
            {
                lblFineAmount.Text = "No Fine";
                lblLateDays.Text = "0";
               
            }
            else
            {
                clsSetting  setting =  clsSetting.FindBySettingID(clsGlobal.SettingID);
                LateDay = -1 * LateDay;
                Amount = Convert.ToSingle(setting.DefaultFinePerDay * LateDay);
                lblFineAmount.Text = (Amount).ToString();
                lblLateDays.Text = LateDay.ToString() +" "+"Days";
            }


        }
    }
}
