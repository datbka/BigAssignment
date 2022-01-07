
namespace PeopleManager.gui.controller
{
    partial class SubLeave
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestination = new RJCodeAdvance.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNote = new RJCodeAdvance.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateExpired = new RJCodeAdvance.RJControls.RJDatePicker();
            this.btnOk = new RJCodeAdvance.RJControls.RJButton();
            this.labelperson = new System.Windows.Forms.Label();
            this.iconclose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khai báo tạm vắng cho ";
            // 
            // txtDestination
            // 
            this.txtDestination.BackColor = System.Drawing.SystemColors.Window;
            this.txtDestination.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDestination.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDestination.BorderRadius = 10;
            this.txtDestination.BorderSize = 1;
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDestination.Location = new System.Drawing.Point(125, 43);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(4);
            this.txtDestination.Multiline = false;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDestination.PasswordChar = false;
            this.txtDestination.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDestination.PlaceholderText = "";
            this.txtDestination.Size = new System.Drawing.Size(296, 31);
            this.txtDestination.TabIndex = 8;
            this.txtDestination.Texts = "";
            this.txtDestination.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nơi đến *";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNote.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNote.BorderRadius = 10;
            this.txtNote.BorderSize = 1;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNote.Location = new System.Drawing.Point(501, 43);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Multiline = false;
            this.txtNote.Name = "txtNote";
            this.txtNote.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNote.PasswordChar = false;
            this.txtNote.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNote.PlaceholderText = "";
            this.txtNote.Size = new System.Drawing.Size(289, 31);
            this.txtNote.TabIndex = 10;
            this.txtNote.Texts = "";
            this.txtNote.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(449, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lí do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày về (dự kiến)*";
            // 
            // dateExpired
            // 
            this.dateExpired.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateExpired.BorderSize = 0;
            this.dateExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dateExpired.Location = new System.Drawing.Point(125, 81);
            this.dateExpired.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.Size = new System.Drawing.Size(206, 35);
            this.dateExpired.SkinColor = System.Drawing.Color.RoyalBlue;
            this.dateExpired.TabIndex = 11;
            this.dateExpired.TextColor = System.Drawing.Color.White;
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
            this.btnOk.Location = new System.Drawing.Point(634, 81);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(156, 34);
            this.btnOk.TabIndex = 20;
            this.btnOk.Text = "OK";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelperson
            // 
            this.labelperson.AutoSize = true;
            this.labelperson.ForeColor = System.Drawing.Color.White;
            this.labelperson.Location = new System.Drawing.Point(145, 14);
            this.labelperson.Name = "labelperson";
            this.labelperson.Size = new System.Drawing.Size(0, 13);
            this.labelperson.TabIndex = 21;
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
            this.iconclose.TabIndex = 50;
            this.iconclose.TabStop = false;
            // 
            // SubLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.iconclose);
            this.Controls.Add(this.labelperson);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateExpired);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubLeave";
            this.Size = new System.Drawing.Size(819, 132);
            ((System.ComponentModel.ISupportInitialize)(this.iconclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJTextBox txtDestination;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJTextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private RJCodeAdvance.RJControls.RJDatePicker dateExpired;
        private RJCodeAdvance.RJControls.RJButton btnOk;
        private System.Windows.Forms.Label labelperson;
        private FontAwesome.Sharp.IconPictureBox iconclose;
    }
}
