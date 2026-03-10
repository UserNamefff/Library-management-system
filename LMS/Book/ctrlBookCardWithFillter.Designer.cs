namespace LMS.Book
{
    partial class ctrlBookCardWithFillter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.cbFilterBy = new Guna.UI.WinForms.GunaComboBox();
            this.txtFilterValue = new Guna.UI.WinForms.GunaTextBox();
            this.btnAddNewBook = new Guna.UI.WinForms.GunaButton();
            this.btnFind = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlBookDetails1 = new LMS.Book.ctrlBookDetails();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.cbFilterBy);
            this.gbFilters.Controls.Add(this.txtFilterValue);
            this.gbFilters.Controls.Add(this.btnAddNewBook);
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Location = new System.Drawing.Point(11, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(940, 77);
            this.gbFilters.TabIndex = 18;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filter";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.BaseColor = System.Drawing.Color.White;
            this.cbFilterBy.BorderColor = System.Drawing.Color.Silver;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.Black;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Book ID",
            "ISBN",
            "Book Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(97, 21);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbFilterBy.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbFilterBy.Radius = 10;
            this.cbFilterBy.Size = new System.Drawing.Size(236, 31);
            this.cbFilterBy.TabIndex = 20;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BackColor = System.Drawing.Color.Transparent;
            this.txtFilterValue.BaseColor = System.Drawing.Color.White;
            this.txtFilterValue.BorderColor = System.Drawing.Color.Silver;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFilterValue.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFilterValue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterValue.Location = new System.Drawing.Point(339, 19);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.Radius = 10;
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(262, 34);
            this.txtFilterValue.TabIndex = 21;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.AnimationHoverSpeed = 0.07F;
            this.btnAddNewBook.AnimationSpeed = 0.03F;
            this.btnAddNewBook.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewBook.BaseColor = System.Drawing.Color.White;
            this.btnAddNewBook.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewBook.BorderSize = 1;
            this.btnAddNewBook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewBook.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewBook.Image = global::LMS.Properties.Resources.book;
            this.btnAddNewBook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNewBook.ImageSize = new System.Drawing.Size(33, 33);
            this.btnAddNewBook.Location = new System.Drawing.Point(688, 15);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAddNewBook.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewBook.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.OnHoverImage = null;
            this.btnAddNewBook.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewBook.Radius = 10;
            this.btnAddNewBook.Size = new System.Drawing.Size(62, 49);
            this.btnAddNewBook.TabIndex = 258;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
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
            this.btnFind.Location = new System.Drawing.Point(620, 15);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Radius = 10;
            this.btnFind.Size = new System.Drawing.Size(62, 49);
            this.btnFind.TabIndex = 259;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Find By:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlBookDetails1
            // 
            this.ctrlBookDetails1.Location = new System.Drawing.Point(4, 83);
            this.ctrlBookDetails1.Name = "ctrlBookDetails1";
            this.ctrlBookDetails1.Size = new System.Drawing.Size(953, 342);
            this.ctrlBookDetails1.TabIndex = 19;
            this.ctrlBookDetails1.Load += new System.EventHandler(this.ctrlBookDetails1_Load);
            // 
            // ctrlBookCardWithFillter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlBookDetails1);
            this.Controls.Add(this.gbFilters);
            this.Name = "ctrlBookCardWithFillter";
            this.Size = new System.Drawing.Size(963, 424);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtFilterValue;
        private Guna.UI.WinForms.GunaButton btnAddNewBook;
        private Guna.UI.WinForms.GunaButton btnFind;
        private ctrlBookDetails ctrlBookDetails1;
        private Guna.UI.WinForms.GunaComboBox cbFilterBy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
