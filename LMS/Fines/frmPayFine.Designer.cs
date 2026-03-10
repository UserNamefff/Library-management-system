namespace LMS.Fines
{
    partial class frmPayFine
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.cbxPaymentStatus = new System.Windows.Forms.CheckBox();
            this.lblLateDays = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.ctrlBorrowingDetails1 = new LMS.Borrowing.Controls.ctrlBorrowingDetails();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(425, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 36);
            this.label1.TabIndex = 271;
            this.label1.Text = "Pay Fines";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.fine;
            this.pictureBox1.Location = new System.Drawing.Point(395, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 270;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.cbxPaymentStatus);
            this.groupBox1.Controls.Add(this.lblLateDays);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblFineAmount);
            this.groupBox1.Controls.Add(this.pictureBox18);
            this.groupBox1.Location = new System.Drawing.Point(29, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 188);
            this.groupBox1.TabIndex = 273;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Info";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(166, 82);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(476, 78);
            this.txtNotes.TabIndex = 288;
            this.txtNotes.Text = "";
            // 
            // cbxPaymentStatus
            // 
            this.cbxPaymentStatus.AutoSize = true;
            this.cbxPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaymentStatus.Location = new System.Drawing.Point(707, 101);
            this.cbxPaymentStatus.Name = "cbxPaymentStatus";
            this.cbxPaymentStatus.Size = new System.Drawing.Size(172, 26);
            this.cbxPaymentStatus.TabIndex = 287;
            this.cbxPaymentStatus.Text = "Payment Status";
            this.cbxPaymentStatus.UseVisualStyleBackColor = true;
            // 
            // lblLateDays
            // 
            this.lblLateDays.AutoSize = true;
            this.lblLateDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateDays.Location = new System.Drawing.Point(582, 35);
            this.lblLateDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLateDays.Name = "lblLateDays";
            this.lblLateDays.Size = new System.Drawing.Size(60, 22);
            this.lblLateDays.TabIndex = 285;
            this.lblLateDays.Text = "[????]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LMS.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(542, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 286;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 284;
            this.label4.Text = "Late Days  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 276;
            this.label2.Text = "Notes  :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LMS.Properties.Resources.Notes_32;
            this.pictureBox2.Location = new System.Drawing.Point(123, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 277;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 25);
            this.label12.TabIndex = 273;
            this.label12.Text = "Fine Amount :";
            // 
            // lblFineAmount
            // 
            this.lblFineAmount.AutoSize = true;
            this.lblFineAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineAmount.Location = new System.Drawing.Point(205, 37);
            this.lblFineAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Size = new System.Drawing.Size(60, 22);
            this.lblFineAmount.TabIndex = 275;
            this.lblFineAmount.Text = "[????]";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::LMS.Properties.Resources.money_32___2;
            this.pictureBox18.Location = new System.Drawing.Point(165, 35);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(39, 30);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 274;
            this.pictureBox18.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.SpringGreen;
            this.btnSave.BorderSize = 2;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::LMS.Properties.Resources.payment;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(850, 609);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(126, 42);
            this.btnSave.TabIndex = 274;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(718, 609);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(126, 42);
            this.btnClose.TabIndex = 275;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlBorrowingDetails1
            // 
            this.ctrlBorrowingDetails1.Location = new System.Drawing.Point(22, 117);
            this.ctrlBorrowingDetails1.Name = "ctrlBorrowingDetails1";
            this.ctrlBorrowingDetails1.Size = new System.Drawing.Size(955, 283);
            this.ctrlBorrowingDetails1.TabIndex = 272;
            // 
            // frmPayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(998, 658);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlBorrowingDetails1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPayFine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPayFine";
            this.Load += new System.EventHandler(this.frmPayFine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Borrowing.Controls.ctrlBorrowingDetails ctrlBorrowingDetails1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.Label lblLateDays;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxPaymentStatus;
        private System.Windows.Forms.RichTextBox txtNotes;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnClose;
    }
}