
namespace PeopleManager.gui.form
{
    partial class SubDatagridFamilyContribution
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagvFamily = new System.Windows.Forms.DataGridView();
            this.IDFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.datagvFamily)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagvFamily
            // 
            this.datagvFamily.AllowUserToAddRows = false;
            this.datagvFamily.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagvFamily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagvFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvFamily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFamily,
            this.Owner,
            this.AmountMember,
            this.Address});
            this.datagvFamily.ContextMenuStrip = this.contextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvFamily.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagvFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvFamily.GridColor = System.Drawing.SystemColors.Control;
            this.datagvFamily.Location = new System.Drawing.Point(0, 0);
            this.datagvFamily.Name = "datagvFamily";
            this.datagvFamily.RowHeadersVisible = false;
            this.datagvFamily.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagvFamily.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datagvFamily.Size = new System.Drawing.Size(819, 502);
            this.datagvFamily.TabIndex = 2;
            // 
            // IDFamily
            // 
            this.IDFamily.HeaderText = "Hộ khẩu";
            this.IDFamily.Name = "IDFamily";
            this.IDFamily.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Chủ hộ";
            this.Owner.Name = "Owner";
            this.Owner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Owner.Width = 250;
            // 
            // AmountMember
            // 
            this.AmountMember.HeaderText = "Số thành viên";
            this.AmountMember.Name = "AmountMember";
            this.AmountMember.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 300;
            // 
            // contextMenu
            // 
            this.contextMenu.IsMainMenu = false;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.contextMenu.MenuItemHeight = 25;
            this.contextMenu.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.contextMenu.Size = new System.Drawing.Size(128, 26);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addToolStripMenuItem.Text = "Đóng góp";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // SubDatagridFamilyContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datagvFamily);
            this.Name = "SubDatagridFamilyContribution";
            this.Size = new System.Drawing.Size(819, 502);
            ((System.ComponentModel.ISupportInitialize)(this.datagvFamily)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagvFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private RJCodeAdvance.RJControls.RJDropdownMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}
