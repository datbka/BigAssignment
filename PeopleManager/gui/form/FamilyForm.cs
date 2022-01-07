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
using PeopleManager.service.DAO;
using PeopleManager.gui.controller;
using PeopleManager.gui.customform;

namespace PeopleManager.gui.form
{
    public partial class FamilyForm : Form
    {
        public FamilyForm()
        {
            InitializeComponent();
            datagvFamily.SortCompare += DatagvFamily_SortCompare;
            HideControl();
            LoadData();
        }
        UserControl subcontrol;
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
            panelContainer.Size = new Size(819, MenuHeight +subcontrol.Height);

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
        private void DatagvFamily_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == AmountMember.Index)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;//pass by the default sorting
            }
        }

       public void LoadData()
        {
            datagvFamily.Rows.Clear();
            var sql = new SqlService();
            //  var table = sql.GetTable("select DISTINCT idfamily from Citizen ");
            var table = sql.GetTable($"select idfamily,[Name],address from dbo.Citizen where relationshipowner =N'chủ hộ'");
            FamilyDAO familyDAO = new FamilyDAO();
            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                datagvFamily.Rows.Add(row[0]);
                datagvFamily.Rows[i].Cells[Owner.Index].Value = row[1];
                datagvFamily.Rows[i].Cells[Address.Index].Value = row[2];
                datagvFamily.Rows[i].Cells[AmountMember.Index].Value = familyDAO.GetMember(row[0].ToString());

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void datagvFamily_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbSumFamily.Text = "Tổng nhân khẩu: " + datagvFamily.RowCount.ToString();
        }

        private void datagvFamily_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbSumFamily.Text = "Tổng nhân khẩu: " + datagvFamily.RowCount.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Texts)) return;
            datagvFamily.ClearSelection();
            int rows = datagvFamily.RowCount;
            int cols = datagvFamily.ColumnCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                bool contain = false;
                for (int k = 0; k < cols; k++)
                {

                    if (datagvFamily.Rows[i].Cells[k].Value != null)
                    {
                        if (datagvFamily.Rows[i].Cells[k].Value.ToString().Contains(txtSearch.Texts))
                        {
                            datagvFamily.Rows[i].Cells[k].Selected = true;
                            contain = true;
                        }
                    }

                }
                if (!contain) datagvFamily.Rows.RemoveAt(i);
            }
        }
        string GetContentCell(int row, int col)
        {
            if (datagvFamily.Rows[row].Cells[col].Value == null) return "";
            else return datagvFamily.Rows[row].Cells[col].Value.ToString();
        }
        private void btnChangeOwner_Click(object sender, EventArgs e)
        {
            ShowControl(new SubChangeOwnerFamily(this, "HK19"));
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void separateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl(new SubSeparateFamily(this, GetContentCell(datagvFamily.CurrentCell.RowIndex, IDFamily.Index)));
        }

        private void changeOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowControl(new SubChangeOwnerFamily(this, GetContentCell(datagvFamily.CurrentCell.RowIndex, IDFamily.Index)));
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDetailFamily detailform = new ViewDetailFamily(GetContentCell(datagvFamily.CurrentCell.RowIndex, IDFamily.Index));
            detailform.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvFamily.CurrentCell == null) return;
            int index = datagvFamily.CurrentCell.RowIndex;
          
            string family = GetContentCell(index, IDFamily.Index);
            MsgNotifyBox msg = new MsgNotifyBox(this, $"Bạn có muốn xóa {family} ?", Color.Red, FontAwesome.Sharp.IconChar.Question, true);
            msg.ShowDialog(this);
            if (msg.DialogResult == DialogResult.OK)
            {
              
                var familyDAO = new service.DAO.FamilyDAO();
                if (familyDAO.RemoveFamily(family))
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(this, $"Xóa {family} thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                    LoadData();
                }
                else
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(this, "Xóa thất bại!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                }
            }
        }
    }
}
