
namespace PeopleManager.gui.form
{
    partial class DetailFaimilyContribution
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNotContr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbContr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datagvContr = new System.Windows.Forms.DataGridView();
            this.IDFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNotContr = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvContr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotContr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataNotContr);
            this.panel2.Controls.Add(this.lbNotContr);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 293);
            this.panel2.TabIndex = 3;
            // 
            // lbNotContr
            // 
            this.lbNotContr.AutoSize = true;
            this.lbNotContr.ForeColor = System.Drawing.Color.White;
            this.lbNotContr.Location = new System.Drawing.Point(125, 4);
            this.lbNotContr.Name = "lbNotContr";
            this.lbNotContr.Size = new System.Drawing.Size(44, 13);
            this.lbNotContr.TabIndex = 4;
            this.lbNotContr.Text = "Tổng: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách chưa nộp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagvContr);
            this.panel1.Controls.Add(this.lbContr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 257);
            this.panel1.TabIndex = 2;
            // 
            // lbContr
            // 
            this.lbContr.AutoSize = true;
            this.lbContr.ForeColor = System.Drawing.Color.White;
            this.lbContr.Location = new System.Drawing.Point(114, 9);
            this.lbContr.Name = "lbContr";
            this.lbContr.Size = new System.Drawing.Size(44, 13);
            this.lbContr.TabIndex = 2;
            this.lbContr.Text = "Tổng: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đã nộp";
            // 
            // datagvContr
            // 
            this.datagvContr.AllowUserToAddRows = false;
            this.datagvContr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagvContr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagvContr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvContr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFamily,
            this.Owner,
            this.AmountMember,
            this.Address});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagvContr.DefaultCellStyle = dataGridViewCellStyle4;
            this.datagvContr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagvContr.GridColor = System.Drawing.SystemColors.Control;
            this.datagvContr.Location = new System.Drawing.Point(0, 39);
            this.datagvContr.Name = "datagvContr";
            this.datagvContr.RowHeadersVisible = false;
            this.datagvContr.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagvContr.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datagvContr.Size = new System.Drawing.Size(834, 218);
            this.datagvContr.TabIndex = 3;
            this.datagvContr.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datagvContr_RowsAdded);
            this.datagvContr.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.datagvContr_RowsRemoved);
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
            // dataNotContr
            // 
            this.dataNotContr.AllowUserToAddRows = false;
            this.dataNotContr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNotContr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNotContr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotContr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNotContr.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataNotContr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataNotContr.GridColor = System.Drawing.SystemColors.Control;
            this.dataNotContr.Location = new System.Drawing.Point(0, 34);
            this.dataNotContr.Name = "dataNotContr";
            this.dataNotContr.RowHeadersVisible = false;
            this.dataNotContr.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataNotContr.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataNotContr.Size = new System.Drawing.Size(834, 259);
            this.dataNotContr.TabIndex = 5;
            this.dataNotContr.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataNotContr_RowsAdded);
            this.dataNotContr.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataNotContr_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Hộ khẩu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Chủ hộ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Số thành viên";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // DetailFaimilyContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(834, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailFaimilyContribution";
            this.Text = "DetailFaimilyContribution";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvContr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotContr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNotContr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbContr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataNotContr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView datagvContr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}