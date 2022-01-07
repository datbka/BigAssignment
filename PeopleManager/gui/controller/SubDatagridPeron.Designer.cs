
namespace PeopleManager.gui.controller
{
    partial class SubDatagridPeron
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
            this.datagvPerson = new System.Windows.Forms.DataGridView();
            this.contextMenu = new RJCodeAdvance.RJControls.RJDropdownMenu(this.components);
            this.contributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagvPerson)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagvPerson
            // 
            this.datagvPerson.AllowUserToAddRows = false;
            this.datagvPerson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.datagvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.CMND,
            this.address,
            this.family,
            this.id});
            this.datagvPerson.ContextMenuStrip = this.contextMenu;
            this.datagvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvPerson.Location = new System.Drawing.Point(0, 0);
            this.datagvPerson.Name = "datagvPerson";
            this.datagvPerson.RowHeadersVisible = false;
            this.datagvPerson.Size = new System.Drawing.Size(819, 502);
            this.datagvPerson.TabIndex = 0;
            // 
            // contextMenu
            // 
            this.contextMenu.IsMainMenu = false;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contributeToolStripMenuItem});
            this.contextMenu.MenuItemHeight = 25;
            this.contextMenu.MenuItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(176)))));
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.contextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // contributeToolStripMenuItem
            // 
            this.contributeToolStripMenuItem.Name = "contributeToolStripMenuItem";
            this.contributeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contributeToolStripMenuItem.Text = "Đóng góp";
            this.contributeToolStripMenuItem.Click += new System.EventHandler(this.contributeToolStripMenuItem_Click);
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.Name = "FullName";
            this.FullName.Width = 200;
            // 
            // CMND
            // 
            this.CMND.HeaderText = "số CMND";
            this.CMND.Name = "CMND";
            this.CMND.Width = 200;
            // 
            // address
            // 
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.Width = 300;
            // 
            // family
            // 
            this.family.HeaderText = "Hộ khẩu";
            this.family.Name = "family";
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // SubDatagridPeron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datagvPerson);
            this.Name = "SubDatagridPeron";
            this.Size = new System.Drawing.Size(819, 502);
            ((System.ComponentModel.ISupportInitialize)(this.datagvPerson)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagvPerson;
        private RJCodeAdvance.RJControls.RJDropdownMenu contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contributeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}
