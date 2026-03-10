namespace LMS.Borrowing
{
    partial class frmListBorrowing
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListBorrowings = new Guna.UI.WinForms.GunaDataGridView();
            this.cnxBorrowingBook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblBooksNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbGenreBook = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.ShowBorrowingDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowingBook = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBorrowings)).BeginInit();
            this.cnxBorrowingBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListBorrowings
            // 
            this.dgvListBorrowings.AllowUserToAddRows = false;
            this.dgvListBorrowings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvListBorrowings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListBorrowings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBorrowings.BackgroundColor = System.Drawing.Color.White;
            this.dgvListBorrowings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListBorrowings.CausesValidation = false;
            this.dgvListBorrowings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListBorrowings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListBorrowings.ColumnHeadersHeight = 25;
            this.dgvListBorrowings.ContextMenuStrip = this.cnxBorrowingBook;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListBorrowings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListBorrowings.EnableHeadersVisualStyles = false;
            this.dgvListBorrowings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListBorrowings.Location = new System.Drawing.Point(10, 276);
            this.dgvListBorrowings.MultiSelect = false;
            this.dgvListBorrowings.Name = "dgvListBorrowings";
            this.dgvListBorrowings.ReadOnly = true;
            this.dgvListBorrowings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListBorrowings.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListBorrowings.RowHeadersVisible = false;
            this.dgvListBorrowings.RowHeadersWidth = 51;
            this.dgvListBorrowings.RowTemplate.Height = 26;
            this.dgvListBorrowings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListBorrowings.Size = new System.Drawing.Size(1380, 295);
            this.dgvListBorrowings.StandardTab = true;
            this.dgvListBorrowings.TabIndex = 266;
            this.dgvListBorrowings.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvListBorrowings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListBorrowings.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListBorrowings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListBorrowings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListBorrowings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListBorrowings.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListBorrowings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListBorrowings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListBorrowings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvListBorrowings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListBorrowings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListBorrowings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListBorrowings.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvListBorrowings.ThemeStyle.ReadOnly = true;
            this.dgvListBorrowings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListBorrowings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListBorrowings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListBorrowings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListBorrowings.ThemeStyle.RowsStyle.Height = 26;
            this.dgvListBorrowings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListBorrowings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cnxBorrowingBook
            // 
            this.cnxBorrowingBook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnxBorrowingBook.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cnxBorrowingBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowBorrowingDetails,
            this.BorrowingBook,
            this.returnBookToolStripMenuItem});
            this.cnxBorrowingBook.Name = "contextMenuStrip1";
            this.cnxBorrowingBook.Size = new System.Drawing.Size(350, 158);
            this.cnxBorrowingBook.Text = "cnxBorrowingBook";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(482, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 36);
            this.label1.TabIndex = 269;
            this.label1.Text = "Manage Borrowing Books";
            // 
            // lblBooksNo
            // 
            this.lblBooksNo.AutoSize = true;
            this.lblBooksNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksNo.Location = new System.Drawing.Point(123, 589);
            this.lblBooksNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooksNo.Name = "lblBooksNo";
            this.lblBooksNo.Size = new System.Drawing.Size(48, 25);
            this.lblBooksNo.TabIndex = 272;
            this.lblBooksNo.Text = "###";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 588);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 270;
            this.label4.Text = "Books No :";
            // 
            // cmbGenreBook
            // 
            this.cmbGenreBook.BackColor = System.Drawing.Color.Transparent;
            this.cmbGenreBook.BaseColor = System.Drawing.Color.White;
            this.cmbGenreBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbGenreBook.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGenreBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenreBook.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGenreBook.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGenreBook.ForeColor = System.Drawing.Color.Black;
            this.cmbGenreBook.FormattingEnabled = true;
            this.cmbGenreBook.Items.AddRange(new object[] {
            "Non",
            "Borrowed",
            "returned"});
            this.cmbGenreBook.Location = new System.Drawing.Point(128, 237);
            this.cmbGenreBook.Name = "cmbGenreBook";
            this.cmbGenreBook.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbGenreBook.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbGenreBook.Radius = 15;
            this.cmbGenreBook.Size = new System.Drawing.Size(239, 31);
            this.cmbGenreBook.StartIndex = 0;
            this.cmbGenreBook.TabIndex = 276;
            this.cmbGenreBook.SelectedIndexChanged += new System.EventHandler(this.cmbGenreBook_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 275;
            this.label2.Text = "Fillter By  :";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::LMS.Properties.Resources.issue;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAdd.Location = new System.Drawing.Point(1303, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(87, 72);
            this.btnAdd.TabIndex = 274;
            this.toolTip1.SetToolTip(this.btnAdd, "Add borrowing book");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.Cyan;
            this.btnClose.BorderSize = 2;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::LMS.Properties.Resources.Close_64;
            this.btnClose.ImageSize = new System.Drawing.Size(23, 23);
            this.btnClose.Location = new System.Drawing.Point(1264, 579);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.TabIndex = 273;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowBorrowingDetails
            // 
            this.ShowBorrowingDetails.Image = global::LMS.Properties.Resources.info;
            this.ShowBorrowingDetails.Name = "ShowBorrowingDetails";
            this.ShowBorrowingDetails.Size = new System.Drawing.Size(349, 42);
            this.ShowBorrowingDetails.Text = "&Show Borrowing Details";
            this.ShowBorrowingDetails.Click += new System.EventHandler(this.ShowBorrowingDetails_Click);
            // 
            // BorrowingBook
            // 
            this.BorrowingBook.Image = global::LMS.Properties.Resources._10_borrow_book;
            this.BorrowingBook.Name = "BorrowingBook";
            this.BorrowingBook.Size = new System.Drawing.Size(349, 42);
            this.BorrowingBook.Text = "Add Borrowing Book";
            this.BorrowingBook.Click += new System.EventHandler(this.BorrowingBook_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Image = global::LMS.Properties.Resources.return_book_png;
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(349, 42);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.search1;
            this.pictureBox1.Location = new System.Drawing.Point(552, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 267;
            this.pictureBox1.TabStop = false;
            // 
            // frmListBorrowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1402, 633);
            this.Controls.Add(this.cmbGenreBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblBooksNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvListBorrowings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListBorrowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Borrowing";
            this.Load += new System.EventHandler(this.frmListBorrowing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBorrowings)).EndInit();
            this.cnxBorrowingBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvListBorrowings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBooksNo;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaComboBox cmbGenreBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cnxBorrowingBook;
        private System.Windows.Forms.ToolStripMenuItem BorrowingBook;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowBorrowingDetails;
    }
}