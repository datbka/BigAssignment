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
    public partial class DetailPersonContribution : Form
    {
        public DetailPersonContribution(Fund fund)
        {
            InitializeComponent();
            this.fund = fund;
            LoadContr();
            LoadNotContr();
            this.CenterToScreen();
        }
        Fund fund;
        void LoadContr()
        {
            datagvNotContr.Rows.Clear();
            var sql = new SqlService();
            //  var table = sql.GetTable("select DISTINCT idfamily from Citizen ");
            var table = sql.GetTable($@"select  Citizen.Name,Citizen.CMND,Citizen.idfamily,address,Citizen.id,Citizen.status from dbo.Citizen  except
(select  Citizen.Name,Citizen.CMND,Citizen.idfamily,address,Citizen.id,Citizen.status  from Citizen  left join PersonContribution on Citizen.id = PersonContribution.idcitizen  where PersonContribution.id >0 and PersonContribution.idfund ={this.fund.Iddatabase})");
            FamilyDAO familyDAO = new FamilyDAO();
            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
              
                    datagvContr.Rows.Add(row[0]);
                    int maxr = datagvContr.RowCount - 1;
                    datagvContr.Rows[maxr].Cells[CMND.Index].Value = row[1];
                    datagvContr.Rows[maxr].Cells[address.Index].Value = row[3];
                    datagvContr.Rows[maxr].Cells[family.Index].Value = row[2];
                    datagvContr.Rows[maxr].Cells[id.Index].Value = row[4];
                
            }
        }
        void LoadNotContr()
        {
            datagvContr.Rows.Clear();
            var sql = new SqlService();
           
            var table = sql.GetTable($@"select  Citizen.Name,Citizen.CMND,Citizen.idfamily,address,Citizen.id,Citizen.status  from Citizen  left join PersonContribution on Citizen.id = PersonContribution.idcitizen  where PersonContribution.id >0 and PersonContribution.idfund ={this.fund.Iddatabase}");
            FamilyDAO familyDAO = new FamilyDAO();
            int max = table.Rows.Count;
            for (int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
               
                    datagvContr.Rows.Add(row[0]);
                    int maxr = datagvContr.RowCount-1;
                    datagvContr.Rows[maxr].Cells[CMND.Index].Value = row[1];
                    datagvContr.Rows[maxr].Cells[address.Index].Value = row[3];
                    datagvContr.Rows[maxr].Cells[family.Index].Value = row[2];
                    datagvContr.Rows[maxr].Cells[id.Index].Value = row[4];
                
              
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

        private void datagvNotContr_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbNotContr.Text = "Tổng: " + datagvNotContr.RowCount.ToString();
        }

        private void datagvNotContr_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbNotContr.Text = "Tổng: " + datagvNotContr.RowCount.ToString();
        }
    }
}
