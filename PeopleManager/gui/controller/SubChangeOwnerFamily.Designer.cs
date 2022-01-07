
namespace PeopleManager.gui.controller
{
    partial class SubChangeOwnerFamily
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
            this.btnOk = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMember = new RJCodeAdvance.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFamily = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.iconclose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            this.SuspendLayout();
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
            this.btnOk.Location = new System.Drawing.Point(679, 257);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(137, 34);
            this.btnOk.TabIndex = 53;
            this.btnOk.Text = "OK";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Chủ hộ mới";
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
            this.cbMember.Location = new System.Drawing.Point(100, 37);
            this.cbMember.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbMember.Name = "cbMember";
            this.cbMember.Padding = new System.Windows.Forms.Padding(1);
            this.cbMember.Size = new System.Drawing.Size(347, 30);
            this.cbMember.TabIndex = 50;
            this.cbMember.Texts = "Chọn chủ hộ mới";
            this.cbMember.OnSelectedIndexChanged += new System.EventHandler(this.cbMember_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Thay đổi chủ hộ cho hộ khẩu";
            // 
            // lbFamily
            // 
            this.lbFamily.AutoSize = true;
            this.lbFamily.ForeColor = System.Drawing.Color.White;
            this.lbFamily.Location = new System.Drawing.Point(170, 9);
            this.lbFamily.Name = "lbFamily";
            this.lbFamily.Size = new System.Drawing.Size(0, 13);
            this.lbFamily.TabIndex = 55;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Location = new System.Drawing.Point(3, 75);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(813, 176);
            this.panelContainer.TabIndex = 56;
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
            this.iconclose.TabIndex = 57;
            this.iconclose.TabStop = false;
            this.iconclose.Click += new System.EventHandler(this.iconclose_Click);
            // 
            // SubChangeOwnerFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.iconclose);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.lbFamily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMember);
            this.Name = "SubChangeOwnerFamily";
            this.Size = new System.Drawing.Size(819, 306);
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnOk;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJComboBox cbMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFamily;
        private System.Windows.Forms.FlowLayoutPanel panelContainer;
        private FontAwesome.Sharp.IconPictureBox iconclose;
    }
}
