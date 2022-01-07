using PeopleManager.gui.customform;
using PeopleManager.objectclass;
using PeopleManager.service;
using PeopleManager.service.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleManager.gui.form
{
    public partial class DeclareDeadForm : Form
    {
        public DeclareDeadForm()
        {
            InitializeComponent();
            datagvPerson.CellValueChanged += DatagvPerson_CellValueChanged;
            datagvPerson.SortCompare += DatagvPerson_SortCompare;
            LoadData();
        }


        private void DatagvPerson_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == DoB.Index)
            {
                if (e.CellValue1 != null && e.CellValue2 != null)
                {
                    e.SortResult = DateTime.Parse(e.CellValue1.ToString()).CompareTo(DateTime.Parse(e.CellValue2.ToString()));
                    e.Handled = true;//pass by the default sorting
                }
            }
            else return;
        }

        public void LoadData()
        {
            datagvPerson.Rows.Clear();
            var sql = new SqlService();
            var table = sql.GetTable("select * from Citizen");

            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
               /* if (string.Compare(row[status.Index].ToString(), Citizen.Dstatus[Citizen.Estatus.NEW]) != 0 &&
                            string.Compare(row[status.Index].ToString(), Citizen.Dstatus[Citizen.Estatus.ALIVE]) != 0 &&
                            string.Compare(row[status.Index].ToString(), Citizen.Dstatus[Citizen.Estatus.LEAVE]) != 0)
                {
                    continue;
                }*/
                datagvPerson.Rows.Add("");
                for (int k = 0; k < datagvPerson.Columns.Count; k++)
                {
                    
                    if (k == gender.Index)
                    {
                        datagvPerson.Rows[i].Cells[k].Value = Convert.ToBoolean(row[k]) == true ? "Nam" : "Nữ";
                    }
                    else if (k == DoB.Index)
                    {
                        datagvPerson.Rows[i].Cells[k].Value = Convert.ToDateTime(row[k]).ToShortDateString();
                    }
                   
                    else
                        datagvPerson.Rows[i].Cells[k].Value = row[k];
                }
            }
            for (int i = max - 1; i >= 0; i--)
            {
                if (string.Compare(datagvPerson.Rows[i].Cells[status.Index].Value.ToString(), Citizen.Dstatus[Citizen.Estatus.NEW]) != 0 &&
                            string.Compare(datagvPerson.Rows[i].Cells[status.Index].Value.ToString(), Citizen.Dstatus[Citizen.Estatus.ALIVE]) != 0 &&
                            string.Compare(datagvPerson.Rows[i].Cells[status.Index].Value.ToString(), Citizen.Dstatus[Citizen.Estatus.LEAVE]) != 0)
                {
                    datagvPerson.Rows.RemoveAt(i);

                }
            }
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        string GetContentCell(int row,int col)
        {
            if (datagvPerson.Rows[row].Cells[col].Value == null) return "";
            else return datagvPerson.Rows[row].Cells[col].Value.ToString();
        }
        private void declareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvPerson.CurrentCell == null) return;
            int index = datagvPerson.CurrentCell.RowIndex;
            FamilyDAO familyDAO = new FamilyDAO();
            if(string.Compare(GetContentCell(index,relationshipowner.Index).ToLower(),"chủ hộ") == 0)
            {
                int member = familyDAO.GetListMembers(GetContentCell(index, family.Index)).Count();
                if (familyDAO.GetListMembers(GetContentCell(index, family.Index)).Count() > 0)
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(this, "Không thể khai tử cho chủ hộ này, hãy đổi chủ hộ trước!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                    return;
                }
            }
            string name = GetContentCell(index, FullName.Index);
            CitizenDAO citizenDao = new CitizenDAO();
            MsgNotifyBox msg = new MsgNotifyBox(this, $"Bạn có muốn khai tử cho {name} ?", Color.Red, FontAwesome.Sharp.IconChar.Question, true);
            msg.ShowDialog(this);
            if (msg.DialogResult == DialogResult.OK)
            {
                if (citizenDao.UpdateStatus(GetContentCell(index, id.Index), Citizen.Dstatus[Citizen.Estatus.DIE]))
                {
                    citizenDao.Updated(GetContentCell(index, id.Index));
                    MsgNotifyBox msgbox = new MsgNotifyBox(this, "Khai tử thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                    LoadData();

                }
                else
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(this, "Khai tử thất bại!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                }
            }
        }
    }
}
