namespace LMS.Copies
{
    partial class frmShowBookCopyDetails
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
            this.ctrlBookCopyInfo1 = new LMS.Copies.Controls.ctrlBookCopyInfo();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // ctrlBookCopyInfo1
            // 
            this.ctrlBookCopyInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrlBookCopyInfo1.Name = "ctrlBookCopyInfo1";
            this.ctrlBookCopyInfo1.Size = new System.Drawing.Size(963, 529);
            this.ctrlBookCopyInfo1.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(853, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(103, 42);
            this.btnClose.TabIndex = 198;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowBookCopyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 589);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlBookCopyInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowBookCopyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Book Copy Details";
            this.Load += new System.EventHandler(this.frmShowBookCopyDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlBookCopyInfo ctrlBookCopyInfo1;
        private Guna.UI.WinForms.GunaButton btnClose;
    }
}