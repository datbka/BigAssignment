using PeopleManager.objectclass;
using PeopleManager.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.gui.controller;
using PeopleManager.gui.customform;
using PeopleManager.service.DAO;

namespace PeopleManager.gui.form
{
    public partial class LeaveForm : Form
    {
        public LeaveForm()
        {
            InitializeComponent();
            HideControl();
            datagvPerson.CellValueChanged += DatagvPerson_CellValueChanged;
            datagvPerson.SortCompare += DatagvPerson_SortCompare;
            btnStay_Click(this, new EventArgs());
        }

        private void DatagvPerson_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == DoB.Index || e.Column.Index == expired.Index)
            {
                if (e.CellValue1 != null && e.CellValue2 != null)
                {
                    e.SortResult = DateTime.Parse(e.CellValue1.ToString()).CompareTo(DateTime.Parse(e.CellValue2.ToString()));
                    e.Handled = true;//pass by the default sorting
                }
            }
            else return;
        }

        private void DatagvPerson_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == status.Index)
            {
                if (datagvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == Citizen.Dstatus[Citizen.Estatus.NEW])
                {
                    datagvPerson.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;

                }
                if (datagvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == Citizen.Dstatus[Citizen.Estatus.DIE])
                {
                    datagvPerson.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;

                }
                if (datagvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == Citizen.Dstatus[Citizen.Estatus.STAY])
                {
                    datagvPerson.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Blue;

                }
                if (datagvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == Citizen.Dstatus[Citizen.Estatus.LEAVE])
                {
                    datagvPerson.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Orange;

                }
                if (datagvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == Citizen.Dstatus[Citizen.Estatus.EXPIRED_LEAVE])
                {
                    datagvPerson.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkOrange;

                }
                if (datagvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == Citizen.Dstatus[Citizen.Estatus.EXPIRED_STAY])
                {
                    datagvPerson.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkBlue;

                }
            }
        }

        UserControl subcontrol;
        bool isdeclareabsent;
        bool IsDeclareAbsent
        {
            get { return isdeclareabsent; }
            set
            {
                isdeclareabsent = value;
                if (isdeclareabsent)
                {
                    declareLeaveToolStripMenuItem.Text = "Khai báo tạm vắng";
                    this.destination.Visible = false;
                    this.note.Visible = false;
                    this.expired.Visible = false;
                    this.declare_updated.Visible = false;
                }
                else
                {
                    declareLeaveToolStripMenuItem.Text = "Khai báo trở về";
                    this.destination.Visible = true;
                    this.note.Visible = true;
                    this.expired.Visible = true;
                    this.declare_updated.Visible = false;
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Texts)) return;
            datagvPerson.ClearSelection();
            int rows = datagvPerson.RowCount;
            int cols = datagvPerson.ColumnCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                bool contain = false;
                for (int k = 0; k < cols; k++)
                {

                    if (datagvPerson.Rows[i].Cells[k].Value != null)
                    {
                        if (datagvPerson.Rows[i].Cells[k].Value.ToString().Contains(txtSearch.Texts))
                        {
                            datagvPerson.Rows[i].Cells[k].Selected = true;
                            contain = true;
                        }
                    }

                }
                if (!contain) datagvPerson.Rows.RemoveAt(i);
            }

        }
        public void LoadData(string query)
        {
            bool Ischeck = false;
            Start:
            datagvPerson.Rows.Clear();
            var sql = new SqlService();
            var table = sql.GetTable(query);

            int max = table.Rows.Count;
            int maxcol = table.Columns.Count < datagvPerson.ColumnCount ? table.Columns.Count : datagvPerson.ColumnCount;
            bool ishaveexpired = false;
            if (maxcol > 18)
            {
                foreach (DataRow item in table.Rows)
                {
                    if (Convert.ToDateTime(item[18]) < DateTime.Now)
                    {
                        CitizenDAO citizendao = new CitizenDAO();
                        citizendao.UpdateStatus(item[14].ToString(), Citizen.Dstatus[Citizen.Estatus.EXPIRED_LEAVE]);
                        ishaveexpired = true;
                    }
                }
            }
            Ischeck = true;
            if(!Ischeck)
            if (ishaveexpired) goto Start;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                datagvPerson.Rows.Add("");
                for (int k = 0; k < maxcol; k++)
                {
                    if (k == gender.Index)
                    {
                        datagvPerson.Rows[i].Cells[k].Value = Convert.ToBoolean(row[k]) == true ? "Nam" : "Nữ";
                    }
                    else if (k == DoB.Index)
                    {
                        datagvPerson.Rows[i].Cells[k].Value = Convert.ToDateTime(row[k]).ToShortDateString();
                    }
                    else if(k == expired.Index)
                    {
                       var timeexpired=Convert.ToDateTime(row[k + 1]);
                       
                        datagvPerson.Rows[i].Cells[k].Value = timeexpired.ToShortDateString();
                    }
                    else if(k >= destination.Index)
                    {
                        datagvPerson.Rows[i].Cells[k].Value = row[k+1];
                    }
                    else
                        datagvPerson.Rows[i].Cells[k].Value = row[k];
                }
            }
        }
        void HideControl()
        {
            panelMenu.Visible = false;
            panelContainer.Size = new Size(819, 60);
        }
        void ShowControl(UserControl control)
        {
            int MenuHeight = 60;
            panelMenu.Visible = true;
            if (this.subcontrol != null)
            {
                this.subcontrol.Disposed -= Control_Disposed;
                this.subcontrol.Dispose();
                this.subcontrol = null;
            }
            this.subcontrol = control;
            panelMenu.Size = new Size(819, subcontrol.Height);
            panelContainer.Size = new Size(819, MenuHeight + subcontrol.Height);

            control.Disposed += Control_Disposed;


            subcontrol.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(subcontrol);
            panelMenu.Tag = subcontrol;
            subcontrol.BringToFront();
            subcontrol.Show();

        }
        private void Control_Disposed(object sender, EventArgs e)
        {

            HideControl();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isdeclareabsent) LoadStay();
            else LoadAbsent();
        }
        string GetContentCell(int row,int col)
        {
            if (datagvPerson.Rows[row].Cells[col].Value == null) return "";
            else return datagvPerson.Rows[row].Cells[col].Value.ToString();
        }
        private void declareLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvPerson.CurrentCell == null) return;
            int index = datagvPerson.CurrentCell.RowIndex;
            if (isdeclareabsent)
            {
               
                Citizen citizen = new Citizen(GetContentCell(index, FullName.Index), Convert.ToDateTime(GetContentCell(index, DoB.Index)), GetContentCell(index, gender.Index).ToLower() == "nam" ? Citizen.Gender.MALE : Citizen.Gender.FEMALE,
                                                GetContentCell(index, nickname.Index), GetContentCell(index, bornplace.Index), GetContentCell(index, ethnic.Index), GetContentCell(index, Job.Index),
                                                    GetContentCell(index, jobplace.Index), GetContentCell(index, CMND.Index), GetContentCell(index, Address.Index), GetContentCell(index, family.Index),
                                                    GetContentCell(index, relationshipowner.Index), GetContentCell(index, status.Index));
                citizen.Iddatabase = GetContentCell(index, id.Index);
                ShowControl(new SubLeave(this, citizen));
            }
            else
            {
                MsgNotifyBox msg = new MsgNotifyBox(this, $"Nhân khẩu đã quay trở về?", Color.Red, FontAwesome.Sharp.IconChar.Question, true);
                msg.ShowDialog(this);
                if(msg.DialogResult == DialogResult.OK)
                {
                    LeaveDAO leaveDao = new LeaveDAO();
                    if (leaveDao.Remove(GetContentCell(index, id.Index), GetContentCell(index, idabsent.Index)))
                    {
                        MsgNotifyBox msgbox = new MsgNotifyBox(this, "Xóa tạm vắng thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                        LoadAbsent();
                    }
                    else
                    {
                        MsgNotifyBox msgbox = new MsgNotifyBox(this, "Xóa tạm vắng thất bại!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                    }
                }
            }
        }
        void ClickedButton(Button btn)
        {
            btn.BackColor = Color.LightSkyBlue;
            btn.ForeColor = Color.Black;
        }
        void DefaultButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(36, 71, 176);
            btn.ForeColor = Color.White;
        }
        private void btnStay_Click(object sender, EventArgs e)
        {
            if(btnStay.BackColor != Color.LightSkyBlue)
            {
                IsDeclareAbsent = true;
                DefaultButton(btnLeave);
                ClickedButton(btnStay);
                LoadStay();
            }
        }
        void LoadStay()
        {
            LoadData($"select * from Citizen where status =N'{Citizen.Dstatus[Citizen.Estatus.ALIVE]}' or status =N'{Citizen.Dstatus[Citizen.Estatus.NEW]}' ");
        }
        void LoadAbsent()
        {
            LoadData($"select * from Citizen  left join Leave on Citizen.id = Leave.idcitizen where Leave.id >0 ");
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (btnLeave.BackColor != Color.LightSkyBlue)
            {
                IsDeclareAbsent = false;
                DefaultButton(btnStay);
                ClickedButton(btnLeave);
                LoadAbsent();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewDatagvPersonForm viewform = new ViewDatagvPersonForm();
            viewform.ShowDialog(this);
            if (viewform.DialogResult == DialogResult.OK)
            {
                this.FullName.Visible = viewform.ckName.Checked;
                this.nickname.Visible = viewform.ckNickname.Checked;
                this.gender.Visible = viewform.ckGender.Checked;
                this.DoB.Visible = viewform.ckGender.Checked;
                this.CMND.Visible = viewform.ckCMND.Checked;
                this.bornplace.Visible = viewform.ckBornplace.Checked;
                this.ethnic.Visible = viewform.ckEthnic.Checked;
                this.Job.Visible = viewform.ckJob.Checked;
                this.jobplace.Visible = viewform.ckJobplace.Checked;
                this.family.Visible = viewform.ckFamily.Checked;
                this.status.Visible = viewform.ckStatus.Checked;
                this.relationshipowner.Visible = viewform.ckRelationshipowner.Checked;
                this.Address.Visible = viewform.ckAddress.Checked;

            }
            viewform.Dispose();
        }
    }
}
