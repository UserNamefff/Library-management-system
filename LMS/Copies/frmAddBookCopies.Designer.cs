namespace LMS.Copies
{
    partial class frmAddBookCopies
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberOfCopies = new Guna.UI.WinForms.GunaNumeric();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpAddingDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndexOfCopy = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.ctrlBookCardWithFillter1 = new LMS.Book.ctrlBookCardWithFillter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 25);
            this.label7.TabIndex = 189;
            this.label7.Text = "Number Book Copies :";
            // 
            // txtNumberOfCopies
            // 
            this.txtNumberOfCopies.BackColor = System.Drawing.Color.Transparent;
            this.txtNumberOfCopies.BaseColor = System.Drawing.Color.White;
            this.txtNumberOfCopies.BorderColor = System.Drawing.Color.Silver;
            this.txtNumberOfCopies.BorderSize = 2;
            this.txtNumberOfCopies.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNumberOfCopies.ButtonForeColor = System.Drawing.Color.White;
            this.txtNumberOfCopies.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumberOfCopies.ForeColor = System.Drawing.Color.Black;
            this.txtNumberOfCopies.Location = new System.Drawing.Point(284, 44);
            this.txtNumberOfCopies.Maximum = ((long)(9999999));
            this.txtNumberOfCopies.Minimum = ((long)(0));
            this.txtNumberOfCopies.Name = "txtNumberOfCopies";
            this.txtNumberOfCopies.Radius = 10;
            this.txtNumberOfCopies.Size = new System.Drawing.Size(299, 30);
            this.txtNumberOfCopies.TabIndex = 201;
            this.txtNumberOfCopies.Text = "gunaNumeric1";
            this.txtNumberOfCopies.Value = ((long)(1));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAddingDate);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIndexOfCopy);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumberOfCopies);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 177);
            this.groupBox1.TabIndex = 203;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Copies Info";
            // 
            // dtpAddingDate
            // 
            this.dtpAddingDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpAddingDate.BaseColor = System.Drawing.Color.White;
            this.dtpAddingDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtpAddingDate.CustomFormat = null;
            this.dtpAddingDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpAddingDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpAddingDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAddingDate.ForeColor = System.Drawing.Color.Black;
            this.dtpAddingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddingDate.Location = new System.Drawing.Point(796, 34);
            this.dtpAddingDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAddingDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAddingDate.Name = "dtpAddingDate";
            this.dtpAddingDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpAddingDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpAddingDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpAddingDate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpAddingDate.Radius = 15;
            this.dtpAddingDate.Size = new System.Drawing.Size(143, 39);
            this.dtpAddingDate.TabIndex = 211;
            this.dtpAddingDate.Text = "2/28/2026";
            this.dtpAddingDate.Value = new System.DateTime(2026, 2, 28, 2, 25, 48, 828);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 209;
            this.label4.Text = "Adding Date :";
            // 
            // txtIndexOfCopy
            // 
            this.txtIndexOfCopy.Location = new System.Drawing.Point(284, 80);
            this.txtIndexOfCopy.Name = "txtIndexOfCopy";
            this.txtIndexOfCopy.Size = new System.Drawing.Size(662, 74);
            this.txtIndexOfCopy.TabIndex = 205;
            this.txtIndexOfCopy.Text = "";
            this.txtIndexOfCopy.Validating += new System.ComponentModel.CancelEventHandler(this.txtIndexOfCopy_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 203;
            this.label3.Text = "Index Of Copy :";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(-3, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(995, 44);
            this.lblTitle.TabIndex = 265;
            this.lblTitle.Text = "Add New Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::LMS.Properties.Resources.icons8_add_book_96;
            this.pictureBox1.Location = new System.Drawing.Point(435, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 264;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LMS.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(752, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 210;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LMS.Properties.Resources.Notes_32;
            this.pictureBox5.Location = new System.Drawing.Point(239, 80);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 204;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::LMS.Properties.Resources.title;
            this.pictureBox8.Location = new System.Drawing.Point(240, 43);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(39, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 191;
            this.pictureBox8.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderSize = 1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave.Image = global::LMS.Properties.Resources.icons8_add_book_48;
            this.btnSave.ImageSize = new System.Drawing.Size(27, 27);
            this.btnSave.Location = new System.Drawing.Point(872, 774);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(103, 42);
            this.btnSave.TabIndex = 198;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderSize = 1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.Image = global::LMS.Properties.Resources.CloseBlack1;
            this.btnClose.ImageSize = new System.Drawing.Size(27, 27);
            this.btnClose.Location = new System.Drawing.Point(763, 774);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(103, 42);
            this.btnClose.TabIndex = 197;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlBookCardWithFillter1
            // 
            this.ctrlBookCardWithFillter1.FilterEnabled = true;
            this.ctrlBookCardWithFillter1.Location = new System.Drawing.Point(12, 165);
            this.ctrlBookCardWithFillter1.Name = "ctrlBookCardWithFillter1";
            this.ctrlBookCardWithFillter1.ShowAddPerson = true;
            this.ctrlBookCardWithFillter1.Size = new System.Drawing.Size(963, 424);
            this.ctrlBookCardWithFillter1.TabIndex = 0;
            this.ctrlBookCardWithFillter1.OnBookSelected += new System.Action<int>(this.ctrlBookCardWithFillter1_OnBookSelected);
            // 
            // frmAddBookCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(991, 851);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlBookCardWithFillter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddBookCopies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddBookCopies";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Book.ctrlBookCardWithFillter ctrlBookCardWithFillter1;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private Guna.UI.WinForms.GunaNumeric txtNumberOfCopies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtIndexOfCopy;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDateTimePicker dtpAddingDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}