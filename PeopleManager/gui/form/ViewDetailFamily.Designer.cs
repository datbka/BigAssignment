
namespace PeopleManager.gui.form
{
    partial class ViewDetailFamily
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDetailFamily));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSummember = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagvPerson = new System.Windows.Forms.DataGridView();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSummember);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOwner);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 50);
            this.panel1.TabIndex = 0;
            // 
            // txtSummember
            // 
            this.txtSummember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.txtSummember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSummember.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSummember.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummember.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSummember.Location = new System.Drawing.Point(616, 17);
            this.txtSummember.Multiline = true;
            this.txtSummember.Name = "txtSummember";
            this.txtSummember.ReadOnly = true;
            this.txtSummember.Size = new System.Drawing.Size(226, 22);
            this.txtSummember.TabIndex = 5;
            this.txtSummember.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(505, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số thành viên: ";
            // 
            // txtOwner
            // 
            this.txtOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.txtOwner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOwner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOwner.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwner.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtOwner.Location = new System.Drawing.Point(73, 18);
            this.txtOwner.Multiline = true;
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(226, 21);
            this.txtOwner.TabIndex = 3;
            this.txtOwner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chủ hộ: ";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagvPerson.Location = new System.Drawing.Point(0, 50);
            this.datagvPerson.Name = "datagvPerson";
            this.datagvPerson.RowHeadersVisible = false;
            this.datagvPerson.Size = new System.Drawing.Size(936, 485);
            this.datagvPerson.TabIndex = 4;
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
            // ViewDetailFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(936, 535);
            this.Controls.Add(this.datagvPerson);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewDetailFamily";
            this.Text = "Chi tiết hộ khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagvPerson;
        private System.Windows.Forms.TextBox txtSummember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label label1;
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