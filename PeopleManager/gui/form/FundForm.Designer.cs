
namespace PeopleManager.gui.form
{
    partial class FundForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSearch = new PeopleManager.gui.customcontroller.CButton();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnAdd = new PeopleManager.gui.customcontroller.CButton();
            this.datagvFund = new System.Windows.Forms.DataGridView();
            this.FundName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decipt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.required = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ForFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbSumFund = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvFund)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.Controls.Add(this.btnSearch);
            this.panelContainer.Controls.Add(this.txtSearch);
            this.panelContainer.Controls.Add(this.btnAdd);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(819, 159);
            this.panelContainer.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 54);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(819, 105);
            this.panelMenu.TabIndex = 6;
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
            this.btnSearch.Location = new System.Drawing.Point(663, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(30, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(476, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.Size = new System.Drawing.Size(180, 31);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.Borderradius = 30;
            this.btnAdd.Bordersize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(26, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // datagvFund
            // 
            this.datagvFund.AllowUserToAddRows = false;
            this.datagvFund.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagvFund.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagvFund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvFund.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FundName,
            this.decipt,
            this.value,
            this.expired,
            this.required,
            this.ForFamily,
            this.updated,
            this.id});
            this.datagvFund.ContextMenuStrip = this.contextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvFund.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagvFund.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvFund.Location = new System.Drawing.Point(0, 159);
            this.datagvFund.Name = "datagvFund";
            this.datagvFund.RowHeadersVisible = false;
            this.datagvFund.Size = new System.Drawing.Size(819, 380);
            this.datagvFund.TabIndex = 1;
            this.datagvFund.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datagvFund_RowsAdded);
            this.datagvFund.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.datagvFund_RowsRemoved);
            // 
            // FundName
            // 
            this.FundName.HeaderText = "Tên khoản phí";
            this.FundName.Name = "FundName";
            this.FundName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FundName.Width = 200;
            // 
            // decipt
            // 
            this.decipt.HeaderText = "Mô tả";
            this.decipt.Name = "decipt";
            this.decipt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.decipt.Width = 200;
            // 
            // value
            // 
            this.value.HeaderText = "Phí";
            this.value.Name = "value";
            // 
            // expired
            // 
            this.expired.HeaderText = "Ngày hết hạn";
            this.expired.Name = "expired";
            // 
            // required
            // 
            this.required.HeaderText = "Bắt buộc";
            this.required.Name = "required";
            this.required.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ForFamily
            // 
            this.ForFamily.HeaderText = "Hình thức";
            this.ForFamily.Name = "ForFamily";
            this.ForFamily.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbSumFund});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbSumFund
            // 
            this.lbSumFund.ForeColor = System.Drawing.Color.White;
            this.lbSumFund.Name = "lbSumFund";
            this.lbSumFund.Size = new System.Drawing.Size(106, 17);
            this.lbSumFund.Text = "Tổng số khoản thu";
            // 
            // contextMenu
            // 
            this.contextMenu.IsMainMenu = false;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem});
            this.contextMenu.MenuItemHeight = 25;
            this.contextMenu.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.contextMenu.Size = new System.Drawing.Size(105, 26);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // FundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(819, 561);
            this.Controls.Add(this.datagvFund);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelContainer);
            this.Name = "FundForm";
            this.Text = "Quản lí khoản thu";
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvFund)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private customcontroller.CButton btnAdd;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private customcontroller.CButton btnSearch;
        private System.Windows.Forms.DataGridView datagvFund;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbSumFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn FundName;
        private System.Windows.Forms.DataGridViewTextBoxColumn decipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn required;
        private System.Windows.Forms.DataGridViewTextBoxColumn ForFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private RJCodeAdvance.RJControls.RJDropdownMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
    }
}