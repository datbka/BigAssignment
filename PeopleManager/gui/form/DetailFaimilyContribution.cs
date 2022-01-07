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
    public partial class DetailFaimilyContribution : Form
    {
        public DetailFaimilyContribution(Fund fund)
        {
            InitializeComponent();
            this.fund = fund;
            LoadNotContr();
            LoadContr();
        }
        Fund fund;
        bool Exist(string family)
        {
            int max = dataNotContr.RowCount;
            for(int i = 0; i < max; i++)
            {
                if (dataNotContr.Rows[i].Cells[IDFamily.Index].Value.ToString() == family) return true;
            }
            return false;
        }
        bool Exist1(string family)
        {
            int max = datagvContr.RowCount;
            for (int i = 0; i < max; i++)
            {
                if (datagvContr.Rows[i].Cells[IDFamily.Index].Value.ToString() == family) return true;
            }
            return false;
        }
        void LoadNotContr()
        {
            dataNotContr.Rows.Clear();
            var sql = new SqlService();
            //  var table = sql.GetTable("select DISTINCT idfamily from Citizen ");
            var table = sql.GetTable($@"select idfamily,[Name],address from dbo.Citizen where relationshipowner =N'chủ hộ' except
(select   Citizen.idfamily,[Name], address from Citizen left join FamilyContribution on Citizen.idfamily = FamilyContribution.idfamily  where FamilyContribution.id > 0 and FamilyContribution.IDFund = {this.fund.Iddatabase})");
            FamilyDAO familyDAO = new FamilyDAO();
            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                
                var row = table.Rows[i];
                if (Exist(row[0].ToString())) continue;
                dataNotContr.Rows.Add(row[0]);
                int maxr = dataNotContr.RowCount;
                dataNotContr.Rows[maxr-1].Cells[Owner.Index].Value = row[1];
                dataNotContr.Rows[maxr-1].Cells[Address.Index].Value = row[2];
                dataNotContr.Rows[maxr-1].Cells[AmountMember.Index].Value = familyDAO.GetMember(row[0].ToString());

            }
        }
        void LoadContr()
        {
            datagvContr.Rows.Clear();
            var sql = new SqlService();
            //  var table = sql.GetTable("select DISTINCT idfamily from Citizen ");
            var table = sql.GetTable($@"select   Citizen.idfamily,[Name], address from Citizen left join FamilyContribution on Citizen.idfamily = FamilyContribution.idfamily  where FamilyContribution.id > 0 and FamilyContribution.IDFund = {this.fund.Iddatabase}");
            FamilyDAO familyDAO = new FamilyDAO();
            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                if (Exist1(row[0].ToString())) continue;
                datagvContr.Rows.Add(row[0]);
                int maxr = datagvContr.RowCount;
                datagvContr.Rows[maxr-1].Cells[Owner.Index].Value = row[1];
                datagvContr.Rows[maxr-1].Cells[Address.Index].Value = row[2];
                datagvContr.Rows[maxr-1].Cells[AmountMember.Index].Value = familyDAO.GetMember(row[0].ToString());

            }
        }

        private void datagvContr_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbContr.Text = "Tổng: " + datagvContr.RowCount.ToString();
        }

        private void datagvContr_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbContr.Text = "Tổng: " + datagvContr.RowCount.ToString();
        }

        private void dataNotContr_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbNotContr.Text = "Tổng: " + dataNotContr.RowCount.ToString();
        }

        private void dataNotContr_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbNotContr.Text = "Tổng: " + dataNotContr.RowCount.ToString();
        }
    }
}
