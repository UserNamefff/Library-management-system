namespace LMS.Book
{
    partial class frmFindBook
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
            this.ctrlBookCardWithFillter1 = new LMS.Book.ctrlBookCardWithFillter();
            this.SuspendLayout();
            // 
            // ctrlBookCardWithFillter1
            // 
            this.ctrlBookCardWithFillter1.FilterEnabled = true;
            this.ctrlBookCardWithFillter1.Location = new System.Drawing.Point(12, 32);
            this.ctrlBookCardWithFillter1.Name = "ctrlBookCardWithFillter1";
            this.ctrlBookCardWithFillter1.ShowAddPerson = true;
            this.ctrlBookCardWithFillter1.Size = new System.Drawing.Size(963, 424);
            this.ctrlBookCardWithFillter1.TabIndex = 0;
            // 
            // frmFindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(980, 611);
            this.Controls.Add(this.ctrlBookCardWithFillter1);
            this.Name = "frmFindBook";
            this.Text = "frmFindBook";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlBookCardWithFillter ctrlBookCardWithFillter1;
    }
}