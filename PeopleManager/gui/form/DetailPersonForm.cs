using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.objectclass;

namespace PeopleManager.gui.form
{
    public partial class DetailPersonForm : Form
    {
        public DetailPersonForm(Citizen citizen)
        {
            InitializeComponent();
            this.CenterToParent();
            txtName.Text = citizen.Name;
            txtNickName.Text = citizen.Nickname;
            txtGender.Text = citizen.Gender1 == Citizen.Gender.MALE ? "Nam" : "Nữ";
            txtCMND.Text = citizen.Idcitizen;
            txtEthnic.Text = citizen.Ethnic;
            txtJob.Text = citizen.Job;
            txtJobplace.Text = citizen.Jobplace;
            txtAddress.Text = citizen.Address;
            txtFamily.Text = citizen.Owerfamily;
            txtRelationship.Text = citizen.Relationshipwithower;
            txtStatus.Text = citizen.Status;
            txtDob.Text = citizen.DoB1.ToShortDateString();
            txtBornplace.Text = citizen.Bornplace;
            txtUpdated.Text = citizen.Updated;
        }

        private void DetailPersonForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
