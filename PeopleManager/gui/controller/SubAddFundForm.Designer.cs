
namespace PeopleManager.gui.controller
{
    partial class SubAddFundForm
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
            this.iconclose = new FontAwesome.Sharp.IconPictureBox();
            this.rbtnNoRequired = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rbtnRequired = new RJCodeAdvance.RJControls.RJRadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateExpired = new RJCodeAdvance.RJControls.RJDatePicker();
            this.txtDecription = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new RJCodeAdvance.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnPerson = new RJCodeAdvance.RJControls.RJRadioButton();
            this.rbtnForFamily = new RJCodeAdvance.RJControls.RJRadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new RJCodeAdvance.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.iconclose.TabIndex = 21;
            this.iconclose.TabStop = false;
            this.iconclose.Click += new System.EventHandler(this.iconclose_Click);
            // 
            // rbtnNoRequired
            // 
            this.rbtnNoRequired.AutoSize = true;
            this.rbtnNoRequired.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnNoRequired.ForeColor = System.Drawing.Color.White;
            this.rbtnNoRequired.Location = new System.Drawing.Point(3, 3);
            this.rbtnNoRequired.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnNoRequired.Name = "rbtnNoRequired";
            this.rbtnNoRequired.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnNoRequired.Size = new System.Drawing.Size(66, 21);
            this.rbtnNoRequired.TabIndex = 32;
            this.rbtnNoRequired.Text = "Không";
            this.rbtnNoRequired.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnNoRequired.UseVisualStyleBackColor = true;
            // 
            // rbtnRequired
            // 
            this.rbtnRequired.AutoSize = true;
            this.rbtnRequired.Checked = true;
            this.rbtnRequired.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnRequired.ForeColor = System.Drawing.Color.White;
            this.rbtnRequired.Location = new System.Drawing.Point(75, 3);
            this.rbtnRequired.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnRequired.Name = "rbtnRequired";
            this.rbtnRequired.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnRequired.Size = new System.Drawing.Size(48, 21);
            this.rbtnRequired.TabIndex = 31;
            this.rbtnRequired.TabStop = true;
            this.rbtnRequired.Text = "Có";
            this.rbtnRequired.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnRequired.UseVisualStyleBackColor = true;
            this.rbtnRequired.CheckedChanged += new System.EventHandler(this.rbtnRequired_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(393, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Bắt buộc *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ngày kết thúc *";
            // 
            // dateExpired
            // 
            this.dateExpired.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateExpired.BorderSize = 0;
            this.dateExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateExpired.Location = new System.Drawing.Point(127, 141);
            this.dateExpired.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.Size = new System.Drawing.Size(206, 35);
            this.dateExpired.SkinColor = System.Drawing.Color.RoyalBlue;
            this.dateExpired.TabIndex = 28;
            this.dateExpired.TextColor = System.Drawing.Color.White;
            // 
            // txtDecription
            // 
            this.txtDecription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDecription.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDecription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDecription.BorderRadius = 10;
            this.txtDecription.BorderSize = 1;
            this.txtDecription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDecription.Location = new System.Drawing.Point(103, 78);
            this.txtDecription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDecription.Multiline = false;
            this.txtDecription.Name = "txtDecription";
            this.txtDecription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDecription.PasswordChar = false;
            this.txtDecription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDecription.PlaceholderText = "";
            this.txtDecription.Size = new System.Drawing.Size(230, 31);
            this.txtDecription.TabIndex = 27;
            this.txtDecription.Texts = "";
            this.txtDecription.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mô tả";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderRadius = 10;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(103, 16);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(230, 31);
            this.txtName.TabIndex = 25;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên khoản thu *";
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtValue.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtValue.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtValue.BorderRadius = 10;
            this.txtValue.BorderSize = 1;
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValue.Location = new System.Drawing.Point(551, 78);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtValue.Multiline = false;
            this.txtValue.Name = "txtValue";
            this.txtValue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtValue.PasswordChar = false;
            this.txtValue.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtValue.PlaceholderText = "";
            this.txtValue.Size = new System.Drawing.Size(230, 31);
            this.txtValue.TabIndex = 34;
            this.txtValue.Texts = "";
            this.txtValue.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(394, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Giá trị *";
            // 
            // rbtnPerson
            // 
            this.rbtnPerson.AutoSize = true;
            this.rbtnPerson.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnPerson.ForeColor = System.Drawing.Color.White;
            this.rbtnPerson.Location = new System.Drawing.Point(127, 19);
            this.rbtnPerson.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnPerson.Name = "rbtnPerson";
            this.rbtnPerson.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnPerson.Size = new System.Drawing.Size(114, 21);
            this.rbtnPerson.TabIndex = 37;
            this.rbtnPerson.Text = "Theo nhân khẩu";
            this.rbtnPerson.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnPerson.UseVisualStyleBackColor = true;
            // 
            // rbtnForFamily
            // 
            this.rbtnForFamily.AutoSize = true;
            this.rbtnForFamily.Checked = true;
            this.rbtnForFamily.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.rbtnForFamily.ForeColor = System.Drawing.Color.White;
            this.rbtnForFamily.Location = new System.Drawing.Point(29, 19);
            this.rbtnForFamily.MinimumSize = new System.Drawing.Size(0, 21);
            this.rbtnForFamily.Name = "rbtnForFamily";
            this.rbtnForFamily.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbtnForFamily.Size = new System.Drawing.Size(102, 21);
            this.rbtnForFamily.TabIndex = 36;
            this.rbtnForFamily.TabStop = true;
            this.rbtnForFamily.Text = "Theo hộ khẩu";
            this.rbtnForFamily.UnCheckedColor = System.Drawing.Color.Gray;
            this.rbtnForFamily.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(402, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hình thức thu *";
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
            this.btnOk.Location = new System.Drawing.Point(625, 189);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(156, 34);
            this.btnOk.TabIndex = 38;
            this.btnOk.Text = "OK";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnPerson);
            this.panel1.Controls.Add(this.rbtnForFamily);
            this.panel1.Location = new System.Drawing.Point(531, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 62);
            this.panel1.TabIndex = 39;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbtnNoRequired);
            this.flowLayoutPanel1.Controls.Add(this.rbtnRequired);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(520, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(260, 44);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // SubAddFundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateExpired);
            this.Controls.Add(this.txtDecription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconclose);
            this.Name = "SubAddFundForm";
            this.Size = new System.Drawing.Size(819, 240);
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconclose;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnNoRequired;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnRequired;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private RJCodeAdvance.RJControls.RJDatePicker dateExpired;
        private RJCodeAdvance.RJControls.RJTextBox txtDecription;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtName;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtValue;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnPerson;
        private RJCodeAdvance.RJControls.RJRadioButton rbtnForFamily;
        private System.Windows.Forms.Label label5;
        private RJCodeAdvance.RJControls.RJButton btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
