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

namespace LMS.Copies.Controls
{
    public partial class ctrlBookCopyInfo : UserControl
    {
        clsCopy copy;
        public ctrlBookCopyInfo()
        {
            InitializeComponent();
        }
        public clsCopy SelectedCopy
        {
            get { return copy; }
        }

        public event Action<int> dlgCopyID;

        protected void GetCopyID(int CopyID)
        {
            Action<int> Handling =  dlgCopyID;

            if (Handling != null)
            {
                Handling(CopyID);
            }
        }

        public void LoadBookCopyInfo(int CopyID)
        {
            copy = clsCopy.FindByCopyID(CopyID);

            if (copy != null)
            {
                ctrlBookDetails1.LoadBookInfo(copy.BookID);

                lblAddingDate.Text = clsFormat.DateToShort(copy.AddDate);
                lblCopyID.Text = copy.CopyID.ToString();
                lblIndex.Text = copy.IndexCopy.ToString();

                lblIsAvaliable.Text = copy.AvailabilityStatus ? "Yes" : "No";

                GetCopyID(CopyID);
                return;
            }
            
            MessageBox.Show($"Copy With ID = {CopyID} does not exist ..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
