namespace LMS.Fines
{
    partial class frmListManageFines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListFines = new Guna.UI.WinForms.GunaDataGridView();
            this.cnxBorrowingBook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowFineDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.PayFine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFinesNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnPayFine = new Guna.UI.WinForms.GunaButton();
            this.cmbFillter = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFines)).BeginInit();
            this.cnxBorrowingBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListFines
            // 
            this.dgvListFines.AllowUserToAddRows = false;
            this.dgvListFines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvListFines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListFines.BackgroundColor = System.Drawing.Color.White;
            this.dgvListFines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListFines.CausesValidation = false;
            this.dgvListFines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListFines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListFines.ColumnHeadersHeight = 25;
            this.dgvListFines.ContextMenuStrip = this.cnxBorrowingBook;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListFines.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListFines.EnableHeadersVisualStyles = false;
            this.dgvListFines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListFines.Location = new System.Drawing.Point(12, 277);
            this.dgvListFines.MultiSelect = false;
            this.dgvListFines.Name = "dgvListFines";
            this.dgvListFines.ReadOnly = true;
            this.dgvListFines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListFines.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListFines.RowHeadersVisible = false;
            this.dgvListFines.RowHeadersWidth = 51;
            this.dgvListFines.RowTemplate.Height = 26;
            this.dgvListFines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListFines.Size = new System.Drawing.Size(1380, 295);
            this.dgvListFines.StandardTab = true;
            this.dgvListFines.TabIndex = 277;
            this.dgvListFines.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvListFines.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListFines.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListFines.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListFines.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListFines.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListFines.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListFines.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListFines.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListFines.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvListFines.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListFines.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListFines.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListFines.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvListFines.ThemeStyle.ReadOnly = true;
            this.dgvListFines.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListFines.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListFines.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListFines.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListFines.ThemeStyle.RowsStyle.Height = 26;
            this.dgvListFines.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListFines.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cnxBorrowingBook
            // 
            this.cnxBorrowingBook.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnxBorrowingBook.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.cnxBorrowingBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowFineDetails,
            this.PayFine,
            this.ToolStripMenuItem});
            this.cnxBorrowingBook.Name = "contextMenuStrip1";
            this.cnxBorrowingBook.Size = new System.Drawing.Size(287, 130);
            this.cnxBorrowingBook.Text = "contextMenuStrip1";
            // 
            // ShowFineDetails
            // 
            this.ShowFineDetails.Image = global::LMS.Properties.Resources.info;
            this.ShowFineDetails.Name = "ShowFineDetails";
            this.ShowFineDetails.Size = new System.Drawing.Size(286, 42);
            this.ShowFineDetails.Text = "&Show Fine Details";
            // 
            // PayFine
            // 
            this.PayFine.Image = global::LMS.Properties.Resources._10_borrow_book;
            this.PayFine.Name = "PayFine";
            this.PayFine.Size = new System.Drawing.Size(286, 42);
            this.PayFine.Text = "Pay Fine";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Image = global::LMS.Properties.Resources.return_book_png;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(286, 42);
            this.ToolStripMenuItem.Text = "Anything";
            // 
            // lblFinesNo
            // 
            this.lblFinesNo.AutoSize = true;
            this.lblFinesNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinesNo.Location = new System.Drawing.Point(125, 590);
            this.lblFinesNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinesNo.Name = "lblFinesNo";
            this.lblFinesNo.Size = new System.Drawing.Size(48, 25);
            this.lblFinesNo.TabIndex = 281;
            this.lblFinesNo.Text = "###";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 589);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 280;
            this.label4.Text = "Fines No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(584, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 279;
            this.label1.Text = "Manage Fines";
            // 
            // btnPayFine
            // 
            this.btnPayFine.AnimationHoverSpeed = 0.07F;
            this.btnPayFine.AnimationSpeed = 0.03F;
            this.btnPayFine.BackColor = System.Drawing.Color.Transparent;
            this.btnPayFine.BaseColor = System.Drawing.Color.White;
            this.btnPayFine.BorderColor = System.Drawing.Color.Maroon;
            this.btnPayFine.BorderSize = 1;
            this.btnPayFine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPayFine.FocusedColor = System.Drawing.Color.Empty;
            this.btnPayFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFine.ForeColor = System.Drawing.Color.Black;
            this.btnPayFine.Image = global::LMS.Properties.Resources.money_32___2;
            this.btnPayFine.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPayFine.ImageSize = new System.Drawing.Size(45, 45);
            this.btnPayFine.Location = new System.Drawing.Point(1305, 199);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnPayFine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPayFine.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPayFine.OnHoverImage = null;
            this.btnPayFine.OnPressedColor = System.Drawing.Color.Black;
            this.btnPayFine.Radius = 10;
            this.btnPayFine.Size = new System.Drawing.Size(87, 72);
            this.btnPayFine.TabIndex = 283;
            this.toolTip1.SetToolTip(this.btnPayFine, "Pay Fine");
            // 
            // cmbFillter
            // 
            this.cmbFillter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFillter.BaseColor = System.Drawing.Color.White;
            this.cmbFillter.BorderColor = System.Drawing.Color.Lime;
            this.cmbFillter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFillter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFillter.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFillter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFillter.ForeColor = System.Drawing.Color.Black;
            this.cmbFillter.FormattingEnabled = true;
            this.cmbFillter.Items.AddRange(new object[] {
            "All",
            "Payed",
            "Non pay"});
            this.cmbFillter.Location = new System.Drawing.Point(130, 238);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFillter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFillter.Radius = 15;
            this.cmbFillter.Size = new System.Drawing.Size(263, 31);
            this.cmbFillter.StartIndex = 0;
            this.cmbFillter.TabIndex = 285;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 284;
            this.label2.Text = "Fillter By  :";
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.SystemColors.Desktop;
            this.btnClose.BorderSize = 2;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::LMS.Properties.Resources.Close_64;
            this.btnClose.ImageSize = new System.Drawing.Size(23, 23);
            this.btnClose.Location = new System.Drawing.Point(1266, 580);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.TabIndex = 282;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.fine1;
            this.pictureBox1.Location = new System.Drawing.Point(554, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 278;
            this.pictureBox1.TabStop = false;
            // 
            // frmListManageFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1402, 633);
            this.Controls.Add(this.dgvListFines);
            this.Controls.Add(this.lblFinesNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFillter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPayFine);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListManageFines";
            this.Text = "Manage Fines";
            this.Load += new System.EventHandler(this.frmListManageFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFines)).EndInit();
            this.cnxBorrowingBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvListFines;
        private System.Windows.Forms.ContextMenuStrip cnxBorrowingBook;
        private System.Windows.Forms.ToolStripMenuItem ShowFineDetails;
        private System.Windows.Forms.ToolStripMenuItem PayFine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Label lblFinesNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaButton btnPayFine;
        private Guna.UI.WinForms.GunaComboBox cmbFillter;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}