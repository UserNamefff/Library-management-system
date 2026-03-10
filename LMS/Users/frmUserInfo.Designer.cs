namespace LMS.Users
{
    partial class frmUserInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxSubscriptions = new System.Windows.Forms.CheckBox();
            this.cbxManageCopies = new System.Windows.Forms.CheckBox();
            this.cbxManageBooks = new System.Windows.Forms.CheckBox();
            this.cbxManangeBorrowing = new System.Windows.Forms.CheckBox();
            this.cbxManageMembers = new System.Windows.Forms.CheckBox();
            this.cbxManageUsers = new System.Windows.Forms.CheckBox();
            this.cbxFullAccess = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlPersonCard11 = new LMS.People.Controls.ctrlPersonCard1();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(857, 40);
            this.lblIsActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(48, 25);
            this.lblIsActive.TabIndex = 140;
            this.lblIsActive.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 139;
            this.label2.Text = "Is Active : ";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(560, 40);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(48, 25);
            this.lblUserName.TabIndex = 138;
            this.lblUserName.Text = "???";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(225, 40);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 25);
            this.lblUserID.TabIndex = 137;
            this.lblUserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 136;
            this.label4.Text = "User ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 130;
            this.label1.Text = "Username:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Image = global::LMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1001, 530);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 37);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxSubscriptions);
            this.groupBox2.Controls.Add(this.cbxManageCopies);
            this.groupBox2.Controls.Add(this.cbxManageBooks);
            this.groupBox2.Controls.Add(this.cbxManangeBorrowing);
            this.groupBox2.Controls.Add(this.cbxManageMembers);
            this.groupBox2.Controls.Add(this.cbxManageUsers);
            this.groupBox2.Controls.Add(this.cbxFullAccess);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(852, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 287);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisions";
            // 
            // cbxSubscriptions
            // 
            this.cbxSubscriptions.AutoSize = true;
            this.cbxSubscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxSubscriptions.Location = new System.Drawing.Point(26, 244);
            this.cbxSubscriptions.Name = "cbxSubscriptions";
            this.cbxSubscriptions.Size = new System.Drawing.Size(229, 29);
            this.cbxSubscriptions.TabIndex = 6;
            this.cbxSubscriptions.Tag = "32";
            this.cbxSubscriptions.Text = "Manage Subscriptions";
            this.cbxSubscriptions.UseVisualStyleBackColor = true;
            // 
            // cbxManageCopies
            // 
            this.cbxManageCopies.AutoSize = true;
            this.cbxManageCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManageCopies.Location = new System.Drawing.Point(26, 209);
            this.cbxManageCopies.Name = "cbxManageCopies";
            this.cbxManageCopies.Size = new System.Drawing.Size(168, 29);
            this.cbxManageCopies.TabIndex = 5;
            this.cbxManageCopies.Tag = "16";
            this.cbxManageCopies.Text = "Manage copies";
            this.cbxManageCopies.UseVisualStyleBackColor = true;
            // 
            // cbxManageBooks
            // 
            this.cbxManageBooks.AutoSize = true;
            this.cbxManageBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManageBooks.Location = new System.Drawing.Point(26, 178);
            this.cbxManageBooks.Name = "cbxManageBooks";
            this.cbxManageBooks.Size = new System.Drawing.Size(166, 29);
            this.cbxManageBooks.TabIndex = 4;
            this.cbxManageBooks.Tag = "8";
            this.cbxManageBooks.Text = "Manage Books";
            this.cbxManageBooks.UseVisualStyleBackColor = true;
            // 
            // cbxManangeBorrowing
            // 
            this.cbxManangeBorrowing.AutoSize = true;
            this.cbxManangeBorrowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManangeBorrowing.Location = new System.Drawing.Point(26, 143);
            this.cbxManangeBorrowing.Name = "cbxManangeBorrowing";
            this.cbxManangeBorrowing.Size = new System.Drawing.Size(209, 29);
            this.cbxManangeBorrowing.TabIndex = 3;
            this.cbxManangeBorrowing.Tag = "2";
            this.cbxManangeBorrowing.Text = "Manange Borrowing";
            this.cbxManangeBorrowing.UseVisualStyleBackColor = true;
            // 
            // cbxManageMembers
            // 
            this.cbxManageMembers.AutoSize = true;
            this.cbxManageMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManageMembers.Location = new System.Drawing.Point(26, 105);
            this.cbxManageMembers.Name = "cbxManageMembers";
            this.cbxManageMembers.Size = new System.Drawing.Size(193, 29);
            this.cbxManageMembers.TabIndex = 2;
            this.cbxManageMembers.Tag = "4";
            this.cbxManageMembers.Text = "Manage Members";
            this.cbxManageMembers.UseVisualStyleBackColor = true;
            // 
            // cbxManageUsers
            // 
            this.cbxManageUsers.AutoSize = true;
            this.cbxManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxManageUsers.Location = new System.Drawing.Point(26, 67);
            this.cbxManageUsers.Name = "cbxManageUsers";
            this.cbxManageUsers.Size = new System.Drawing.Size(162, 29);
            this.cbxManageUsers.TabIndex = 1;
            this.cbxManageUsers.Tag = "1";
            this.cbxManageUsers.Text = "Manage Users";
            this.cbxManageUsers.UseVisualStyleBackColor = true;
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
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1129, 47);
            this.lblTitle.TabIndex = 148;
            this.lblTitle.Text = "User Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlPersonCard11
            // 
            this.ctrlPersonCard11.Location = new System.Drawing.Point(14, 96);
            this.ctrlPersonCard11.Name = "ctrlPersonCard11";
            this.ctrlPersonCard11.Size = new System.Drawing.Size(835, 311);
            this.ctrlPersonCard11.TabIndex = 147;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 585);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlPersonCard11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUserInfo";
            this.Load += new System.EventHandler(this.frmUserInfo_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxSubscriptions;
        private System.Windows.Forms.CheckBox cbxManageCopies;
        private System.Windows.Forms.CheckBox cbxManageBooks;
        private System.Windows.Forms.CheckBox cbxManangeBorrowing;
        private System.Windows.Forms.CheckBox cbxManageMembers;
        private System.Windows.Forms.CheckBox cbxManageUsers;
        private System.Windows.Forms.CheckBox cbxFullAccess;
        private People.Controls.ctrlPersonCard1 ctrlPersonCard11;
        private System.Windows.Forms.Label lblTitle;
    }
}