namespace LMS.Borrowing
{
    partial class frmBorrowingBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ddd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI.WinForms.GunaButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBookID = new Guna.UI.WinForms.GunaTextBox();
            this.cmbLangBook = new Guna.UI.WinForms.GunaComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBookCopies = new Guna.UI.WinForms.GunaDataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.ctrlMemberInfoWithFillter1 = new LMS.Members.ctrlMemberInfoWithFillter();
            this.ctrlBookCardWithFillter1 = new LMS.Book.ctrlBookCardWithFillter();
            this.ddd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // ddd
            // 
            this.ddd.Controls.Add(this.tabPage1);
            this.ddd.Controls.Add(this.tabPage2);
            this.ddd.Location = new System.Drawing.Point(13, 48);
            this.ddd.Name = "ddd";
            this.ddd.SelectedIndex = 0;
            this.ddd.Size = new System.Drawing.Size(1000, 780);
            this.ddd.TabIndex = 1;
            this.ddd.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.ddd_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlMemberInfoWithFillter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 751);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Member";
            // 
            // btnNext
            // 
            this.btnNext.AnimationHoverSpeed = 0.07F;
            this.btnNext.AnimationSpeed = 0.03F;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BaseColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.Black;
            this.btnNext.BorderSize = 1;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.FocusedColor = System.Drawing.Color.Empty;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNext.Image = global::LMS.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageSize = new System.Drawing.Size(27, 27);
            this.btnNext.Location = new System.Drawing.Point(809, 669);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Radius = 10;
            this.btnNext.Size = new System.Drawing.Size(98, 42);
            this.btnNext.TabIndex = 268;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtBookID);
            this.tabPage2.Controls.Add(this.cmbLangBook);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvBookCopies);
            this.tabPage2.Controls.Add(this.ctrlBookCardWithFillter1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Select Book";
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.Color.Transparent;
            this.txtBookID.BaseColor = System.Drawing.Color.White;
            this.txtBookID.BorderColor = System.Drawing.Color.Lime;
            this.txtBookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookID.Location = new System.Drawing.Point(332, 431);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.PasswordChar = '\0';
            this.txtBookID.Radius = 15;
            this.txtBookID.SelectedText = "";
            this.txtBookID.Size = new System.Drawing.Size(149, 30);
            this.txtBookID.TabIndex = 264;
            this.txtBookID.Visible = false;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // cmbLangBook
            // 
            this.cmbLangBook.BackColor = System.Drawing.Color.Transparent;
            this.cmbLangBook.BaseColor = System.Drawing.Color.White;
            this.cmbLangBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbLangBook.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLangBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLangBook.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLangBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLangBook.ForeColor = System.Drawing.Color.Black;
            this.cmbLangBook.FormattingEnabled = true;
            this.cmbLangBook.Items.AddRange(new object[] {
            "All",
            "Copy ID",
            "Avaliable",
            "Non avaliable"});
            this.cmbLangBook.Location = new System.Drawing.Point(133, 432);
            this.cmbLangBook.Name = "cmbLangBook";
            this.cmbLangBook.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbLangBook.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbLangBook.Radius = 15;
            this.cmbLangBook.Size = new System.Drawing.Size(192, 31);
            this.cmbLangBook.StartIndex = 0;
            this.cmbLangBook.TabIndex = 262;
            this.cmbLangBook.SelectedIndexChanged += new System.EventHandler(this.cmbLangBook_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 261;
            this.label6.Text = "Fillter By :";
            // 
            // dgvBookCopies
            // 
            this.dgvBookCopies.AllowUserToAddRows = false;
            this.dgvBookCopies.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBookCopies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookCopies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookCopies.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookCopies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBookCopies.CausesValidation = false;
            this.dgvBookCopies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookCopies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookCopies.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookCopies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookCopies.EnableHeadersVisualStyles = false;
            this.dgvBookCopies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvBookCopies.Location = new System.Drawing.Point(16, 467);
            this.dgvBookCopies.MultiSelect = false;
            this.dgvBookCopies.Name = "dgvBookCopies";
            this.dgvBookCopies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookCopies.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookCopies.RowHeadersVisible = false;
            this.dgvBookCopies.RowHeadersWidth = 51;
            this.dgvBookCopies.RowTemplate.Height = 26;
            this.dgvBookCopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookCopies.Size = new System.Drawing.Size(950, 263);
            this.dgvBookCopies.StandardTab = true;
            this.dgvBookCopies.TabIndex = 260;
            this.dgvBookCopies.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvBookCopies.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookCopies.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBookCopies.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBookCopies.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBookCopies.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBookCopies.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookCopies.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvBookCopies.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvBookCopies.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvBookCopies.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBookCopies.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBookCopies.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBookCopies.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvBookCopies.ThemeStyle.ReadOnly = false;
            this.dgvBookCopies.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBookCopies.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBookCopies.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBookCopies.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBookCopies.ThemeStyle.RowsStyle.Height = 26;
            this.dgvBookCopies.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvBookCopies.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1023, 31);
            this.lblTitle.TabIndex = 265;
            this.lblTitle.Text = "Borrowing Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.Ivory;
            this.btnSave.BorderColor = System.Drawing.Color.Lime;
            this.btnSave.BorderSize = 1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.Image = global::LMS.Properties.Resources.icons8_add_book_48;
            this.btnSave.ImageSize = new System.Drawing.Size(27, 27);
            this.btnSave.Location = new System.Drawing.Point(872, 843);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 13;
            this.btnSave.Size = new System.Drawing.Size(137, 42);
            this.btnSave.TabIndex = 267;
            this.btnSave.Text = "Borrowing";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Ivory;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderSize = 1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.Image = global::LMS.Properties.Resources.CloseBlack1;
            this.btnClose.ImageSize = new System.Drawing.Size(27, 27);
            this.btnClose.Location = new System.Drawing.Point(741, 843);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(125, 42);
            this.btnClose.TabIndex = 266;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlMemberInfoWithFillter1
            // 
            this.ctrlMemberInfoWithFillter1.Location = new System.Drawing.Point(82, 94);
            this.ctrlMemberInfoWithFillter1.Name = "ctrlMemberInfoWithFillter1";
            this.ctrlMemberInfoWithFillter1.Size = new System.Drawing.Size(842, 526);
            this.ctrlMemberInfoWithFillter1.TabIndex = 0;
            this.ctrlMemberInfoWithFillter1.dlGetMemberID += new System.Action<int>(this.ctrlMemberInfoWithFillter1_dlGetMemberID);
            // 
            // ctrlBookCardWithFillter1
            // 
            this.ctrlBookCardWithFillter1.FilterEnabled = true;
            this.ctrlBookCardWithFillter1.Location = new System.Drawing.Point(15, 16);
            this.ctrlBookCardWithFillter1.Name = "ctrlBookCardWithFillter1";
            this.ctrlBookCardWithFillter1.ShowAddPerson = true;
            this.ctrlBookCardWithFillter1.Size = new System.Drawing.Size(963, 409);
            this.ctrlBookCardWithFillter1.TabIndex = 0;
            this.ctrlBookCardWithFillter1.OnBookSelected += new System.Action<int>(this.ctrlBookCardWithFillter1_OnBookSelected);
            // 
            // frmBorrowingBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1023, 903);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ddd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBorrowingBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borrowing Book";
            this.Load += new System.EventHandler(this.frmBorrowingBook_Load);
            this.ddd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCopies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Members.ctrlMemberInfoWithFillter ctrlMemberInfoWithFillter1;
        private System.Windows.Forms.TabControl ddd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Book.ctrlBookCardWithFillter ctrlBookCardWithFillter1;
        private Guna.UI.WinForms.GunaDataGridView dgvBookCopies;
        private Guna.UI.WinForms.GunaComboBox cmbLangBook;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton btnNext;
        private Guna.UI.WinForms.GunaTextBox txtBookID;
    }
}