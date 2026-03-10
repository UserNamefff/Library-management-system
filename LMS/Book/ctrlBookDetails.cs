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
    public partial class ctrlBookDetails : UserControl
    {
        int _BookID;
        public int BookID {get {return _BookID; } }
        public clsBook SelectedBookInfo;
        public ctrlBookDetails()
        {
            InitializeComponent();
        }

        public void LoadBookInfo(int _BookID)
        {
            this. _BookID = _BookID;
            SelectedBookInfo = clsBook.FindByBookID(this._BookID);

            if (SelectedBookInfo != null)
            {
                this._BookID = SelectedBookInfo.BookID;
                //lblAuthorName.Text = clsAuthor.FindByAuthorID(Book.AuthorID).AuthorName;
                lblbLangBook.Text = clsLanguage.FindByLanguageID(SelectedBookInfo.LanguageID).LanguageName;
                lblGenreBook.Text = clsGenre.FindByGenreID(SelectedBookInfo.GenreID).GenreName;
                lblDescription.Text = SelectedBookInfo.AdditionalDetails;
                lblISBN.Text = SelectedBookInfo.ISBN;
                lblAuthorName.Text = clsAuthor.FindByAuthorID(SelectedBookInfo.AuthorID).AuthorName;
                lblPublicationDate.Text = clsFormat.DateToShort(SelectedBookInfo.PublicationDate);
                lblBookID.Text = SelectedBookInfo.BookID.ToString();
                lblTileBook.Text = SelectedBookInfo.Title;
            }

            else
                MessageBox.Show($"Book with {_BookID}  does not exist .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void LoadBookInfoByISBN(string ISBN)
        {
            SelectedBookInfo = clsBook.FindByISBN(ISBN);

            if (SelectedBookInfo != null)
            {
                this._BookID = SelectedBookInfo.BookID;
                //lblAuthorName.Text = clsAuthor.FindByAuthorID(Book.AuthorID).AuthorName;
                lblbLangBook.Text = clsLanguage.FindByLanguageID(SelectedBookInfo.LanguageID).LanguageName;
                lblGenreBook.Text = clsGenre.FindByGenreID(SelectedBookInfo.GenreID).GenreName;
                lblDescription.Text = SelectedBookInfo.AdditionalDetails;
                lblISBN.Text = SelectedBookInfo.ISBN;
                lblPublicationDate.Text = clsFormat.DateToShort(SelectedBookInfo.PublicationDate);
                lblBookID.Text = SelectedBookInfo.BookID.ToString();
                lblTileBook.Text = SelectedBookInfo.Title;
            }

            else
                MessageBox.Show($"Book with {ISBN}  does not exist .","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public void LoadBookInfoByBookName(string BookName)
        {
            SelectedBookInfo = clsBook.FindByTitle(BookName);

            if (SelectedBookInfo != null)
            {
                this._BookID = SelectedBookInfo.BookID;
                //lblAuthorName.Text = clsAuthor.FindByAuthorID(Book.AuthorID).AuthorName;
                lblbLangBook.Text = clsLanguage.FindByLanguageID(SelectedBookInfo.LanguageID).LanguageName;
                lblGenreBook.Text = clsGenre.FindByGenreID(SelectedBookInfo.GenreID).GenreName;
                lblDescription.Text = SelectedBookInfo.AdditionalDetails;
                lblISBN.Text = SelectedBookInfo.ISBN;
                lblPublicationDate.Text = clsFormat.DateToShort(SelectedBookInfo.PublicationDate);
                lblBookID.Text = SelectedBookInfo.BookID.ToString();
                lblTileBook.Text = SelectedBookInfo.Title;
            }

            else
                MessageBox.Show($"Book with {BookName}  does not exist .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //lblAuthorName.Text = clsAuthor.FindByAuthorID(Book.AuthorID).AuthorName;

        }


    }
}
