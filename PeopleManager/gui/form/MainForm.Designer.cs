
namespace PeopleManager.gui.form
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.panelSubPeopleManagement = new System.Windows.Forms.Panel();
            this.btnFamily = new FontAwesome.Sharp.IconButton();
            this.btnPerson = new FontAwesome.Sharp.IconButton();
            this.btnPeopleManagement = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnContributionManagement = new FontAwesome.Sharp.IconButton();
            this.panelSubContribution = new System.Windows.Forms.Panel();
            this.btnContribution = new FontAwesome.Sharp.IconButton();
            this.btnFund = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelSlideMenu.SuspendLayout();
            this.panelSubPeopleManagement.SuspendLayout();
            this.panelSubContribution.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSlideMenu.Controls.Add(this.iconButton1);
            this.panelSlideMenu.Controls.Add(this.panelSubContribution);
            this.panelSlideMenu.Controls.Add(this.btnContributionManagement);
            this.panelSlideMenu.Controls.Add(this.panelSubPeopleManagement);
            this.panelSlideMenu.Controls.Add(this.btnPeopleManagement);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(150, 600);
            this.panelSlideMenu.TabIndex = 0;
            // 
            // panelSubPeopleManagement
            // 
            this.panelSubPeopleManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubPeopleManagement.Controls.Add(this.btnFamily);
            this.panelSubPeopleManagement.Controls.Add(this.btnPerson);
            this.panelSubPeopleManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubPeopleManagement.Location = new System.Drawing.Point(0, 135);
            this.panelSubPeopleManagement.Name = "panelSubPeopleManagement";
            this.panelSubPeopleManagement.Size = new System.Drawing.Size(150, 90);
            this.panelSubPeopleManagement.TabIndex = 0;
            // 
            // btnFamily
            // 
            this.btnFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFamily.FlatAppearance.BorderSize = 0;
            this.btnFamily.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFamily.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamily.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFamily.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnFamily.IconColor = System.Drawing.Color.White;
            this.btnFamily.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFamily.IconSize = 30;
            this.btnFamily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamily.Location = new System.Drawing.Point(0, 40);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.btnFamily.Size = new System.Drawing.Size(150, 40);
            this.btnFamily.TabIndex = 1;
            this.btnFamily.Text = "Hộ khẩu";
            this.btnFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFamily.UseVisualStyleBackColor = true;
            this.btnFamily.Click += new System.EventHandler(this.btnFamily_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerson.FlatAppearance.BorderSize = 0;
            this.btnPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPerson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerson.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPerson.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnPerson.IconColor = System.Drawing.Color.White;
            this.btnPerson.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerson.IconSize = 30;
            this.btnPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerson.Location = new System.Drawing.Point(0, 0);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnPerson.Size = new System.Drawing.Size(150, 40);
            this.btnPerson.TabIndex = 0;
            this.btnPerson.Text = "Nhân khẩu";
            this.btnPerson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnPeopleManagement
            // 
            this.btnPeopleManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeopleManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeopleManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeopleManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPeopleManagement.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnPeopleManagement.IconColor = System.Drawing.Color.White;
            this.btnPeopleManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPeopleManagement.IconSize = 40;
            this.btnPeopleManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeopleManagement.Location = new System.Drawing.Point(0, 90);
            this.btnPeopleManagement.Name = "btnPeopleManagement";
            this.btnPeopleManagement.Size = new System.Drawing.Size(150, 45);
            this.btnPeopleManagement.TabIndex = 0;
            this.btnPeopleManagement.Text = "Quản lí nhân khẩu";
            this.btnPeopleManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeopleManagement.UseVisualStyleBackColor = true;
            this.btnPeopleManagement.Click += new System.EventHandler(this.btnPeopleManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 90);
            this.panelLogo.TabIndex = 3;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(150, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(835, 600);
            this.panelContainer.TabIndex = 1;
            // 
            // btnContributionManagement
            // 
            this.btnContributionManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContributionManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContributionManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContributionManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContributionManagement.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnContributionManagement.IconColor = System.Drawing.Color.White;
            this.btnContributionManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContributionManagement.IconSize = 40;
            this.btnContributionManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContributionManagement.Location = new System.Drawing.Point(0, 225);
            this.btnContributionManagement.Name = "btnContributionManagement";
            this.btnContributionManagement.Size = new System.Drawing.Size(150, 45);
            this.btnContributionManagement.TabIndex = 4;
            this.btnContributionManagement.Text = "Quản lí đóng góp";
            this.btnContributionManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContributionManagement.UseVisualStyleBackColor = true;
            this.btnContributionManagement.Click += new System.EventHandler(this.btnContribution_Click);
            // 
            // panelSubContribution
            // 
            this.panelSubContribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubContribution.Controls.Add(this.btnContribution);
            this.panelSubContribution.Controls.Add(this.btnFund);
            this.panelSubContribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubContribution.Location = new System.Drawing.Point(0, 270);
            this.panelSubContribution.Name = "panelSubContribution";
            this.panelSubContribution.Size = new System.Drawing.Size(150, 90);
            this.panelSubContribution.TabIndex = 5;
            // 
            // btnContribution
            // 
            this.btnContribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContribution.FlatAppearance.BorderSize = 0;
            this.btnContribution.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContribution.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContribution.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContribution.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnContribution.IconColor = System.Drawing.Color.White;
            this.btnContribution.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContribution.IconSize = 30;
            this.btnContribution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContribution.Location = new System.Drawing.Point(0, 40);
            this.btnContribution.Name = "btnContribution";
            this.btnContribution.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnContribution.Size = new System.Drawing.Size(150, 40);
            this.btnContribution.TabIndex = 1;
            this.btnContribution.Text = "Đóng phí";
            this.btnContribution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContribution.UseVisualStyleBackColor = true;
            this.btnContribution.Click += new System.EventHandler(this.btnContribution_Click_1);
            // 
            // btnFund
            // 
            this.btnFund.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFund.FlatAppearance.BorderSize = 0;
            this.btnFund.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFund.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFund.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFund.IconChar = FontAwesome.Sharp.IconChar.FunnelDollar;
            this.btnFund.IconColor = System.Drawing.Color.White;
            this.btnFund.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFund.IconSize = 30;
            this.btnFund.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFund.Location = new System.Drawing.Point(0, 0);
            this.btnFund.Name = "btnFund";
            this.btnFund.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnFund.Size = new System.Drawing.Size(150, 40);
            this.btnFund.TabIndex = 0;
            this.btnFund.Text = "Khoản phí";
            this.btnFund.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFund.UseVisualStyleBackColor = true;
            this.btnFund.Click += new System.EventHandler(this.btnFund_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 360);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(150, 45);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Thống kê";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSlideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Quản lí nhân khẩu";
            this.panelSlideMenu.ResumeLayout(false);
            this.panelSubPeopleManagement.ResumeLayout(false);
            this.panelSubContribution.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelSubPeopleManagement;
        private FontAwesome.Sharp.IconButton btnFamily;
        private FontAwesome.Sharp.IconButton btnPerson;
        private FontAwesome.Sharp.IconButton btnPeopleManagement;
        private System.Windows.Forms.Panel panelSubContribution;
        private FontAwesome.Sharp.IconButton btnContribution;
        private FontAwesome.Sharp.IconButton btnFund;
        private FontAwesome.Sharp.IconButton btnContributionManagement;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}