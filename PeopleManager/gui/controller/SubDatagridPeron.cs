using PeopleManager.gui.customform;
using PeopleManager.gui.form;
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

namespace PeopleManager.gui.controller
{
    public partial class SubDatagridPeron : UserControl
    {
        public SubDatagridPeron(Form form, Fund fund)
        {
            InitializeComponent();
            this.owernform = form;
            this.fund = fund;
            LoadData();
        }
        Form owernform;
        Fund fund;
        void LoadData()
        {
            if (this.fund.Required) LoadDataRequired();
            else LoadAllData();
        }
        public void LoadAllData()
        {
            datagvPerson.Rows.Clear();
            var sql = new SqlService();
            //  var table = sql.GetTable("select DISTINCT idfamily from Citizen ");
            var table = sql.GetTable($"select Citizen.Name,Citizen.CMND,Citizen.idfamily,address,Citizen.id from dbo.Citizen");
            FamilyDAO familyDAO = new FamilyDAO();
            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                datagvPerson.Rows.Add(row[0]);
                datagvPerson.Rows[i].Cells[CMND.Index].Value = row[1];
                datagvPerson.Rows[i].Cells[address.Index].Value = row[3];
                datagvPerson.Rows[i].Cells[family.Index].Value = row[2];
                datagvPerson.Rows[i].Cells[id.Index].Value = row[4];
            }
        }
        public void LoadDataRequired()
        {
            datagvPerson.Rows.Clear();
            var sql = new SqlService();
            //  var table = sql.GetTable("select DISTINCT idfamily from Citizen ");
            var table = sql.GetTable($@"select  Citizen.Name,Citizen.CMND,Citizen.idfamily,address,Citizen.id from dbo.Citizen  except
(select  Citizen.Name,Citizen.CMND,Citizen.idfamily,address,Citizen.id  from Citizen  left join PersonContribution on Citizen.id = PersonContribution.idcitizen  where PersonContribution.id >0 and PersonContribution.idfund ={this.fund.Iddatabase})");
            FamilyDAO familyDAO = new FamilyDAO();
            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                datagvPerson.Rows.Add(row[0]);
                datagvPerson.Rows[i].Cells[CMND.Index].Value = row[1];
                datagvPerson.Rows[i].Cells[address.Index].Value = row[3];
                datagvPerson.Rows[i].Cells[family.Index].Value = row[2];
                datagvPerson.Rows[i].Cells[id.Index].Value = row[4];
            }
        }
        private void contributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datagvPerson.CurrentCell == null) return;
            int row = datagvPerson.CurrentCell.RowIndex;
            FamilyContribution fcontribution = new FamilyContribution(this.fund, datagvPerson.Rows[row].Cells[id.Index].Value.ToString());
            fcontribution.ShowDialog(this);
            if (fcontribution.DialogResult == DialogResult.OK)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(this.owernform, "Đóng góp thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                LoadData();
            }
        }
    }
}
