namespace LMS.Members
{
    partial class frmListMembers
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
            this.dgvListMembers = new Guna.UI.WinForms.GunaDataGridView();
            this.cnxBorrowingBook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblReservationsNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbFillter = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowFineDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.PayFine = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddReservations = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMembers)).BeginInit();
            this.cnxBorrowingBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListMembers
            // 
            this.dgvListMembers.AllowUserToAddRows = false;
            this.dgvListMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvListMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListMembers.CausesValidation = false;
            this.dgvListMembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListMembers.ColumnHeadersHeight = 25;
            this.dgvListMembers.ContextMenuStrip = this.cnxBorrowingBook;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListMembers.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListMembers.EnableHeadersVisualStyles = false;
            this.dgvListMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListMembers.Location = new System.Drawing.Point(25, 326);
            this.dgvListMembers.MultiSelect = false;
            this.dgvListMembers.Name = "dgvListMembers";
            this.dgvListMembers.ReadOnly = true;
            this.dgvListMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListMembers.RowHeadersVisible = false;
            this.dgvListMembers.RowHeadersWidth = 51;
            this.dgvListMembers.RowTemplate.Height = 26;
            this.dgvListMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListMembers.Size = new System.Drawing.Size(1380, 295);
            this.dgvListMembers.StandardTab = true;
            this.dgvListMembers.TabIndex = 295;
            this.dgvListMembers.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightGrid;
            this.dgvListMembers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListMembers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListMembers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListMembers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListMembers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListMembers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListMembers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListMembers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvListMembers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvListMembers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListMembers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListMembers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListMembers.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvListMembers.ThemeStyle.ReadOnly = true;
            this.dgvListMembers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvListMembers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListMembers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListMembers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListMembers.ThemeStyle.RowsStyle.Height = 26;
            this.dgvListMembers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvListMembers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.cnxBorrowingBook.Size = new System.Drawing.Size(332, 130);
            this.cnxBorrowingBook.Text = "contextMenuStrip1";
            // 
            // lblReservationsNo
            // 
            this.lblReservationsNo.AutoSize = true;
            this.lblReservationsNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationsNo.Location = new System.Drawing.Point(159, 639);
            this.lblReservationsNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationsNo.Name = "lblReservationsNo";
            this.lblReservationsNo.Size = new System.Drawing.Size(48, 25);
            this.lblReservationsNo.TabIndex = 299;
            this.lblReservationsNo.Text = "###";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 638);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 298;
            this.label4.Text = "Member No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(568, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 36);
            this.label1.TabIndex = 297;
            this.label1.Text = "Manage Members";
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
            "Active",
            "Non Active"});
            this.cmbFillter.Location = new System.Drawing.Point(143, 287);
            this.cmbFillter.Name = "cmbFillter";
            this.cmbFillter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbFillter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbFillter.Radius = 15;
            this.cmbFillter.Size = new System.Drawing.Size(263, 31);
            this.cmbFillter.StartIndex = 0;
            this.cmbFillter.TabIndex = 303;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 302;
            this.label2.Text = "Fillter By  :";
            // 
            // ShowFineDetails
            // 
            this.ShowFineDetails.Image = global::LMS.Properties.Resources.info;
            this.ShowFineDetails.Name = "ShowFineDetails";
            this.ShowFineDetails.Size = new System.Drawing.Size(331, 42);
            this.ShowFineDetails.Text = "&Show Member Details";
            this.ShowFineDetails.Click += new System.EventHandler(this.ShowFineDetails_Click);
            // 
            // PayFine
            // 
            this.PayFine.Image = global::LMS.Properties.Resources._10_borrow_book;
            this.PayFine.Name = "PayFine";
            this.PayFine.Size = new System.Drawing.Size(331, 42);
            this.PayFine.Text = "Update ";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Image = global::LMS.Properties.Resources.return_book_png;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(331, 42);
            this.ToolStripMenuItem.Text = "Subscription";
            // 
            // btnAddReservations
            // 
            this.btnAddReservations.AnimationHoverSpeed = 0.07F;
            this.btnAddReservations.AnimationSpeed = 0.03F;
            this.btnAddReservations.BackColor = System.Drawing.Color.Transparent;
            this.btnAddReservations.BaseColor = System.Drawing.Color.White;
            this.btnAddReservations.BorderColor = System.Drawing.Color.Maroon;
            this.btnAddReservations.BorderSize = 1;
            this.btnAddReservations.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddReservations.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservations.ForeColor = System.Drawing.Color.Black;
            this.btnAddReservations.Image = global::LMS.Properties.Resources.member_add_on_300x300;
            this.btnAddReservations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddReservations.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAddReservations.Location = new System.Drawing.Point(1318, 248);
            this.btnAddReservations.Name = "btnAddReservations";
            this.btnAddReservations.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnAddReservations.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddReservations.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddReservations.OnHoverImage = null;
            this.btnAddReservations.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddReservations.Radius = 10;
            this.btnAddReservations.Size = new System.Drawing.Size(87, 72);
            this.btnAddReservations.TabIndex = 301;
            this.toolTip1.SetToolTip(this.btnAddReservations, "Pay Fine");
            this.btnAddReservations.Click += new System.EventHandler(this.btnAddReservations_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1279, 629);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.TabIndex = 300;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.addstudent;
            this.pictureBox1.Location = new System.Drawing.Point(565, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 296;
            this.pictureBox1.TabStop = false;
            // 
            // frmListMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1429, 686);
            this.Controls.Add(this.dgvListMembers);
            this.Controls.Add(this.lblReservationsNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFillter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddReservations);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListMembers";
            this.Load += new System.EventHandler(this.frmListMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMembers)).EndInit();
            this.cnxBorrowingBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvListMembers;
        private System.Windows.Forms.ContextMenuStrip cnxBorrowingBook;
        private System.Windows.Forms.ToolStripMenuItem ShowFineDetails;
        private System.Windows.Forms.ToolStripMenuItem PayFine;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Label lblReservationsNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI.WinForms.GunaButton btnAddReservations;
        private Guna.UI.WinForms.GunaComboBox cmbFillter;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}