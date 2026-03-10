namespace LMS.Reservation
{
    partial class frmReservationBook
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
            this.ddd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNext = new Guna.UI.WinForms.GunaButton();
            this.ctrlMemberInfoWithFillter1 = new LMS.Members.ctrlMemberInfoWithFillter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctrlBookCardWithFillter1 = new LMS.Book.ctrlBookCardWithFillter();
            this.btnReservation = new Guna.UI.WinForms.GunaButton();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ddd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ddd
            // 
            this.ddd.Controls.Add(this.tabPage1);
            this.ddd.Controls.Add(this.tabPage2);
            this.ddd.Location = new System.Drawing.Point(25, 177);
            this.ddd.Name = "ddd";
            this.ddd.SelectedIndex = 0;
            this.ddd.Size = new System.Drawing.Size(1030, 629);
            this.ddd.TabIndex = 273;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.ctrlMemberInfoWithFillter1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select Member";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.btnNext.Location = new System.Drawing.Point(908, 548);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNext.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNext.OnHoverImage = null;
            this.btnNext.OnPressedColor = System.Drawing.Color.Black;
            this.btnNext.Radius = 10;
            this.btnNext.Size = new System.Drawing.Size(98, 42);
            this.btnNext.TabIndex = 279;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlMemberInfoWithFillter1
            // 
            this.ctrlMemberInfoWithFillter1.Location = new System.Drawing.Point(90, 24);
            this.ctrlMemberInfoWithFillter1.Name = "ctrlMemberInfoWithFillter1";
            this.ctrlMemberInfoWithFillter1.Size = new System.Drawing.Size(842, 526);
            this.ctrlMemberInfoWithFillter1.TabIndex = 0;
            this.ctrlMemberInfoWithFillter1.dlGetMemberID += new System.Action<int>(this.ctrlMemberInfoWithFillter1_dlGetMemberID);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctrlBookCardWithFillter1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Select Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctrlBookCardWithFillter1
            // 
            this.ctrlBookCardWithFillter1.FilterEnabled = true;
            this.ctrlBookCardWithFillter1.Location = new System.Drawing.Point(30, 42);
            this.ctrlBookCardWithFillter1.Name = "ctrlBookCardWithFillter1";
            this.ctrlBookCardWithFillter1.ShowAddPerson = true;
            this.ctrlBookCardWithFillter1.Size = new System.Drawing.Size(963, 424);
            this.ctrlBookCardWithFillter1.TabIndex = 0;
            this.ctrlBookCardWithFillter1.OnBookSelected += new System.Action<int>(this.ctrlBookCardWithFillter1_OnBookSelected);
            // 
            // btnReservation
            // 
            this.btnReservation.AnimationHoverSpeed = 0.07F;
            this.btnReservation.AnimationSpeed = 0.03F;
            this.btnReservation.BackColor = System.Drawing.Color.Transparent;
            this.btnReservation.BaseColor = System.Drawing.Color.Ivory;
            this.btnReservation.BorderColor = System.Drawing.Color.Black;
            this.btnReservation.BorderSize = 1;
            this.btnReservation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReservation.FocusedColor = System.Drawing.Color.Empty;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReservation.Image = global::LMS.Properties.Resources.icons8_add_book_48;
            this.btnReservation.ImageSize = new System.Drawing.Size(27, 27);
            this.btnReservation.Location = new System.Drawing.Point(900, 821);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReservation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReservation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReservation.OnHoverImage = null;
            this.btnReservation.OnPressedColor = System.Drawing.Color.Black;
            this.btnReservation.Radius = 10;
            this.btnReservation.Size = new System.Drawing.Size(155, 42);
            this.btnReservation.TabIndex = 277;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
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
            this.btnClose.Location = new System.Drawing.Point(769, 821);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(125, 42);
            this.btnClose.TabIndex = 276;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(409, 136);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 32);
            this.lblTitle.TabIndex = 275;
            this.lblTitle.Text = "Reservation Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.reservation;
            this.pictureBox1.Location = new System.Drawing.Point(445, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 278;
            this.pictureBox1.TabStop = false;
            // 
            // frmReservationBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1074, 882);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ddd);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReservationBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservation Book";
            this.Load += new System.EventHandler(this.frmReservationBook_Load);
            this.ddd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ddd;
        private System.Windows.Forms.TabPage tabPage1;
        private Members.ctrlMemberInfoWithFillter ctrlMemberInfoWithFillter1;
        private System.Windows.Forms.TabPage tabPage2;
        private Book.ctrlBookCardWithFillter ctrlBookCardWithFillter1;
        private Guna.UI.WinForms.GunaButton btnReservation;
        private Guna.UI.WinForms.GunaButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnNext;
    }
}