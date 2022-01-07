
namespace PeopleManager.gui.controller
{
    partial class SubItemChangeOwnerForm
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
            this.txtNewRelationship = new RJCodeAdvance.RJControls.RJTextBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewRelationship
            // 
            this.txtNewRelationship.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewRelationship.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewRelationship.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewRelationship.BorderRadius = 10;
            this.txtNewRelationship.BorderSize = 2;
            this.txtNewRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewRelationship.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewRelationship.Location = new System.Drawing.Point(549, 11);
            this.txtNewRelationship.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewRelationship.Multiline = false;
            this.txtNewRelationship.Name = "txtNewRelationship";
            this.txtNewRelationship.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewRelationship.PasswordChar = false;
            this.txtNewRelationship.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewRelationship.PlaceholderText = "";
            this.txtNewRelationship.Size = new System.Drawing.Size(192, 31);
            this.txtNewRelationship.TabIndex = 54;
            this.txtNewRelationship.Texts = "";
            this.txtNewRelationship.UnderlinedStyle = false;
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.ForeColor = System.Drawing.Color.White;
            this.lbContent.Location = new System.Drawing.Point(9, 18);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(221, 13);
            this.lbContent.TabIndex = 53;
            this.lbContent.Text = "Cập nhật quan hệ chủ hộ mới cho thành viên";
            // 
            // SubItemChangeOwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.txtNewRelationship);
            this.Controls.Add(this.lbContent);
            this.Name = "SubItemChangeOwnerForm";
            this.Size = new System.Drawing.Size(780, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbContent;
        public RJCodeAdvance.RJControls.RJTextBox txtNewRelationship;
    }
}
