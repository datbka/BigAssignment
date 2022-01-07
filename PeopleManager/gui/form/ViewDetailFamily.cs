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

namespace PeopleManager.gui.form
{
    public partial class ViewDetailFamily : Form
    {
        public ViewDetailFamily(string idfamily)
        {
            InitializeComponent();
            this.idfamily = idfamily;
            this.Text = "Xem chi tiết hộ khẩu " + idfamily;
            datagvPerson.SortCompare += DatagvPerson_SortCompare;
            datagvPerson.CellValueChanged += DatagvPerson_CellValueChanged;
            LoadData();
            int rows = datagvPerson.RowCount;
            txtSummember.Text = rows.ToString();
            for(int i = 0; i < rows; i++)
            {
                if (string.Compare(datagvPerson.Rows[i].Cells[this.relationshipowner.Index].Value.ToString().ToLower(), "chủ hộ") == 0)
                { txtOwner.Text = datagvPerson.Rows[i].Cells[this.FullName.Index].Value.ToString();
                    break;
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

        string idfamily;
        public void LoadData()
        {
            datagvPerson.Rows.Clear();
            var sql = new SqlService();
            var table = sql.GetTable($"select * from Citizen where idfamily =N'{this.idfamily}'");

            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
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
        }
    }
}
