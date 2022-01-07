
namespace PeopleManager.gui.controller
{
    partial class SubSeparateFamily
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
            this.cbMember = new RJCodeAdvance.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewFamily = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnOk = new RJCodeAdvance.RJControls.RJButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFamily = new System.Windows.Forms.Label();
            this.iconclose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMember
            // 
            this.cbMember.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMember.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMember.BorderSize = 1;
            this.cbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbMember.ForeColor = System.Drawing.Color.DimGray;
            this.cbMember.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbMember.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbMember.ListTextColor = System.Drawing.Color.Black;
            this.cbMember.Location = new System.Drawing.Point(36, 36);
            this.cbMember.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMember.Name = "cbMember";
            this.cbMember.Padding = new System.Windows.Forms.Padding(1);
            this.cbMember.Size = new System.Drawing.Size(262, 30);
            this.cbMember.TabIndex = 2;
            this.cbMember.Texts = "Chọn thành viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hộ khẩu mới";
            // 
            // txtNewFamily
            // 
            this.txtNewFamily.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewFamily.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewFamily.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewFamily.BorderRadius = 10;
            this.txtNewFamily.BorderSize = 2;
            this.txtNewFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewFamily.Location = new System.Drawing.Point(377, 35);
            this.txtNewFamily.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewFamily.Multiline = false;
            this.txtNewFamily.Name = "txtNewFamily";
            this.txtNewFamily.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewFamily.PasswordChar = false;
            this.txtNewFamily.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewFamily.PlaceholderText = "";
            this.txtNewFamily.Size = new System.Drawing.Size(206, 31);
            this.txtNewFamily.TabIndex = 4;
            this.txtNewFamily.Texts = "";
            this.txtNewFamily.UnderlinedStyle = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOk.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOk.BorderRadius = 15;
            this.btnOk.BorderSize = 0;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(650, 32);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(156, 34);
            this.btnOk.TabIndex = 49;
            this.btnOk.Text = "OK";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(33, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(156, 13);
            this.lbTitle.TabIndex = 50;
            this.lbTitle.Text = "Tách hộ khẩu mới cho hộ khẩu";
            // 
            // lbFamily
            // 
            this.lbFamily.AutoSize = true;
            this.lbFamily.ForeColor = System.Drawing.Color.White;
            this.lbFamily.Location = new System.Drawing.Point(188, 9);
            this.lbFamily.Name = "lbFamily";
            this.lbFamily.Size = new System.Drawing.Size(0, 13);
            this.lbFamily.TabIndex = 51;
            // 
            // iconclose
            // 
            this.iconclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.iconclose.ForeColor = System.Drawing.Color.Maroon;
            this.iconclose.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.iconclose.IconColor = System.Drawing.Color.Maroon;
            this.iconclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconclose.IconSize = 25;
            this.iconclose.Location = new System.Drawing.Point(791, 3);
            this.iconclose.Name = "iconclose";
            this.iconclose.Size = new System.Drawing.Size(25, 25);
            this.iconclose.TabIndex = 58;
            this.iconclose.TabStop = false;
            this.iconclose.Click += new System.EventHandler(this.iconclose_Click);
            // 
            // SubSeparateFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.iconclose);
            this.Controls.Add(this.lbFamily);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNewFamily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMember);
            this.Name = "SubSeparateFamily";
            this.Size = new System.Drawing.Size(819, 92);
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJComboBox cbMember;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtNewFamily;
        private RJCodeAdvance.RJControls.RJButton btnOk;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFamily;
        private FontAwesome.Sharp.IconPictureBox iconclose;
    }
}
