
namespace PeopleManager.gui.form
{
    partial class ViewDatagvPersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDatagvPersonForm));
            this.ckName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckNickname = new System.Windows.Forms.CheckBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.ckDoB = new System.Windows.Forms.CheckBox();
            this.panelck = new System.Windows.Forms.Panel();
            this.ckEthnic = new System.Windows.Forms.CheckBox();
            this.ckJob = new System.Windows.Forms.CheckBox();
            this.ckBornplace = new System.Windows.Forms.CheckBox();
            this.ckAddress = new System.Windows.Forms.CheckBox();
            this.ckFamily = new System.Windows.Forms.CheckBox();
            this.ckStatus = new System.Windows.Forms.CheckBox();
            this.ckJobplace = new System.Windows.Forms.CheckBox();
            this.ckRelationshipowner = new System.Windows.Forms.CheckBox();
            this.btnOK = new RJCodeAdvance.RJControls.RJButton();
            this.btnCancel = new RJCodeAdvance.RJControls.RJButton();
            this.ckCheckAll = new System.Windows.Forms.CheckBox();
            this.ckCMND = new System.Windows.Forms.CheckBox();
            this.panelck.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckName
            // 
            this.ckName.AutoSize = true;
            this.ckName.ForeColor = System.Drawing.Color.White;
            this.ckName.Location = new System.Drawing.Point(29, 28);
            this.ckName.Name = "ckName";
            this.ckName.Size = new System.Drawing.Size(73, 17);
            this.ckName.TabIndex = 0;
            this.ckName.Text = "Họ và tên";
            this.ckName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn những cột muốn hiển thị";
            // 
            // ckNickname
            // 
            this.ckNickname.AutoSize = true;
            this.ckNickname.ForeColor = System.Drawing.Color.White;
            this.ckNickname.Location = new System.Drawing.Point(150, 28);
            this.ckNickname.Name = "ckNickname";
            this.ckNickname.Size = new System.Drawing.Size(64, 17);
            this.ckNickname.TabIndex = 2;
            this.ckNickname.Text = "Bí danh";
            this.ckNickname.UseVisualStyleBackColor = true;
            // 
            // ckGender
            // 
            this.ckGender.AutoSize = true;
            this.ckGender.ForeColor = System.Drawing.Color.White;
            this.ckGender.Location = new System.Drawing.Point(290, 28);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(66, 17);
            this.ckGender.TabIndex = 3;
            this.ckGender.Text = "Giới tính";
            this.ckGender.UseVisualStyleBackColor = true;
            // 
            // ckDoB
            // 
            this.ckDoB.AutoSize = true;
            this.ckDoB.ForeColor = System.Drawing.Color.White;
            this.ckDoB.Location = new System.Drawing.Point(414, 28);
            this.ckDoB.Name = "ckDoB";
            this.ckDoB.Size = new System.Drawing.Size(73, 17);
            this.ckDoB.TabIndex = 4;
            this.ckDoB.Text = "Ngày sinh";
            this.ckDoB.UseVisualStyleBackColor = true;
            // 
            // panelck
            // 
            this.panelck.Controls.Add(this.ckCMND);
            this.panelck.Controls.Add(this.ckFamily);
            this.panelck.Controls.Add(this.ckStatus);
            this.panelck.Controls.Add(this.ckJobplace);
            this.panelck.Controls.Add(this.ckRelationshipowner);
            this.panelck.Controls.Add(this.ckEthnic);
            this.panelck.Controls.Add(this.ckJob);
            this.panelck.Controls.Add(this.ckBornplace);
            this.panelck.Controls.Add(this.ckAddress);
            this.panelck.Controls.Add(this.ckNickname);
            this.panelck.Controls.Add(this.ckDoB);
            this.panelck.Controls.Add(this.ckName);
            this.panelck.Controls.Add(this.ckGender);
            this.panelck.Location = new System.Drawing.Point(12, 67);
            this.panelck.Name = "panelck";
            this.panelck.Size = new System.Drawing.Size(514, 228);
            this.panelck.TabIndex = 5;
            // 
            // ckEthnic
            // 
            this.ckEthnic.AutoSize = true;
            this.ckEthnic.ForeColor = System.Drawing.Color.White;
            this.ckEthnic.Location = new System.Drawing.Point(150, 88);
            this.ckEthnic.Name = "ckEthnic";
            this.ckEthnic.Size = new System.Drawing.Size(64, 17);
            this.ckEthnic.TabIndex = 6;
            this.ckEthnic.Text = "Dân tộc";
            this.ckEthnic.UseVisualStyleBackColor = true;
            // 
            // ckJob
            // 
            this.ckJob.AutoSize = true;
            this.ckJob.ForeColor = System.Drawing.Color.White;
            this.ckJob.Location = new System.Drawing.Point(414, 88);
            this.ckJob.Name = "ckJob";
            this.ckJob.Size = new System.Drawing.Size(87, 17);
            this.ckJob.TabIndex = 8;
            this.ckJob.Text = "Nghề nghiệp";
            this.ckJob.UseVisualStyleBackColor = true;
            // 
            // ckBornplace
            // 
            this.ckBornplace.AutoSize = true;
            this.ckBornplace.ForeColor = System.Drawing.Color.White;
            this.ckBornplace.Location = new System.Drawing.Point(29, 88);
            this.ckBornplace.Name = "ckBornplace";
            this.ckBornplace.Size = new System.Drawing.Size(64, 17);
            this.ckBornplace.TabIndex = 5;
            this.ckBornplace.Text = "Nơi sinh";
            this.ckBornplace.UseVisualStyleBackColor = true;
            // 
            // ckAddress
            // 
            this.ckAddress.AutoSize = true;
            this.ckAddress.ForeColor = System.Drawing.Color.White;
            this.ckAddress.Location = new System.Drawing.Point(408, 144);
            this.ckAddress.Name = "ckAddress";
            this.ckAddress.Size = new System.Drawing.Size(93, 17);
            this.ckAddress.TabIndex = 7;
            this.ckAddress.Text = "Nơi thường trú";
            this.ckAddress.UseVisualStyleBackColor = true;
            // 
            // ckFamily
            // 
            this.ckFamily.AutoSize = true;
            this.ckFamily.ForeColor = System.Drawing.Color.White;
            this.ckFamily.Location = new System.Drawing.Point(150, 144);
            this.ckFamily.Name = "ckFamily";
            this.ckFamily.Size = new System.Drawing.Size(67, 17);
            this.ckFamily.TabIndex = 10;
            this.ckFamily.Text = "Hộ khẩu";
            this.ckFamily.UseVisualStyleBackColor = true;
            // 
            // ckStatus
            // 
            this.ckStatus.AutoSize = true;
            this.ckStatus.ForeColor = System.Drawing.Color.White;
            this.ckStatus.Location = new System.Drawing.Point(29, 195);
            this.ckStatus.Name = "ckStatus";
            this.ckStatus.Size = new System.Drawing.Size(74, 17);
            this.ckStatus.TabIndex = 12;
            this.ckStatus.Text = "Trạng thái";
            this.ckStatus.UseVisualStyleBackColor = true;
            // 
            // ckJobplace
            // 
            this.ckJobplace.AutoSize = true;
            this.ckJobplace.ForeColor = System.Drawing.Color.White;
            this.ckJobplace.Location = new System.Drawing.Point(29, 144);
            this.ckJobplace.Name = "ckJobplace";
            this.ckJobplace.Size = new System.Drawing.Size(84, 17);
            this.ckJobplace.TabIndex = 9;
            this.ckJobplace.Text = "Nơi làm việc";
            this.ckJobplace.UseVisualStyleBackColor = true;
            // 
            // ckRelationshipowner
            // 
            this.ckRelationshipowner.AutoSize = true;
            this.ckRelationshipowner.ForeColor = System.Drawing.Color.White;
            this.ckRelationshipowner.Location = new System.Drawing.Point(290, 144);
            this.ckRelationshipowner.Name = "ckRelationshipowner";
            this.ckRelationshipowner.Size = new System.Drawing.Size(103, 17);
            this.ckRelationshipowner.TabIndex = 11;
            this.ckRelationshipowner.Text = "Quan hệ chủ hộ";
            this.ckRelationshipowner.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOK.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOK.BorderRadius = 10;
            this.btnOK.BorderSize = 0;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(321, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 35);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(143, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckCheckAll
            // 
            this.ckCheckAll.AutoSize = true;
            this.ckCheckAll.ForeColor = System.Drawing.Color.White;
            this.ckCheckAll.Location = new System.Drawing.Point(270, 23);
            this.ckCheckAll.Name = "ckCheckAll";
            this.ckCheckAll.Size = new System.Drawing.Size(81, 17);
            this.ckCheckAll.TabIndex = 8;
            this.ckCheckAll.Text = "Chọn tất cả";
            this.ckCheckAll.UseVisualStyleBackColor = true;
            this.ckCheckAll.CheckedChanged += new System.EventHandler(this.ckCheckAll_CheckedChanged);
            // 
            // ckCMND
            // 
            this.ckCMND.AutoSize = true;
            this.ckCMND.ForeColor = System.Drawing.Color.White;
            this.ckCMND.Location = new System.Drawing.Point(290, 88);
            this.ckCMND.Name = "ckCMND";
            this.ckCMND.Size = new System.Drawing.Size(74, 17);
            this.ckCMND.TabIndex = 13;
            this.ckCMND.Text = "Số CMND";
            this.ckCMND.UseVisualStyleBackColor = true;
            // 
            // ViewDatagvPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(548, 362);
            this.Controls.Add(this.ckCheckAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panelck);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewDatagvPersonForm";
            this.Text = "Cài đặt hiển thị";
            this.panelck.ResumeLayout(false);
            this.panelck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelck;
        private RJCodeAdvance.RJControls.RJButton btnOK;
        private RJCodeAdvance.RJControls.RJButton btnCancel;
        private System.Windows.Forms.CheckBox ckCheckAll;
        public System.Windows.Forms.CheckBox ckName;
        public System.Windows.Forms.CheckBox ckNickname;
        public System.Windows.Forms.CheckBox ckGender;
        public System.Windows.Forms.CheckBox ckDoB;
        public System.Windows.Forms.CheckBox ckBornplace;
        public System.Windows.Forms.CheckBox ckEthnic;
        public System.Windows.Forms.CheckBox ckFamily;
        public System.Windows.Forms.CheckBox ckRelationshipowner;
        public System.Windows.Forms.CheckBox ckStatus;
        public System.Windows.Forms.CheckBox ckJobplace;
        public System.Windows.Forms.CheckBox ckJob;
        public System.Windows.Forms.CheckBox ckAddress;
        public System.Windows.Forms.CheckBox ckCMND;
    }
}