using LibraryDB_BusinessLayer;
using LMS.People;
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

namespace LMS.Book
{
    public partial class ctrlBookCardWithFillter : UserControl
    {
        public ctrlBookCardWithFillter()
        {
            InitializeComponent();
        }



        // Define a custom event handler delegate with parameters
        public event Action<int> OnBookSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void BookSelected(int BookID)
        {
            Action<int> handler = OnBookSelected;
            if (handler != null)
            {
                handler(BookID); // Raise the event with the parameter
            }
        }

        private bool _ShowAddPerson = true;
        public bool ShowAddPerson
        {
            get
            {
                return _ShowAddPerson;
            }
            set
            {
                _ShowAddPerson = value;
                btnAddNewBook.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilters.Enabled = _FilterEnabled;
            }
        }

        private int _BookID = -1;
        public int BookID
        {
            get { return 0 /*ctrlPersonCard1.BookID*/; }
        }
        public clsBook SelectedBookInfo
        {
            get { return ctrlBookDetails1.SelectedBookInfo; }
        }
        public void LoadBookInfo(int BookID)
        {

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = BookID.ToString();
            FindNow();

        }
        private void FindNow()
        {
            switch (cbFilterBy.Text)
            {
                case "Book ID":
                    ctrlBookDetails1.LoadBookInfo(int.Parse(txtFilterValue.Text));

                    break;

                case "ISBN":
                    ctrlBookDetails1.LoadBookInfoByISBN(txtFilterValue.Text);

                    break;
                case "Book Name":
                    ctrlBookDetails1.LoadBookInfoByBookName(txtFilterValue.Text);

                    break;

                default:
                    break;
            }

            if (OnBookSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnBookSelected(ctrlBookDetails1.BookID);
            //PersonSelected(ctrlPersonCard1.BookID); //Handle with OnBookSelected event 

        }



        private void DataBackEvent(object sender, int BookID)
        {
            // Handle the data received

            cbFilterBy.SelectedIndex = 1;
            txtFilterValue.Text = BookID.ToString();
            ctrlBookDetails1.LoadBookInfo(BookID);

        }

        public void FilterFocus()
        {
            txtFilterValue.Focus();
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {
           
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            txtFilterValue.Focus();
        }

        private void txtFilterValue_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterValue, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(txtFilterValue, null);
            }
        }

        

      

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Check if the pressed key is Enter (character code 13)
            if (e.KeyChar == (char)13)
            {

                btnFind.PerformClick();
            }

            //this will allow only digits if person id is selected
            if (cbFilterBy.Text == "Book ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            FindNow();
        }

        private void ctrlBookDetails1_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilterValue.Focus();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            frmAddBooks frm1 = new frmAddBooks();
            frm1.BackData += DataBackEvent; // Subscribe to the event
            frm1.ShowDialog();
        }
    }
}
