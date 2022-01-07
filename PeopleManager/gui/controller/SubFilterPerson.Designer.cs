
namespace PeopleManager.gui.controller
{
    partial class SubFilterPerson
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
            this.cbFilterValue = new RJCodeAdvance.RJControls.RJComboBox();
            this.btnOK = new RJCodeAdvance.RJControls.RJButton();
            this.cbFilter = new RJCodeAdvance.RJControls.RJComboBox();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilterValue
            // 
            this.cbFilterValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFilterValue.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbFilterValue.BorderSize = 1;
            this.cbFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbFilterValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbFilterValue.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbFilterValue.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbFilterValue.ListTextColor = System.Drawing.Color.DimGray;
            this.cbFilterValue.Location = new System.Drawing.Point(343, 18);
            this.cbFilterValue.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFilterValue.Name = "cbFilterValue";
            this.cbFilterValue.Padding = new System.Windows.Forms.Padding(1);
            this.cbFilterValue.Size = new System.Drawing.Size(200, 30);
            this.cbFilterValue.TabIndex = 1;
            this.cbFilterValue.Texts = "";
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
            this.btnOK.Location = new System.Drawing.Point(622, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbFilter.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbFilter.BorderSize = 1;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbFilter.Items.AddRange(new object[] {
            "Giới tính",
            "Dân tộc",
            "Trạng thái"});
            this.cbFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbFilter.ListTextColor = System.Drawing.Color.Black;
            this.cbFilter.Location = new System.Drawing.Point(45, 18);
            this.cbFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Padding = new System.Windows.Forms.Padding(1);
            this.cbFilter.Size = new System.Drawing.Size(200, 30);
            this.cbFilter.TabIndex = 4;
            this.cbFilter.Texts = "Lọc theo cột";
            this.cbFilter.OnSelectedIndexChanged += new System.EventHandler(this.cbFilter_OnSelectedIndexChanged);
            // 
            // iconClose
            // 
            this.iconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.iconClose.ForeColor = System.Drawing.Color.Maroon;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.iconClose.IconColor = System.Drawing.Color.Maroon;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.IconSize = 25;
            this.iconClose.Location = new System.Drawing.Point(791, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(25, 25);
            this.iconClose.TabIndex = 5;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // SubFilterPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.iconClose);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbFilterValue);
            this.Name = "SubFilterPerson";
            this.Size = new System.Drawing.Size(819, 70);
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RJCodeAdvance.RJControls.RJComboBox cbFilterValue;
        private RJCodeAdvance.RJControls.RJButton btnOK;
        private RJCodeAdvance.RJControls.RJComboBox cbFilter;
        private FontAwesome.Sharp.IconPictureBox iconClose;
    }
}
