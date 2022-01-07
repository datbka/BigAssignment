
namespace PeopleManager.gui.form
{
    partial class LeaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.datagvPerson = new System.Windows.Forms.DataGridView();
            this.btnStay = new PeopleManager.gui.customcontroller.CButton();
            this.btnLeave = new PeopleManager.gui.customcontroller.CButton();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnSearch = new PeopleManager.gui.customcontroller.CButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.contextMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declareLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declare_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idabsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new PeopleManager.gui.customcontroller.CButton();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvPerson)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.btnView);
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.Controls.Add(this.txtSearch);
            this.panelContainer.Controls.Add(this.btnSearch);
            this.panelContainer.Controls.Add(this.btnLeave);
            this.panelContainer.Controls.Add(this.btnStay);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(819, 120);
            this.panelContainer.TabIndex = 0;
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
            this.id,
            this.destination,
            this.note,
            this.expired,
            this.declare_updated,
            this.idabsent});
            this.datagvPerson.ContextMenuStrip = this.contextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvPerson.Location = new System.Drawing.Point(0, 120);
            this.datagvPerson.Name = "datagvPerson";
            this.datagvPerson.RowHeadersVisible = false;
            this.datagvPerson.Size = new System.Drawing.Size(819, 441);
            this.datagvPerson.TabIndex = 3;
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.btnStay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStay.Borderradius = 20;
            this.btnStay.Bordersize = 0;
            this.btnStay.FlatAppearance.BorderSize = 0;
            this.btnStay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStay.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnStay.ForeColor = System.Drawing.Color.White;
            this.btnStay.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnStay.IconColor = System.Drawing.Color.White;
            this.btnStay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStay.IconSize = 25;
            this.btnStay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStay.Location = new System.Drawing.Point(29, 12);
            this.btnStay.Name = "btnStay";
            this.btnStay.Padding = new System.Windows.Forms.Padding(0, 3, 5, 0);
            this.btnStay.Size = new System.Drawing.Size(100, 35);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Đang ở";
            this.btnStay.UseVisualStyleBackColor = false;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.btnLeave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLeave.Borderradius = 20;
            this.btnLeave.Bordersize = 0;
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnLeave.ForeColor = System.Drawing.Color.White;
            this.btnLeave.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnLeave.IconColor = System.Drawing.Color.White;
            this.btnLeave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeave.IconSize = 25;
            this.btnLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeave.Location = new System.Drawing.Point(165, 12);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Padding = new System.Windows.Forms.Padding(0, 6, 5, 0);
            this.btnLeave.Size = new System.Drawing.Size(100, 35);
            this.btnLeave.TabIndex = 2;
            this.btnLeave.Text = "Tạm vắng";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(408, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.Size = new System.Drawing.Size(235, 31);
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
            this.btnSearch.Location = new System.Drawing.Point(650, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(819, 60);
            this.panelMenu.TabIndex = 8;
            // 
            // contextMenu
            // 
            this.contextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenu.IsMainMenu = false;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.declareLeaveToolStripMenuItem});
            this.contextMenu.MenuItemHeight = 25;
            this.contextMenu.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.contextMenu.Size = new System.Drawing.Size(174, 56);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshToolStripMenuItem.BackgroundImage")));
            this.refreshToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.refreshToolStripMenuItem.Text = "Làm mới";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // declareLeaveToolStripMenuItem
            // 
            this.declareLeaveToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("declareLeaveToolStripMenuItem.BackgroundImage")));
            this.declareLeaveToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.declareLeaveToolStripMenuItem.Name = "declareLeaveToolStripMenuItem";
            this.declareLeaveToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.declareLeaveToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.declareLeaveToolStripMenuItem.Text = "Khai báo tạm vắng";
            this.declareLeaveToolStripMenuItem.Click += new System.EventHandler(this.declareLeaveToolStripMenuItem_Click);
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
            // destination
            // 
            this.destination.HeaderText = "Nơi đến";
            this.destination.Name = "destination";
            this.destination.Visible = false;
            // 
            // note
            // 
            this.note.HeaderText = "Ghi chú";
            this.note.Name = "note";
            this.note.Visible = false;
            // 
            // expired
            // 
            this.expired.HeaderText = "Thời gian về";
            this.expired.Name = "expired";
            this.expired.Visible = false;
            // 
            // declare_updated
            // 
            this.declare_updated.HeaderText = "Cập nhật";
            this.declare_updated.Name = "declare_updated";
            // 
            // idabsent
            // 
            this.idabsent.HeaderText = "ID Tạm vắng";
            this.idabsent.Name = "idabsent";
            this.idabsent.Visible = false;
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
            this.btnView.Location = new System.Drawing.Point(717, 17);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnView.Size = new System.Drawing.Size(73, 30);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "Hiển thị";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // LeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(819, 561);
            this.Controls.Add(this.datagvPerson);
            this.Controls.Add(this.panelContainer);
            this.Name = "LeaveForm";
            this.Text = "LeaveForm";
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvPerson)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView datagvPerson;
        private customcontroller.CButton btnLeave;
        private customcontroller.CButton btnStay;
        private System.Windows.Forms.Panel panelMenu;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private customcontroller.CButton btnSearch;
        private RJCodeAdvance.RJControls.RJDropdownMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declareLeaveToolStripMenuItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn declare_updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn idabsent;
        private customcontroller.CButton btnView;
    }
}