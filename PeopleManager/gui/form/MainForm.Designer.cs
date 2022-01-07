
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
            this.panelInfor = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnStatistic = new FontAwesome.Sharp.IconButton();
            this.panelContribution = new System.Windows.Forms.Panel();
            this.btnContribute = new FontAwesome.Sharp.IconButton();
            this.btnFund = new FontAwesome.Sharp.IconButton();
            this.btnContribution = new FontAwesome.Sharp.IconButton();
            this.panelChange = new System.Windows.Forms.Panel();
            this.btnDie = new FontAwesome.Sharp.IconButton();
            this.btnAbsent = new FontAwesome.Sharp.IconButton();
            this.btnStay = new FontAwesome.Sharp.IconButton();
            this.btnChangePeople = new FontAwesome.Sharp.IconButton();
            this.btnInfor = new FontAwesome.Sharp.IconButton();
            this.panelSubPeopleManagement = new System.Windows.Forms.Panel();
            this.btnFamily = new FontAwesome.Sharp.IconButton();
            this.btnPerson = new FontAwesome.Sharp.IconButton();
            this.btnPeopleManagement = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panelSlideMenu.SuspendLayout();
            this.panelInfor.SuspendLayout();
            this.panelContribution.SuspendLayout();
            this.panelChange.SuspendLayout();
            this.panelSubPeopleManagement.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.AutoScroll = true;
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSlideMenu.Controls.Add(this.panelInfor);
            this.panelSlideMenu.Controls.Add(this.btnStatistic);
            this.panelSlideMenu.Controls.Add(this.panelContribution);
            this.panelSlideMenu.Controls.Add(this.btnContribution);
            this.panelSlideMenu.Controls.Add(this.panelChange);
            this.panelSlideMenu.Controls.Add(this.btnChangePeople);
            this.panelSlideMenu.Controls.Add(this.btnInfor);
            this.panelSlideMenu.Controls.Add(this.panelSubPeopleManagement);
            this.panelSlideMenu.Controls.Add(this.btnPeopleManagement);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(150, 701);
            this.panelSlideMenu.TabIndex = 0;
            // 
            // panelInfor
            // 
            this.panelInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelInfor.Controls.Add(this.btnLogout);
            this.panelInfor.Controls.Add(this.btnUser);
            this.panelInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfor.Location = new System.Drawing.Point(0, 581);
            this.panelInfor.Name = "panelInfor";
            this.panelInfor.Size = new System.Drawing.Size(133, 81);
            this.panelInfor.TabIndex = 13;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 41);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnLogout.Size = new System.Drawing.Size(133, 40);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btnUser.IconColor = System.Drawing.Color.White;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 30;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnUser.Size = new System.Drawing.Size(133, 41);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Tên người dùng - tổ trưởng";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatistic.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnStatistic.IconColor = System.Drawing.Color.White;
            this.btnStatistic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatistic.IconSize = 40;
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(0, 534);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(133, 47);
            this.btnStatistic.TabIndex = 12;
            this.btnStatistic.Text = "Thống kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Visible = false;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // panelContribution
            // 
            this.panelContribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelContribution.Controls.Add(this.btnContribute);
            this.panelContribution.Controls.Add(this.btnFund);
            this.panelContribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContribution.Location = new System.Drawing.Point(0, 445);
            this.panelContribution.Name = "panelContribution";
            this.panelContribution.Size = new System.Drawing.Size(133, 89);
            this.panelContribution.TabIndex = 11;
            // 
            // btnContribute
            // 
            this.btnContribute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContribute.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContribute.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContribute.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnContribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContribute.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContribute.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnContribute.IconColor = System.Drawing.Color.White;
            this.btnContribute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContribute.IconSize = 30;
            this.btnContribute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContribute.Location = new System.Drawing.Point(0, 40);
            this.btnContribute.Name = "btnContribute";
            this.btnContribute.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnContribute.Size = new System.Drawing.Size(133, 40);
            this.btnContribute.TabIndex = 1;
            this.btnContribute.Text = "Đóng phí";
            this.btnContribute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContribute.UseVisualStyleBackColor = true;
            this.btnContribute.Click += new System.EventHandler(this.btnContribute_Click);
            // 
            // btnFund
            // 
            this.btnFund.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFund.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            this.btnFund.Size = new System.Drawing.Size(133, 40);
            this.btnFund.TabIndex = 0;
            this.btnFund.Text = "Khoản thu";
            this.btnFund.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFund.UseVisualStyleBackColor = true;
            this.btnFund.Click += new System.EventHandler(this.btnFund_Click);
            // 
            // btnContribution
            // 
            this.btnContribution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContribution.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContribution.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContribution.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnContribution.IconColor = System.Drawing.Color.White;
            this.btnContribution.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContribution.IconSize = 40;
            this.btnContribution.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContribution.Location = new System.Drawing.Point(0, 400);
            this.btnContribution.Name = "btnContribution";
            this.btnContribution.Size = new System.Drawing.Size(133, 45);
            this.btnContribution.TabIndex = 10;
            this.btnContribution.Text = "Quản lí đóng góp";
            this.btnContribution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContribution.UseVisualStyleBackColor = true;
            this.btnContribution.Click += new System.EventHandler(this.btnContribution_Click_2);
            // 
            // panelChange
            // 
            this.panelChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelChange.Controls.Add(this.btnDie);
            this.panelChange.Controls.Add(this.btnAbsent);
            this.panelChange.Controls.Add(this.btnStay);
            this.panelChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChange.Location = new System.Drawing.Point(0, 270);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(133, 130);
            this.panelChange.TabIndex = 9;
            // 
            // btnDie
            // 
            this.btnDie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDie.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDie.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDie.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDie.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnDie.IconColor = System.Drawing.Color.White;
            this.btnDie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDie.IconSize = 30;
            this.btnDie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDie.Location = new System.Drawing.Point(0, 80);
            this.btnDie.Name = "btnDie";
            this.btnDie.Padding = new System.Windows.Forms.Padding(0, 0, 55, 0);
            this.btnDie.Size = new System.Drawing.Size(133, 40);
            this.btnDie.TabIndex = 2;
            this.btnDie.Text = "Khai tử";
            this.btnDie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDie.UseVisualStyleBackColor = true;
            this.btnDie.Click += new System.EventHandler(this.btnDie_Click);
            // 
            // btnAbsent
            // 
            this.btnAbsent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbsent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbsent.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbsent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbsent.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnAbsent.IconColor = System.Drawing.Color.White;
            this.btnAbsent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbsent.IconSize = 30;
            this.btnAbsent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbsent.Location = new System.Drawing.Point(0, 40);
            this.btnAbsent.Name = "btnAbsent";
            this.btnAbsent.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.btnAbsent.Size = new System.Drawing.Size(133, 40);
            this.btnAbsent.TabIndex = 1;
            this.btnAbsent.Text = "Tạm vắng";
            this.btnAbsent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbsent.UseVisualStyleBackColor = true;
            this.btnAbsent.Click += new System.EventHandler(this.btnAbsent_Click);
            // 
            // btnStay
            // 
            this.btnStay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStay.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnStay.IconColor = System.Drawing.Color.White;
            this.btnStay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStay.IconSize = 30;
            this.btnStay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStay.Location = new System.Drawing.Point(0, 0);
            this.btnStay.Name = "btnStay";
            this.btnStay.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.btnStay.Size = new System.Drawing.Size(133, 40);
            this.btnStay.TabIndex = 0;
            this.btnStay.Text = "Tạm trú";
            this.btnStay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnChangePeople
            // 
            this.btnChangePeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePeople.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChangePeople.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnChangePeople.IconColor = System.Drawing.Color.White;
            this.btnChangePeople.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePeople.IconSize = 40;
            this.btnChangePeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePeople.Location = new System.Drawing.Point(0, 225);
            this.btnChangePeople.Name = "btnChangePeople";
            this.btnChangePeople.Size = new System.Drawing.Size(133, 45);
            this.btnChangePeople.TabIndex = 8;
            this.btnChangePeople.Text = "Thay đổi nhân khẩu";
            this.btnChangePeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePeople.UseVisualStyleBackColor = true;
            this.btnChangePeople.Click += new System.EventHandler(this.btnChangePeople_Click);
            // 
            // btnInfor
            // 
            this.btnInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInfor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfor.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnInfor.IconColor = System.Drawing.Color.White;
            this.btnInfor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfor.IconSize = 40;
            this.btnInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfor.Location = new System.Drawing.Point(0, 662);
            this.btnInfor.Name = "btnInfor";
            this.btnInfor.Size = new System.Drawing.Size(133, 45);
            this.btnInfor.TabIndex = 7;
            this.btnInfor.Text = "Thông tin";
            this.btnInfor.UseVisualStyleBackColor = true;
            this.btnInfor.Click += new System.EventHandler(this.btnInfor_Click);
            // 
            // panelSubPeopleManagement
            // 
            this.panelSubPeopleManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubPeopleManagement.Controls.Add(this.btnFamily);
            this.panelSubPeopleManagement.Controls.Add(this.btnPerson);
            this.panelSubPeopleManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubPeopleManagement.Location = new System.Drawing.Point(0, 135);
            this.panelSubPeopleManagement.Name = "panelSubPeopleManagement";
            this.panelSubPeopleManagement.Size = new System.Drawing.Size(133, 90);
            this.panelSubPeopleManagement.TabIndex = 0;
            // 
            // btnFamily
            // 
            this.btnFamily.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFamily.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            this.btnFamily.Size = new System.Drawing.Size(133, 40);
            this.btnFamily.TabIndex = 1;
            this.btnFamily.Text = "Hộ khẩu";
            this.btnFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFamily.UseVisualStyleBackColor = true;
            this.btnFamily.Click += new System.EventHandler(this.btnFamily_Click);
            // 
            // btnPerson
            // 
            this.btnPerson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerson.FlatAppearance.BorderColor = System.Drawing.Color.White;
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
            this.btnPerson.Size = new System.Drawing.Size(133, 40);
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
            this.btnPeopleManagement.Size = new System.Drawing.Size(133, 45);
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
            this.panelLogo.Size = new System.Drawing.Size(133, 90);
            this.panelLogo.TabIndex = 3;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelContainer.Controls.Add(this.rjCircularPictureBox1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(150, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(834, 701);
            this.panelContainer.TabIndex = 1;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(250, 150);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(402, 402);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 701);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSlideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Quản lí nhân khẩu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSlideMenu.ResumeLayout(false);
            this.panelInfor.ResumeLayout(false);
            this.panelContribution.ResumeLayout(false);
            this.panelChange.ResumeLayout(false);
            this.panelSubPeopleManagement.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelSubPeopleManagement;
        private FontAwesome.Sharp.IconButton btnFamily;
        private FontAwesome.Sharp.IconButton btnPerson;
        private FontAwesome.Sharp.IconButton btnPeopleManagement;
        private FontAwesome.Sharp.IconButton btnInfor;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnStatistic;
        private System.Windows.Forms.Panel panelContribution;
        private FontAwesome.Sharp.IconButton btnContribute;
        private FontAwesome.Sharp.IconButton btnFund;
        private FontAwesome.Sharp.IconButton btnContribution;
        private System.Windows.Forms.Panel panelChange;
        private FontAwesome.Sharp.IconButton btnAbsent;
        private FontAwesome.Sharp.IconButton btnStay;
        private FontAwesome.Sharp.IconButton btnChangePeople;
        private FontAwesome.Sharp.IconButton btnDie;
        private System.Windows.Forms.Panel panelInfor;
        private FontAwesome.Sharp.IconButton btnUser;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}