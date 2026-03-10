namespace LMS.Members
{
    partial class frmAddUpdateMember
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
            this.ctrlPersonCardWithFillter11 = new LMS.People.Controls.ctrlPersonCardWithFillter1();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbxIsActive = new System.Windows.Forms.CheckBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlPersonCardWithFillter11
            // 
            this.ctrlPersonCardWithFillter11.FilterEnabled = true;
            this.ctrlPersonCardWithFillter11.Location = new System.Drawing.Point(12, 225);
            this.ctrlPersonCardWithFillter11.Name = "ctrlPersonCardWithFillter11";
            this.ctrlPersonCardWithFillter11.ShowAddPerson = true;
            this.ctrlPersonCardWithFillter11.Size = new System.Drawing.Size(838, 382);
            this.ctrlPersonCardWithFillter11.TabIndex = 0;
            this.ctrlPersonCardWithFillter11.OnPersonSelected += new System.Action<int>(this.ctrlPersonCardWithFillter11_OnPersonSelected);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(250, 117);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 39);
            this.lblTitle.TabIndex = 92;
            this.lblTitle.Text = "Add New Member";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(173, 201);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(49, 25);
            this.lblPersonID.TabIndex = 140;
            this.lblPersonID.Text = "N/A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(17, 200);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 25);
            this.label22.TabIndex = 139;
            this.label22.Text = "Person ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 143;
            this.label3.Text = "Join Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 142;
            this.label2.Text = "Member ID :";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(230, 30);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(74, 25);
            this.lblMemberID.TabIndex = 145;
            this.lblMemberID.Text = "[????]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpExpirationDate);
            this.groupBox1.Controls.Add(this.lblCreatedBy);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ckbxIsActive);
            this.groupBox1.Controls.Add(this.lblExpirationDate);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblJoinDate);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMemberID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Location = new System.Drawing.Point(24, 613);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 184);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Info";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(614, 69);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(170, 30);
            this.dtpExpirationDate.TabIndex = 147;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(229, 69);
            this.lblCreatedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(74, 25);
            this.lblCreatedBy.TabIndex = 154;
            this.lblCreatedBy.Text = "[????]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LMS.Properties.Resources.User_32__2;
            this.pictureBox5.Location = new System.Drawing.Point(196, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 153;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 152;
            this.label5.Text = "Created By  :";
            // 
            // ckbxIsActive
            // 
            this.ckbxIsActive.AutoSize = true;
            this.ckbxIsActive.Checked = true;
            this.ckbxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ckbxIsActive.Location = new System.Drawing.Point(312, 130);
            this.ckbxIsActive.Name = "ckbxIsActive";
            this.ckbxIsActive.Size = new System.Drawing.Size(117, 29);
            this.ckbxIsActive.TabIndex = 151;
            this.ckbxIsActive.Text = "Is Active";
            this.ckbxIsActive.UseVisualStyleBackColor = true;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(697, 28);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(74, 25);
            this.lblExpirationDate.TabIndex = 150;
            this.lblExpirationDate.Text = "[????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LMS.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(577, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 149;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 148;
            this.label4.Text = "Expiration Date :";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.Location = new System.Drawing.Point(551, 33);
            this.lblJoinDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(74, 25);
            this.lblJoinDate.TabIndex = 147;
            this.lblJoinDate.Text = "[????]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LMS.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(518, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 146;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LMS.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(197, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 144;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LMS.Properties.Resources.icons8_student_male_1000;
            this.pictureBox6.Location = new System.Drawing.Point(308, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(234, 116);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 147;
            this.pictureBox6.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Image = global::LMS.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(607, 805);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 37);
            this.btnClose.TabIndex = 138;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = global::LMS.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(726, 805);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 37);
            this.btnSave.TabIndex = 137;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(135, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 852);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlPersonCardWithFillter11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateMember";
            this.Load += new System.EventHandler(this.frmAddUpdateMember_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.Controls.ctrlPersonCardWithFillter1 ctrlPersonCardWithFillter11;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbxIsActive;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}