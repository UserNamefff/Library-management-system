using Guna.UI.WinForms;
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

namespace LMS.Author
{
    public partial class frmAddAuthor : Form
    {

        public delegate void GetAuthorID(object sender,int ID);
        public event GetAuthorID DataBack;
        public frmAddAuthor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show($"Fill Author name .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }


            clsAuthor author = new clsAuthor();

            author.AuthorName = txtAuthorName.Text.Trim();

            author.CountryID = clsCountry.FindByCountryName(cbCountry.Text.Trim()).CountryID;

            if (author.Save())
            {
                lblAuthorID.Text =author.AuthorID.ToString();
                _LoadAuthorData();
                MessageBox.Show("Added Author Successfully ...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            MessageBox.Show($"Error : can'nt Add Author .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }

        void _LoadAuthorData()
        {
            DataTable dt = clsAuthor.GetAuthors();

            if (dt != null )
            {

                dgvListAuthors .DataSource= dt;
                lblAuthorsNo.Text = dgvListAuthors.RowCount.ToString();
            }
        }

        private void txtAuthorName_Validating(object sender, CancelEventArgs e)
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

        private void frmAddAuthor_Load(object sender, EventArgs e)
        {
            DataTable cmCountries = clsCountry.GetCountries();
            
            foreach (DataRow dr in cmCountries.Rows)
            {
                cbCountry .Items.Add(dr["CountryName"].ToString());
            }

            cbCountry.SelectedIndex = cbCountry.FindString("Yemen");

            _LoadAuthorData();
        }

        int AuhtorID()
        {
            return (int )dgvListAuthors.CurrentRow.Cells[0].Value;
        }
        private void dgvListAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvListAuthors.Rows.Count == 0)
            {
                return;
            }

            DataBack?.Invoke(this, AuhtorID());

            this.Close();
        }


    }
}
