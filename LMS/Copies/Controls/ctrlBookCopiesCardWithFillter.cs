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

namespace LMS.Copies.Controls
{
    public partial class ctrlBookCopiesCardWithFillter : UserControl
    {
        public ctrlBookCopiesCardWithFillter()
        {
            InitializeComponent();
        }



        private void ctrlBookCardWithFillter1_OnBookSelected(int obj)
        {
            if (obj == 0)
            {
                return;

            }

            //clsCopy Copy = clsCopy.FindByBookID(ctrlBookCardWithFillter1.SelectedBookInfo.BookID); 

        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
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
            int copyID = Convert.ToInt32(txtFilterValue.Text);
            ctrlBookCopyInfo1.LoadBookCopyInfo(copyID) ;
            
        }

        private void ctrlBookCopyInfo1_dlgCopyID(int obj)
        {
            if (obj == 0)
            {
                return;
            }


        }



    }
}
