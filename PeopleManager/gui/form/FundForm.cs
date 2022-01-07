using PeopleManager.gui.controller;
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
    public partial class FundForm : Form
    {
        public FundForm()
        {
            InitializeComponent();
            HideControl();
            datagvFund.SortCompare += DatagvFund_SortCompare;
            datagvFund.CellValueChanged += DatagvFund_CellValueChanged;
            LoadData();
          
        }

        private void DatagvFund_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           if(e.ColumnIndex == expired.Index)
            {
                if(Convert.ToDateTime(GetContentCell(e.RowIndex,e.ColumnIndex)) >= DateTime.Now)
                {
                    datagvFund.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                }
                else datagvFund.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }
        string GetContentCell(int row,int col)
        {
            if (datagvFund.Rows[row].Cells[col].Value == null) return "";
            else return datagvFund.Rows[row].Cells[col].Value.ToString();
        }
        private void DatagvFund_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == value.Index)
            {
                if (e.CellValue1 != null && e.CellValue2 != null)
                {
                    e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                    e.Handled = true;//pass by the default sorting
                }
            }
            else if (e.Column.Index == expired.Index)
            {
                if (e.CellValue1 != null && e.CellValue2 != null)
                {
                    e.SortResult = DateTime.Parse(e.CellValue1.ToString()).CompareTo(DateTime.Parse(e.CellValue2.ToString()));
                    e.Handled = true;//pass by the default sorting
                }
            }
        }

        UserControl subcontrol;
        public void LoadData() {
            datagvFund.Rows.Clear();
            var sql = new SqlService();
            
            var table = sql.GetTable("select * from dbo.FundTable");
           
            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                datagvFund.Rows.Add("");
               for(int k = 0; k < datagvFund.ColumnCount; k++)
                {
                    if(k == required.Index )
                    {
                        datagvFund.Rows[i].Cells[k].Value = Convert.ToBoolean(row[k])? "có": "không";
                    }else if(k== ForFamily.Index)
                    {
                        datagvFund.Rows[i].Cells[k].Value = Convert.ToBoolean(row[k])? "theo hộ khẩu" : "theo nhân khẩu";
                    }else if(k == expired.Index)
                    {
                        datagvFund.Rows[i].Cells[k].Value = Convert.ToDateTime(row[k]).ToShortDateString();
                    }
                    else
                    datagvFund.Rows[i].Cells[k].Value = row[k];
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
            DefaultButton(btnAdd);
        }
        void DefaultButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(36, 71, 176);
            btn.ForeColor = Color.White;
        }
        void ClickedButton(Button btn)
        {
            btn.BackColor = Color.LightSkyBlue;
            btn.ForeColor = Color.Black;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.BackColor != Color.LightSkyBlue)
            {
                
                ShowControl(new SubAddFundForm(this));
                ClickedButton(btnAdd);
                return;
            }
        }

        private void datagvFund_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbSumFund.Text = "Tổng số khoản thu: " + datagvFund.RowCount.ToString();
        }

        private void datagvFund_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbSumFund.Text = "Tổng số khoản thu: " + datagvFund.RowCount.ToString();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Texts)) return;
            datagvFund.ClearSelection();
            int rows = datagvFund.RowCount;
            int cols = datagvFund.ColumnCount;
            for (int i = rows - 1; i >= 0; i--)
            {
                bool contain = false;
                for (int k = 0; k < cols; k++)
                {

                    if (datagvFund.Rows[i].Cells[k].Value != null)
                    {
                        if (datagvFund.Rows[i].Cells[k].Value.ToString().Contains(txtSearch.Texts))
                        {
                            datagvFund.Rows[i].Cells[k].Selected = true;
                            contain = true;
                        }
                    }

                }
                if (!contain) datagvFund.Rows.RemoveAt(i);
            }
        }
       
        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvFund.CurrentCell == null) return;
            int index = datagvFund.CurrentCell.RowIndex;
            if(GetContentCell(index,ForFamily.Index) == "theo hộ khẩu")
            {
                Fund fund = new Fund();
                fund.Iddatabase = Convert.ToInt32(GetContentCell(index, id.Index));
                var detail = new DetailFaimilyContribution(fund);
                detail.ShowDialog(this);
            }
            else
            {
                Fund fund = new Fund();
                fund.Iddatabase =Convert.ToInt32( GetContentCell(index, id.Index));
                DetailPersonContribution detail = new DetailPersonContribution(fund);
                detail.ShowDialog(this);
            }
        }
    }
}
