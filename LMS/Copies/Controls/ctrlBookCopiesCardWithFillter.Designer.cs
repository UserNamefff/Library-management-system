namespace LMS.Copies.Controls
{
    partial class ctrlBookCopiesCardWithFillter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.txtFilterValue = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddNewBookCopy = new Guna.UI.WinForms.GunaButton();
            this.btnFind = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBookCopyInfo1 = new LMS.Copies.Controls.ctrlBookCopyInfo();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.txtFilterValue);
            this.gbFilters.Controls.Add(this.btnAddNewBookCopy);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(14, 4);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(948, 84);
            this.gbFilters.TabIndex = 19;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BaseColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderColor = System.Drawing.Color.SpringGreen;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilterValue.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFilterValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterValue.Location = new System.Drawing.Point(116, 24);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.Radius = 20;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(485, 45);
            this.txtFilterValue.TabIndex = 21;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnAddNewBookCopy
            // 
            this.btnAddNewBookCopy.AnimationHoverSpeed = 0.07F;
            this.btnAddNewBookCopy.AnimationSpeed = 0.03F;
            this.btnAddNewBookCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewBookCopy.BaseColor = System.Drawing.Color.White;
            this.btnAddNewBookCopy.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewBookCopy.BorderSize = 1;
            this.btnAddNewBookCopy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewBookCopy.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewBookCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBookCopy.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewBookCopy.Image = global::LMS.Properties.Resources.New_book;
            this.btnAddNewBookCopy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewBookCopy.ImageSize = new System.Drawing.Size(33, 33);
            this.btnAddNewBookCopy.Location = new System.Drawing.Point(688, 23);
            this.btnAddNewBookCopy.Name = "btnAddNewBookCopy";
            this.btnAddNewBookCopy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddNewBookCopy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewBookCopy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewBookCopy.OnHoverImage = null;
            this.btnAddNewBookCopy.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewBookCopy.Radius = 10;
            this.btnAddNewBookCopy.Size = new System.Drawing.Size(62, 49);
            this.btnAddNewBookCopy.TabIndex = 258;
            // 
            // btnFind
            // 
            this.btnFind.AnimationHoverSpeed = 0.07F;
            this.btnFind.AnimationSpeed = 0.03F;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BaseColor = System.Drawing.Color.White;
            this.btnFind.BorderColor = System.Drawing.Color.Black;
            this.btnFind.BorderSize = 1;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.FocusedColor = System.Drawing.Color.Empty;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Image = global::LMS.Properties.Resources.search;
            this.btnFind.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFind.ImageSize = new System.Drawing.Size(33, 33);
            this.btnFind.Location = new System.Drawing.Point(620, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Radius = 10;
            this.btnFind.Size = new System.Drawing.Size(62, 49);
            this.btnFind.TabIndex = 0;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Copy ID :";
            // 
            // ctrlBookCopyInfo1
            // 
            this.ctrlBookCopyInfo1.Location = new System.Drawing.Point(14, 84);
            this.ctrlBookCopyInfo1.Name = "ctrlBookCopyInfo1";
            this.ctrlBookCopyInfo1.Size = new System.Drawing.Size(963, 532);
            this.ctrlBookCopyInfo1.TabIndex = 0;
            this.ctrlBookCopyInfo1.dlgCopyID += new System.Action<int>(this.ctrlBookCopyInfo1_dlgCopyID);
            // 
            // ctrlBookCopiesCardWithFillter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.ctrlBookCopyInfo1);
            this.Name = "ctrlBookCopiesCardWithFillter";
            this.Size = new System.Drawing.Size(982, 645);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlBookCopyInfo ctrlBookCopyInfo1;
        private System.Windows.Forms.GroupBox gbFilters;
        private Guna.UI.WinForms.GunaTextBox txtFilterValue;
        private Guna.UI.WinForms.GunaButton btnAddNewBookCopy;
        private Guna.UI.WinForms.GunaButton btnFind;
        private System.Windows.Forms.Label label1;
    }
}
