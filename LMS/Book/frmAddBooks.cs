using Guna.UI.WinForms;
using LibraryDB_BusinessLayer;
using LMS.Author;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmAddBooks : Form
    {
        clsBook Book;
        int BookID;
        clsBook.enMode Mode = clsBook.enMode.AddNew;

        public delegate void OnBackData(object sender,int BookID);

        public event OnBackData BackData;
        public frmAddBooks()
        {
            InitializeComponent();

            Book = new clsBook();
            Mode = clsBook.enMode.AddNew;
        }
        public frmAddBooks(int BookID)
        {
            InitializeComponent();

            this.BookID = BookID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBookTital_Validating(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 

            GunaTextBox Temp = ((GunaTextBox)sender);
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                return;

            }

            clsBook Book = new clsBook();
            Book.ISBN = txtISBN.Text.Trim();
            Book.Title = txtBookTital.Text.Trim();
            Book.GenreID = clsGenre.FindByGenreName(cmbGenreBook.Text.Trim()).GenreID;
            Book.LanguageID = clsLanguage.FindByLanguageName(cmbLangBook.Text.Trim()).LanguageID;
            Book.PublicationDate = dtpPublicationDate.Value;
            Book.AuthorID = Author.AuthorID;
            
            Book.AdditionalDetails = string.IsNullOrEmpty(txtDescription.Text.Trim())?"": txtDescription.Text.Trim();

            if (Book.Save())
            {
                lblBookID.Text = Book.BookID.ToString();
                MessageBox.Show("Added Book Successfully ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                BackData?.Invoke(this,Book.BookID);

                return;
            }


        }

        void _FillComboxes()
        {
            DataTable dtGenre = clsGenre.GetGenres();
            DataTable dtLanguages = clsLanguage.GetLanguages();

            foreach (DataRow dr in dtGenre.Rows)
            {
                cmbGenreBook.Items.Add(dr["GenreName"].ToString());
            }

            foreach (DataRow dr in dtLanguages.Rows)
            {
                cmbLangBook.Items.Add(dr["LanguageName"]);
            }

            cmbLangBook.SelectedIndex = 0;
            cmbGenreBook.SelectedIndex = 0;

        }
        private void frmAddBooks_Load(object sender, EventArgs e)
        {
            _FillComboxes();
            if (Mode == clsBook.enMode.Update)
            {
                Book = clsBook.FindByBookID(BookID);

                txtAuthorName.Text = Book.AuthorID.ToString();//clsAuthor.FindByAuthorID (AuthorID);
                txtBookTital.Text = Book.Title;
                txtDescription.Text = Book.AdditionalDetails;
                cmbGenreBook.SelectedIndex = cmbGenreBook.FindString(clsGenre.FindByGenreID(Book.GenreID).GenreName);
                //cmbLangBook.SelectedItem = cmbLangBook.FindString(clsLanguage.FindByLanguageID(Book))

            }


        }

        private void btnSelectAuthor_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnSelectAuthor, "Select Author");
        }

        private void btnSelectAuthor_Click(object sender, EventArgs e)
        {
            frmAddAuthor frm = new frmAddAuthor();
            frm.DataBack += GetAuthorData;
            frm.ShowDialog();
            
            //frm.Close();

        }

        clsAuthor Author;
        void GetAuthorData(object sender,int AuthorID)
        {
             Author = clsAuthor .FindByAuthorID(AuthorID);

            if (Author == null)
            {
                return;

            }
            
            txtAuthorName.Text = Author.AuthorName;

        }


    }
}
