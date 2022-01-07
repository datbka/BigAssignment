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
    public partial class SubDatagridFamilyContribution : UserControl
    {
        public SubDatagridFamilyContribution(Form ownerform,Fund fund)
        {
            InitializeComponent();
            this.fund = fund;
            this.ownerform = ownerform;
            LoadData();
            
        }
        Fund fund;
        Form ownerform;
        void LoadData()
        {
            if (this.fund.Required) LoadDataRequired();
            else LoadAllData();
        }
        public void LoadAllData()
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
        bool Exist(string family)
        {
            int max = datagvFamily.RowCount;
            for (int i = 0; i < max; i++)
            {
                if (datagvFamily.Rows[i].Cells[IDFamily.Index].Value.ToString() == family) return true;
            }
            return false;
        }
        public void LoadDataRequired()
        {
            datagvFamily.Rows.Clear();
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
                datagvFamily.Rows.Add(row[0]);
                int maxr = datagvFamily.RowCount-1;
                datagvFamily.Rows[maxr].Cells[Owner.Index].Value = row[1];
                datagvFamily.Rows[maxr].Cells[Address.Index].Value = row[2];
                datagvFamily.Rows[maxr].Cells[AmountMember.Index].Value = familyDAO.GetMember(row[0].ToString());

            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvFamily.CurrentCell == null) return;
            int row = datagvFamily.CurrentCell.RowIndex;
            FamilyContribution fcontribution = new FamilyContribution(this.fund, datagvFamily.Rows[row].Cells[IDFamily.Index].Value.ToString());
            fcontribution.ShowDialog(this);
            if(fcontribution.DialogResult == DialogResult.OK)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Đóng góp thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                LoadData();
            }
        }
    }
}
