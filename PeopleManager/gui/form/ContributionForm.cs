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
using PeopleManager.objectclass;
using PeopleManager.service.DAO;

namespace PeopleManager.gui.form
{
    public partial class ContributionForm : Form
    {
        public ContributionForm()
        {
            InitializeComponent();
            LoadCb();
        }
        void LoadCb()
        {
            listfunds = FundDAO.Instance.GetListFund();
            int max = listfunds.Count;
            cbListFund.Items.Clear();
            for (int i = 0; i < max; i++)
            {
                cbListFund.Items.Add(listfunds[i].Name);
            }
        }
        List<Fund> listfunds;
        UserControl subcontroldata;
        private void cbListFund_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListFund.SelectedIndex < 0) return;
            panelData.Controls.Clear();
            if(listfunds[cbListFund.SelectedIndex].Forfamily)
            panelData.Controls.Add(new SubDatagridFamilyContribution(this,listfunds[cbListFund.SelectedIndex]));
            else panelData.Controls.Add(new SubDatagridPeron(this, listfunds[cbListFund.SelectedIndex]));
        }
    }
}
