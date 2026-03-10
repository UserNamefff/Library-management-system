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

namespace LMS.People
{
    public partial class frmShowPersonDetails : Form
    {
        

        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            ctrlPersonCard11.LoadPersonInfo(PersonID);

        }

        public frmShowPersonDetails(string NationalNo)
        {
            InitializeComponent();
            ctrlPersonCard11.LoadPersonInfo(NationalNo);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
