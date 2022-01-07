
namespace PeopleManager.gui.form
{
    partial class ContributionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbListFund = new RJCodeAdvance.RJControls.RJComboBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbListFund);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 59);
            this.panel1.TabIndex = 0;
            // 
            // cbListFund
            // 
            this.cbListFund.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbListFund.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbListFund.BorderSize = 1;
            this.cbListFund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbListFund.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbListFund.ForeColor = System.Drawing.Color.DimGray;
            this.cbListFund.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbListFund.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbListFund.ListTextColor = System.Drawing.Color.DimGray;
            this.cbListFund.Location = new System.Drawing.Point(57, 12);
            this.cbListFund.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbListFund.Name = "cbListFund";
            this.cbListFund.Padding = new System.Windows.Forms.Padding(1);
            this.cbListFund.Size = new System.Drawing.Size(407, 30);
            this.cbListFund.TabIndex = 1;
            this.cbListFund.Texts = "Chọn khoản thu";
            this.cbListFund.OnSelectedIndexChanged += new System.EventHandler(this.cbListFund_OnSelectedIndexChanged);
            // 
            // panelData
            // 
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 59);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(819, 502);
            this.panelData.TabIndex = 1;
            // 
            // ContributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(819, 561);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panel1);
            this.Name = "ContributionForm";
            this.Text = "ContributionForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJComboBox cbListFund;
        private System.Windows.Forms.Panel panelData;
    }
}