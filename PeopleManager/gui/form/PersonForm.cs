using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.gui.customcontroller;
using PeopleManager.gui.controller;
using System.Data.SqlClient;
using PeopleManager.service;
using PeopleManager.objectclass;
using PeopleManager.gui.customform;

namespace PeopleManager.gui.form
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
            HideControl();
            datagvPerson.CellValueChanged += DatagvPerson_CellValueChanged;
            LoadData();
            datagvPerson.SortCompare += DatagvPerson_SortCompare;
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
          
        }

        UserControl subcontrol;
        private void DatagvPerson_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           if(e.ColumnIndex == status.Index)
            {
                if(datagvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == Citizen.Dstatus[Citizen.Estatus.NEW])
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

        public  void LoadData()
        {
            datagvPerson.Rows.Clear();
            var sql = new SqlService();
            var table = sql.GetTable("select * from Citizen");
         
            int max = table.Rows.Count;
            for(int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                datagvPerson.Rows.Add("");
                for(int k = 0; k < datagvPerson.Columns.Count; k++)
                {
                    if(k == gender.Index)
                    {
                        datagvPerson.Rows[i].Cells[k].Value =Convert.ToBoolean(row[k]) == true ? "Nam": "Nữ";
                    }
                    else if(k == DoB.Index)
                    {
                        datagvPerson.Rows[i].Cells[k].Value = Convert.ToDateTime(row[k]).ToShortDateString();
                    }
                   
                    else
                    datagvPerson.Rows[i].Cells[k].Value = row[k];
                }
            }
        }
        public List<string> GetListFilter(string namecol)
        {
            List<string> res = new List<string>();
            int max = datagvPerson.RowCount;
            for(int i = 0; i < max; i++)
            {
                if(datagvPerson.Rows[i].Cells[namecol].Value != null)
                {
                    if (!res.Contains(datagvPerson.Rows[i].Cells[namecol].Value.ToString())) res.Add(datagvPerson.Rows[i].Cells[namecol].Value.ToString());
                }
            }
            return res;
        }
      public void FilterDatagv(string namecol,string value)
        {
            int max = datagvPerson.RowCount;
            int col = 3;
            switch (namecol)
            {
                case ("gender"):
                    col = gender.Index;
                    break;
                case ("ethnic"):
                    col = ethnic.Index;
                    break;
                case ("status"):
                    col = status.Index;
                    break;
            }
            for(int i = max-1; i >=0 ; i--)
            {
                if(string.Compare( datagvPerson.Rows[i].Cells[col].Value.ToString(), value) !=0)
                {
                    datagvPerson.Rows.RemoveAt(i);
                    
                }
            }
        }
       
     
        void HideControl()
        {
            panelMenu.Visible = false;
            panelContainer.Size = new Size(819, 55);
        }
        void ShowControl(UserControl control, int MenuHeight=260)
        {
            panelMenu.Visible = true;
            if (this.subcontrol != null)
            {
                this.subcontrol.Disposed -= Control_Disposed;
                this.subcontrol.Dispose();
            }
            panelContainer.Size = new Size(819, MenuHeight + 55);
           panelMenu.Size = new Size(819, MenuHeight);
            
            control.Disposed += Control_Disposed;
            this.subcontrol = control;
           
            subcontrol.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(subcontrol);
            panelMenu.Tag = subcontrol;
            subcontrol.BringToFront();
            subcontrol.Show();
            
        }

        private void Control_Disposed(object sender, EventArgs e)
        {
            DefaultAllButton();
            HideControl();
        }

        void DefaultButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(36, 71, 176);
            btn.ForeColor = Color.White;
        }
        void DefaultAllButton()
        {
            DefaultButton(btnAdd);
          
        }
        void ClickedButton(Button btn)
        {
            btn.BackColor = Color.LightSkyBlue;
            btn.ForeColor = Color.Black;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
           
            if (btnAdd.BackColor != Color.LightSkyBlue)
            {
                DefaultAllButton();
                ShowControl(new SubPanelAddPerson(this));
                ClickedButton(btnAdd);
                return;
            }
           
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvPerson.CurrentCell == null) return;
            int index = datagvPerson.CurrentCell.RowIndex;
            Citizen citizen = new Citizen(GetContentCell(index, FullName.Index), Convert.ToDateTime(GetContentCell(index, DoB.Index)), GetContentCell(index, gender.Index).ToLower() == "nam" ? Citizen.Gender.MALE : Citizen.Gender.FEMALE,
                                            GetContentCell(index, nickname.Index), GetContentCell(index, bornplace.Index), GetContentCell(index, ethnic.Index), GetContentCell(index, Job.Index),
                                                GetContentCell(index, jobplace.Index), GetContentCell(index, CMND.Index), GetContentCell(index, Address.Index), GetContentCell(index, family.Index),
                                                GetContentCell(index, relationshipowner.Index), GetContentCell(index, status.Index));
            ShowControl(new SubPanelUpdate(this,citizen,GetContentCell(index,id.Index)));
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvPerson.CurrentCell == null) return;
            int index = datagvPerson.CurrentCell.RowIndex;
            if(string.Compare(GetContentCell(index,status.Index),Citizen.Dstatus[Citizen.Estatus.STAY]) ==0||
                string.Compare(GetContentCell(index, status.Index), Citizen.Dstatus[Citizen.Estatus.EXPIRED_STAY]) == 0)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(this, "Không thể xóa người đang tạm trú, hãy chuyển sang phần quản lí tạm trú!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                return;
            }
            if (string.Compare( GetContentCell(index, relationshipowner.Index).ToLower(),"chủ hộ") ==0)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(this, "Không thể xóa chủ hộ!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
              
                return;
            }
            string name = GetContentCell(index, FullName.Index);
            MsgNotifyBox msg = new MsgNotifyBox(this, $"Bạn có muốn xóa {name} ?", Color.Red, FontAwesome.Sharp.IconChar.Question, true);
            msg.ShowDialog(this);
            if(msg.DialogResult == DialogResult.OK)
            {
                string idcitizen = GetContentCell(index, id.Index); 
                var citizenDao = new service.DAO.CitizenDAO();
                if (citizenDao.RemoveCitizen(idcitizen))
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(this, $"Xóa {name} thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                    LoadData();
                }
                else
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(this, "Xóa thất bại!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                }
            }
        }

        

      
        string GetContentCell(int row, int col)
        {
            if (datagvPerson.Rows[row].Cells[col].Value == null)
                return "";
            else return datagvPerson.Rows[row].Cells[col].Value.ToString();
        }
        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvPerson.CurrentCell == null) return;
            int index = datagvPerson.CurrentCell.RowIndex;
            Citizen citizen = new Citizen(GetContentCell(index, FullName.Index), Convert.ToDateTime(GetContentCell(index, DoB.Index)), GetContentCell(index, gender.Index).ToLower() == "nam" ? Citizen.Gender.MALE : Citizen.Gender.FEMALE,
                                            GetContentCell(index, nickname.Index), GetContentCell(index, bornplace.Index), GetContentCell(index, ethnic.Index), GetContentCell(index, Job.Index),
                                                GetContentCell(index, jobplace.Index), GetContentCell(index, CMND.Index), GetContentCell(index, Address.Index), GetContentCell(index, family.Index),
                                                GetContentCell(index, relationshipowner.Index), GetContentCell(index, status.Index));
            citizen.Updated = GetContentCell(index, updated.Index);
            DetailPersonForm detail = new DetailPersonForm(citizen);
            detail.ShowDialog(this);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewDatagvPersonForm viewform = new ViewDatagvPersonForm();
            viewform.ShowDialog(this);
            if(viewform.DialogResult == DialogResult.OK)
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

        private void datagvPerson_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbSumPeople.Text = "Tổng nhân khẩu: " + datagvPerson.Rows.Count.ToString();
        }

        private void datagvPerson_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbSumPeople.Text = "Tổng nhân khẩu: " + datagvPerson.Rows.Count.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearch.Texts)) return ;
            datagvPerson.ClearSelection();
            int rows = datagvPerson.RowCount;
            int cols = datagvPerson.ColumnCount;
            for(int i = rows-1; i >=0; i--)
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DefaultAllButton();
            ShowControl(new SubFilterPerson(this), 70);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
