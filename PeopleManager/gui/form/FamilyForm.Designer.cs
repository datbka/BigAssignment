
namespace PeopleManager.gui.form
{
    partial class FamilyForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FamilyForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSearch = new PeopleManager.gui.customcontroller.CButton();
            this.datagvFamily = new System.Windows.Forms.DataGridView();
            this.IDFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeOwnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbSumFamily = new System.Windows.Forms.ToolStripStatusLabel();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvFamily)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.Controls.Add(this.txtSearch);
            this.panelContainer.Controls.Add(this.btnSearch);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(819, 200);
            this.panelContainer.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(819, 140);
            this.panelMenu.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(449, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.Size = new System.Drawing.Size(241, 31);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.Borderradius = 20;
            this.btnSearch.Bordersize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(697, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.datagvFamily.Location = new System.Drawing.Point(0, 200);
            this.datagvFamily.Name = "datagvFamily";
            this.datagvFamily.RowHeadersVisible = false;
            this.datagvFamily.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagvFamily.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datagvFamily.Size = new System.Drawing.Size(819, 339);
            this.datagvFamily.TabIndex = 1;
            this.datagvFamily.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datagvFamily_RowsAdded);
            this.datagvFamily.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.datagvFamily_RowsRemoved);
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
            this.refreshToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.separateToolStripMenuItem,
            this.changeOwnerToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenu.MenuItemHeight = 25;
            this.contextMenu.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.contextMenu.Size = new System.Drawing.Size(145, 134);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.BackgroundImage")));
            this.refreshToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.refreshToolStripMenuItem.Text = "Làm mới";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // separateToolStripMenuItem
            // 
            this.separateToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("separateToolStripMenuItem.BackgroundImage")));
            this.separateToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.separateToolStripMenuItem.Name = "separateToolStripMenuItem";
            this.separateToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.separateToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.separateToolStripMenuItem.Text = "Tách hộ khẩu";
            this.separateToolStripMenuItem.Click += new System.EventHandler(this.separateToolStripMenuItem_Click);
            // 
            // changeOwnerToolStripMenuItem
            // 
            this.changeOwnerToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeOwnerToolStripMenuItem.BackgroundImage")));
            this.changeOwnerToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeOwnerToolStripMenuItem.Name = "changeOwnerToolStripMenuItem";
            this.changeOwnerToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.changeOwnerToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.changeOwnerToolStripMenuItem.Text = "Đổi chủ hộ";
            this.changeOwnerToolStripMenuItem.Click += new System.EventHandler(this.changeOwnerToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.BackgroundImage")));
            this.removeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.removeToolStripMenuItem.Text = "Xóa";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSumFamily});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbSumFamily
            // 
            this.lbSumFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.lbSumFamily.Name = "lbSumFamily";
            this.lbSumFamily.Size = new System.Drawing.Size(92, 17);
            this.lbSumFamily.Text = "Tổng hộ khẩu: 0";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("detailToolStripMenuItem.BackgroundImage")));
            this.detailToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.detailToolStripMenuItem.Text = "Chi tiết";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // FamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 561);
            this.Controls.Add(this.datagvFamily);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelContainer);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FamilyForm";
            this.Text = "Quản lí hộ khẩu";
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvFamily)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView datagvFamily;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbSumFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private customcontroller.CButton btnSearch;
        private RJCodeAdvance.RJControls.RJDropdownMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem separateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeOwnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
    }
}