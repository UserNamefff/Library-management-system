namespace LMS.Users
{
    partial class frmAddUpdateUser
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxIsActive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxFullAccess = new System.Windows.Forms.CheckBox();
            this.cbxManageUsers = new System.Windows.Forms.CheckBox();
            this.cbxManageMembers = new System.Windows.Forms.CheckBox();
            this.cbxManangeBorrowing = new System.Windows.Forms.CheckBox();
            this.cbxManageBooks = new System.Windows.Forms.CheckBox();
            this.cbxManageCopies = new System.Windows.Forms.CheckBox();
            this.cbxSubscriptions = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEditePersonalUserInfo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlPersonCardWithFillter11 = new LMS.People.Controls.ctrlPersonCardWithFillter1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblUserID.Location = new System.Drawing.Point(206, 83);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(68, 25);
            this.lblUserID.TabIndex = 149;
            this.lblUserID.Text = "[????]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 147;
            this.label1.Text = "User Name";
            // 
            // cbxIsActive
            // 
            this.cbxIsActive.AutoSize = true;
            this.cbxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxIsActive.Location = new System.Drawing.Point(244, 217);
            this.cbxIsActive.Name = "cbxIsActive";
            this.cbxIsActive.Size = new System.Drawing.Size(108, 29);
            this.cbxIsActive.TabIndex = 7;
            this.cbxIsActive.Text = "Is Active";
            this.cbxIsActive.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 141;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 140;
            this.label7.Text = "User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 173);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 24);
            this.txtPassword.TabIndex = 136;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(206, 129);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(232, 24);
            this.txtUserName.TabIndex = 135;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateUserNameIfExist);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(889, 47);
            this.lblTitle.TabIndex = 116;
            this.lblTitle.Text = "Add New User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbxFullAccess
            // 
            this.cbxFullAccess.AutoSize = true;
            this.cbxFullAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxFullAccess.Location = new System.Drawing.Point(26, 34);
            this.cbxFullAccess.Name = "cbxFullAccess";
            this.cbxFullAccess.Size = new System.Drawing.Size(135, 29);
            this.cbxFullAccess.TabIndex = 0;
            this.cbxFullAccess.Tag = "63";
            this.cbxFullAccess.Text = "Full Access";
            this.cbxFullAccess.UseVisualStyleBackColor = true;
            this.cbxFullAccess.CheckedChanged += new System.EventHandler(this.cbxFullAccess_CheckedChanged);
            // 
            // cbxManageUsers
            // 
            this.cbxManageUsers.AutoSize = true;
            this.cbxManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManageUsers.Location = new System.Drawing.Point(26, 75);
            this.cbxManageUsers.Name = "cbxManageUsers";
            this.cbxManageUsers.Size = new System.Drawing.Size(162, 29);
            this.cbxManageUsers.TabIndex = 1;
            this.cbxManageUsers.Tag = "1";
            this.cbxManageUsers.Text = "Manage Users";
            this.cbxManageUsers.UseVisualStyleBackColor = true;
            this.cbxManageUsers.CheckedChanged += new System.EventHandler(this.AddPermitions);
            // 
            // cbxManageMembers
            // 
            this.cbxManageMembers.AutoSize = true;
            this.cbxManageMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManageMembers.Location = new System.Drawing.Point(26, 113);
            this.cbxManageMembers.Name = "cbxManageMembers";
            this.cbxManageMembers.Size = new System.Drawing.Size(193, 29);
            this.cbxManageMembers.TabIndex = 2;
            this.cbxManageMembers.Tag = "4";
            this.cbxManageMembers.Text = "Manage Members";
            this.cbxManageMembers.UseVisualStyleBackColor = true;
            this.cbxManageMembers.CheckedChanged += new System.EventHandler(this.AddPermitions);
            // 
            // cbxManangeBorrowing
            // 
            this.cbxManangeBorrowing.AutoSize = true;
            this.cbxManangeBorrowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManangeBorrowing.Location = new System.Drawing.Point(26, 151);
            this.cbxManangeBorrowing.Name = "cbxManangeBorrowing";
            this.cbxManangeBorrowing.Size = new System.Drawing.Size(209, 29);
            this.cbxManangeBorrowing.TabIndex = 3;
            this.cbxManangeBorrowing.Tag = "2";
            this.cbxManangeBorrowing.Text = "Manange Borrowing";
            this.cbxManangeBorrowing.UseVisualStyleBackColor = true;
            this.cbxManangeBorrowing.CheckedChanged += new System.EventHandler(this.AddPermitions);
            // 
            // cbxManageBooks
            // 
            this.cbxManageBooks.AutoSize = true;
            this.cbxManageBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManageBooks.Location = new System.Drawing.Point(26, 186);
            this.cbxManageBooks.Name = "cbxManageBooks";
            this.cbxManageBooks.Size = new System.Drawing.Size(166, 29);
            this.cbxManageBooks.TabIndex = 4;
            this.cbxManageBooks.Tag = "8";
            this.cbxManageBooks.Text = "Manage Books";
            this.cbxManageBooks.UseVisualStyleBackColor = true;
            this.cbxManageBooks.CheckedChanged += new System.EventHandler(this.AddPermitions);
            // 
            // cbxManageCopies
            // 
            this.cbxManageCopies.AutoSize = true;
            this.cbxManageCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManageCopies.Location = new System.Drawing.Point(26, 217);
            this.cbxManageCopies.Name = "cbxManageCopies";
            this.cbxManageCopies.Size = new System.Drawing.Size(168, 29);
            this.cbxManageCopies.TabIndex = 5;
            this.cbxManageCopies.Tag = "16";
            this.cbxManageCopies.Text = "Manage copies";
            this.cbxManageCopies.UseVisualStyleBackColor = true;
            this.cbxManageCopies.CheckedChanged += new System.EventHandler(this.AddPermitions);
            // 
            // cbxSubscriptions
            // 
            this.cbxSubscriptions.AutoSize = true;
            this.cbxSubscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSubscriptions.Location = new System.Drawing.Point(26, 252);
            this.cbxSubscriptions.Name = "cbxSubscriptions";
            this.cbxSubscriptions.Size = new System.Drawing.Size(229, 29);
            this.cbxSubscriptions.TabIndex = 6;
            this.cbxSubscriptions.Tag = "32";
            this.cbxSubscriptions.Text = "Manage Subscriptions";
            this.cbxSubscriptions.UseVisualStyleBackColor = true;
            this.cbxSubscriptions.CheckedChanged += new System.EventHandler(this.AddPermitions);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSubscriptions);
            this.groupBox1.Controls.Add(this.cbxManageCopies);
            this.groupBox1.Controls.Add(this.cbxManageBooks);
            this.groupBox1.Controls.Add(this.cbxManangeBorrowing);
            this.groupBox1.Controls.Add(this.cbxManageMembers);
            this.groupBox1.Controls.Add(this.cbxManageUsers);
            this.groupBox1.Controls.Add(this.cbxFullAccess);
            this.groupBox1.Location = new System.Drawing.Point(526, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 297);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisions";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblUserID);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.cbxIsActive);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(35, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 333);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Info";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LMS.Properties.Resources.Person_32;
            this.pictureBox2.Location = new System.Drawing.Point(171, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 148;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::LMS.Properties.Resources.Person_32;
            this.pictureBox8.Location = new System.Drawing.Point(171, 126);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 144;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(171, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = global::LMS.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(743, 784);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 42);
            this.btnSave.TabIndex = 117;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEditePersonalUserInfo
            // 
            this.btnEditePersonalUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditePersonalUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditePersonalUserInfo.Image = global::LMS.Properties.Resources.Edit;
            this.btnEditePersonalUserInfo.Location = new System.Drawing.Point(674, 81);
            this.btnEditePersonalUserInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditePersonalUserInfo.Name = "btnEditePersonalUserInfo";
            this.btnEditePersonalUserInfo.Size = new System.Drawing.Size(45, 42);
            this.btnEditePersonalUserInfo.TabIndex = 152;
            this.btnEditePersonalUserInfo.UseVisualStyleBackColor = true;
            this.btnEditePersonalUserInfo.Visible = false;
            this.btnEditePersonalUserInfo.Click += new System.EventHandler(this.btnEditePersonalUserInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Image = global::LMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(624, 784);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 42);
            this.btnClose.TabIndex = 118;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPersonCardWithFillter11
            // 
            this.ctrlPersonCardWithFillter11.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFillter11.FilterEnabled = true;
            this.ctrlPersonCardWithFillter11.Location = new System.Drawing.Point(27, 60);
            this.ctrlPersonCardWithFillter11.Name = "ctrlPersonCardWithFillter11";
            this.ctrlPersonCardWithFillter11.ShowAddPerson = true;
            this.ctrlPersonCardWithFillter11.Size = new System.Drawing.Size(836, 382);
            this.ctrlPersonCardWithFillter11.TabIndex = 151;
            this.ctrlPersonCardWithFillter11.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFillter11_OnPersonSelected_1);
            // 
            // frmAddUpdateUser
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 843);
            this.Controls.Add(this.btnEditePersonalUserInfo);
            this.Controls.Add(this.ctrlPersonCardWithFillter11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Update User";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbxIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxSubscriptions;
        private System.Windows.Forms.CheckBox cbxManageCopies;
        private System.Windows.Forms.CheckBox cbxManageBooks;
        private System.Windows.Forms.CheckBox cbxManangeBorrowing;
        private System.Windows.Forms.CheckBox cbxManageMembers;
        private System.Windows.Forms.CheckBox cbxManageUsers;
        private System.Windows.Forms.CheckBox cbxFullAccess;
        private People.Controls.ctrlPersonCardWithFillter1 ctrlPersonCardWithFillter11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditePersonalUserInfo;
    }
}