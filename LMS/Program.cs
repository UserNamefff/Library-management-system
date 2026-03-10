using LMS.Author;
using LMS.Book;
using LMS.Borrowing;
using LMS.Copies;
using LMS.Fines;
using LMS.Main;
using LMS.Members;
using LMS.Reservation;
using LMS.Subscriptions;
using LMS.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmAddUpdateMember());
            //Application.Run(new frmAddBooks());
            //Application.Run(new frmShowBookDetails(4));
            //Application.Run(new frmListBooks());
            //Application.Run(new frmAddBooks());
            Application.Run(new frmListCopies());
            //Application.Run(new frmAddAuthor());
            //Application.Run(new frmShowBookCopyDetails(1));
            
            
            Application.Run(new frmMain());
           // Application.Run(new frmListManageFines());
            //Application.Run(new frmReservationBook());
            //Application.Run(new frmBorrowingBook());

        }
    }
}
