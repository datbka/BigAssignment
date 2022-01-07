
namespace PeopleManager.gui.form
{
    partial class PersonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnFilter = new PeopleManager.gui.customcontroller.CButton();
            this.btnView = new PeopleManager.gui.customcontroller.CButton();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSearch = new PeopleManager.gui.customcontroller.CButton();
            this.btnAdd = new PeopleManager.gui.customcontroller.CButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lbSumPeople = new System.Windows.Forms.ToolStripStatusLabel();
            this.datagvPerson = new System.Windows.Forms.DataGridView();
            this.MenuDatagv = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bornplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ethnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationshipowner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvPerson)).BeginInit();
            this.MenuDatagv.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContainer.Controls.Add(this.btnFilter);
            this.panelContainer.Controls.Add(this.btnView);
            this.panelContainer.Controls.Add(this.txtSearch);
            this.panelContainer.Controls.Add(this.btnSearch);
            this.panelContainer.Controls.Add(this.btnAdd);
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(819, 210);
            this.panelContainer.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnFilter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFilter.Borderradius = 20;
            this.btnFilter.Bordersize = 0;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFilter.IconColor = System.Drawing.Color.White;
            this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilter.IconSize = 25;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.Location = new System.Drawing.Point(639, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnFilter.Size = new System.Drawing.Size(61, 30);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnView.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnView.Borderradius = 20;
            this.btnView.Bordersize = 0;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnView.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnView.IconColor = System.Drawing.Color.White;
            this.btnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnView.IconSize = 25;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.Location = new System.Drawing.Point(706, 12);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnView.Size = new System.Drawing.Size(73, 30);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "Hiển thị";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(344, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.Size = new System.Drawing.Size(235, 31);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(586, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.Borderradius = 20;
            this.btnAdd.Bordersize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(24, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 55);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(819, 155);
            this.panelMenu.TabIndex = 0;
            // 
            // lbSumPeople
            // 
            this.lbSumPeople.ForeColor = System.Drawing.Color.White;
            this.lbSumPeople.Name = "lbSumPeople";
            this.lbSumPeople.Size = new System.Drawing.Size(105, 17);
            this.lbSumPeople.Text = "Tổng nhân khẩu: 0";
            // 
            // datagvPerson
            // 
            this.datagvPerson.AllowUserToAddRows = false;
            this.datagvPerson.AllowUserToResizeRows = false;
            this.datagvPerson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.nickname,
            this.gender,
            this.CMND,
            this.DoB,
            this.bornplace,
            this.ethnic,
            this.Address,
            this.Job,
            this.jobplace,
            this.family,
            this.relationshipowner,
            this.status,
            this.updated,
            this.id});
            this.datagvPerson.ContextMenuStrip = this.MenuDatagv;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvPerson.Location = new System.Drawing.Point(0, 210);
            this.datagvPerson.Name = "datagvPerson";
            this.datagvPerson.RowHeadersVisible = false;
            this.datagvPerson.Size = new System.Drawing.Size(819, 329);
            this.datagvPerson.TabIndex = 2;
            this.datagvPerson.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datagvPerson_RowsAdded);
            this.datagvPerson.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.datagvPerson_RowsRemoved);
            // 
            // MenuDatagv
            // 
            this.MenuDatagv.IsMainMenu = false;
            this.MenuDatagv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.detailToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.MenuDatagv.MenuItemHeight = 25;
            this.MenuDatagv.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.MenuDatagv.Name = "MenuDatagv";
            this.MenuDatagv.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.MenuDatagv.Size = new System.Drawing.Size(123, 108);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.BackgroundImage")));
            this.refreshToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.refreshToolStripMenuItem.Text = "Làm mới";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("detailToolStripMenuItem.BackgroundImage")));
            this.detailToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.detailToolStripMenuItem.Text = "Chi tiết";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.BackgroundImage")));
            this.updateToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.updateToolStripMenuItem.Text = "Cập nhật";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.BackgroundImage")));
            this.removeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.removeToolStripMenuItem.Text = "Xóa";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSumPeople});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(819, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.Name = "FullName";
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 200;
            // 
            // nickname
            // 
            this.nickname.HeaderText = "Bí danh";
            this.nickname.Name = "nickname";
            this.nickname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gender.Width = 50;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "Số CMND";
            this.CMND.Name = "CMND";
            this.CMND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DoB
            // 
            this.DoB.HeaderText = "Ngày sinh";
            this.DoB.Name = "DoB";
            // 
            // bornplace
            // 
            this.bornplace.HeaderText = "Nơi Sinh";
            this.bornplace.Name = "bornplace";
            this.bornplace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ethnic
            // 
            this.ethnic.HeaderText = "Dân tộc";
            this.ethnic.Name = "ethnic";
            this.ethnic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            this.Address.HeaderText = "Nơi ở";
            this.Address.Name = "Address";
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 200;
            // 
            // Job
            // 
            this.Job.HeaderText = "Nghề nghiệp";
            this.Job.Name = "Job";
            this.Job.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jobplace
            // 
            this.jobplace.HeaderText = "Nơi làm việc";
            this.jobplace.Name = "jobplace";
            this.jobplace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.jobplace.Width = 150;
            // 
            // family
            // 
            this.family.HeaderText = "Hộ khẩu";
            this.family.Name = "family";
            this.family.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // relationshipowner
            // 
            this.relationshipowner.HeaderText = "Quan hệ chủ hộ";
            this.relationshipowner.Name = "relationshipowner";
            this.relationshipowner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // status
            // 
            this.status.HeaderText = "Trạng thái";
            this.status.Name = "status";
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // updated
            // 
            this.updated.HeaderText = "Updated";
            this.updated.Name = "updated";
            this.updated.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(819, 561);
            this.Controls.Add(this.datagvPerson);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelContainer);
            this.Name = "PersonForm";
            this.Text = "Quản lí nhân khẩu";
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvPerson)).EndInit();
            this.MenuDatagv.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView datagvPerson;
        private System.Windows.Forms.Panel panelMenu;
        private customcontroller.CButton btnAdd;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJDropdownMenu MenuDatagv;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private customcontroller.CButton btnSearch;
        private customcontroller.CButton btnView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbSumPeople;
        private customcontroller.CButton btnFilter;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoB;
        private System.Windows.Forms.DataGridViewTextBoxColumn bornplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ethnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationshipowner;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}