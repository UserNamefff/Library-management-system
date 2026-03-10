namespace LMS.Main
{
    partial class frmMain
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
            this.msMainMenue = new System.Windows.Forms.MenuStrip();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servecesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowingBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMainMenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenue
            // 
            this.msMainMenue.BackColor = System.Drawing.Color.White;
            this.msMainMenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainMenue.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMainMenue.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicesToolStripMenuItem,
            this.servecesToolStripMenuItem,
            this.MembersToolStripMenuItem,
            this.ManageBooksToolStripMenuItem,
            this.manageFinesToolStripMenuItem,
            this.UsersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.msMainMenue.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msMainMenue.Location = new System.Drawing.Point(0, 0);
            this.msMainMenue.Name = "msMainMenue";
            this.msMainMenue.Size = new System.Drawing.Size(1533, 72);
            this.msMainMenue.TabIndex = 2;
            this.msMainMenue.Text = "menuStrip1";
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Image = global::LMS.Properties.Resources.settings;
            this.servicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(162, 68);
            this.servicesToolStripMenuItem.Text = "Settings ";
            // 
            // servecesToolStripMenuItem
            // 
            this.servecesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowingBookToolStripMenuItem1,
            this.reservationBookToolStripMenuItem});
            this.servecesToolStripMenuItem.Image = global::LMS.Properties.Resources.Manage_Applications_64;
            this.servecesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.servecesToolStripMenuItem.Name = "servecesToolStripMenuItem";
            this.servecesToolStripMenuItem.Size = new System.Drawing.Size(165, 68);
            this.servecesToolStripMenuItem.Text = "Serveces";
            // 
            // borrowingBookToolStripMenuItem1
            // 
            this.borrowingBookToolStripMenuItem1.Image = global::LMS.Properties.Resources.borrow__3_;
            this.borrowingBookToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.borrowingBookToolStripMenuItem1.Name = "borrowingBookToolStripMenuItem1";
            this.borrowingBookToolStripMenuItem1.Size = new System.Drawing.Size(284, 70);
            this.borrowingBookToolStripMenuItem1.Text = "Borrowing Book";
            this.borrowingBookToolStripMenuItem1.Click += new System.EventHandler(this.borrowingBookToolStripMenuItem1_Click);
            // 
            // reservationBookToolStripMenuItem
            // 
            this.reservationBookToolStripMenuItem.Image = global::LMS.Properties.Resources.hotel;
            this.reservationBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reservationBookToolStripMenuItem.Name = "reservationBookToolStripMenuItem";
            this.reservationBookToolStripMenuItem.Size = new System.Drawing.Size(284, 70);
            this.reservationBookToolStripMenuItem.Text = "Reservation Book";
            this.reservationBookToolStripMenuItem.Click += new System.EventHandler(this.reservationBookToolStripMenuItem_Click);
            // 
            // MembersToolStripMenuItem
            // 
            this.MembersToolStripMenuItem.Image = global::LMS.Properties.Resources.member_card;
            this.MembersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem";
            this.MembersToolStripMenuItem.Size = new System.Drawing.Size(164, 68);
            this.MembersToolStripMenuItem.Text = "Members";
            this.MembersToolStripMenuItem.Click += new System.EventHandler(this.MembersToolStripMenuItem_Click);
            // 
            // ManageBooksToolStripMenuItem
            // 
            this.ManageBooksToolStripMenuItem.Image = global::LMS.Properties.Resources.books;
            this.ManageBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageBooksToolStripMenuItem.Name = "ManageBooksToolStripMenuItem";
            this.ManageBooksToolStripMenuItem.Size = new System.Drawing.Size(210, 68);
            this.ManageBooksToolStripMenuItem.Text = "Manage Books";
            this.ManageBooksToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // manageFinesToolStripMenuItem
            // 
            this.manageFinesToolStripMenuItem.Image = global::LMS.Properties.Resources.banking;
            this.manageFinesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageFinesToolStripMenuItem.Name = "manageFinesToolStripMenuItem";
            this.manageFinesToolStripMenuItem.Size = new System.Drawing.Size(199, 68);
            this.manageFinesToolStripMenuItem.Text = "Manage fines";
            this.manageFinesToolStripMenuItem.Click += new System.EventHandler(this.manageFinesToolStripMenuItem_Click);
            // 
            // UsersToolStripMenuItem
            // 
            this.UsersToolStripMenuItem.Image = global::LMS.Properties.Resources.Users_2_64;
            this.UsersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem";
            this.UsersToolStripMenuItem.Size = new System.Drawing.Size(137, 68);
            this.UsersToolStripMenuItem.Text = "Users";
            this.UsersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Image = global::LMS.Properties.Resources.account_settings_64;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(230, 68);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.Image = global::LMS.Properties.Resources.PersonDetails_32;
            this.currentUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.currentUserToolStripMenuItem.Text = "Current User";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::LMS.Properties.Resources.sign_out_32__2;
            this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LMS.Properties.Resources.library_with_books;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1533, 802);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 802);
            this.Controls.Add(this.msMainMenue);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.msMainMenue.ResumeLayout(false);
            this.msMainMenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip msMainMenue;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servecesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowingBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reservationBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageBooksToolStripMenuItem;
    }
}