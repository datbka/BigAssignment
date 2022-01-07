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
using PeopleManager.objectclass;
namespace PeopleManager.gui.form
{
    public partial class FamilyContribution : Form
    {
        public FamilyContribution(Fund fund,string idcontributer)
        {
            InitializeComponent();
            this.fund = fund;
            this.idcontributer = idcontributer;
            txtName.Text = idcontributer;
            txtValue.Texts = fund.Value.ToString();
            this.Text = "Đóng góp cho khoản thu " + fund.Name;
            if (fund.Required) { txtValue.Enabled = false; }
            this.CenterToParent();
        }
        Fund fund;
        string idcontributer;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if(fund.Forfamily)
            ContributionDAO.Instance.FamilyInsert(new objectclass.Contribution(txtValue.Texts, now, fund.Iddatabase.ToString(), "''", idcontributer, ""));
            else ContributionDAO.Instance.PersonInsert(new objectclass.Contribution(txtValue.Texts, now, fund.Iddatabase.ToString(), idcontributer, "", ""));
            this.DialogResult = DialogResult.OK;


        }
    }
}
