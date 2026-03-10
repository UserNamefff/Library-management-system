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

namespace LMS.Book
{
    public partial class frmShowBookDetails : Form
    {
        

        int BookID;
        public frmShowBookDetails(int BookID)
        {
            InitializeComponent();
            this.BookID = BookID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmShowBookDetails_Load(object sender, EventArgs e)
        {
            clsBook Book = clsBook.FindByBookID(this.BookID);

            //lblAuthorName.Text = clsAuthor.FindByAuthorID(Book.AuthorID).AuthorName;
            lblbLangBook.Text = clsLanguage.FindByLanguageID(Book.LanguageID).LanguageName;
            lblGenreBook.Text = clsGenre.FindByGenreID(Book.GenreID).GenreName;
            lblDescription.Text = Book.AdditionalDetails;
            lblISBN.Text = Book.ISBN;
            lblPublicationDate.Text = clsFormat.DateToShort(Book.PublicationDate);
            lblBookID.Text = Book.BookID.ToString();
            lblTileBook.Text = Book.Title;
        }
    }
}
