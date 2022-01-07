using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.gui.customform;
using PeopleManager.service;
using PeopleManager.objectclass;
using PeopleManager.service.DAO;
using FontAwesome.Sharp;
using System.IO;

namespace PeopleManager.gui.form
{
    public partial class MainForm : Form
    {
        public MainForm(string username)
        {
            InitializeComponent();
            panelChange.Visible = false;
            panelContribution.Visible = false;
            panelSubPeopleManagement.Visible = false;
            user = UserDAO.Instance.GetUser(username);
            btnUser.Text = $"{username} - {User.DType[this.user.Type]}";
            panelInfor.Visible = false;
            this.CenterToScreen();
        }
        Form childform;
        User user;
        void OpenChildForm(Form childForm)
        {
            if(this.childform != null)
            {
                this.childform.Close();
            }
            this.childform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        void DefaultButton(Button btn)
        {
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.LightGray;
        }
        void DefaultAllButton()
        {
          foreach(var control in panelChange.Controls)
            {
                if(control is Button)
                {
                    var btn = control as Button;
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.White;
                }
            }
            foreach (var control in panelContribution.Controls)
            {
                if (control is Button)
                {
                    var btn = control as Button;
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.White;
                }
            }
            foreach (var control in panelSubPeopleManagement.Controls)
            {
                if (control is Button)
                {
                    var btn = control as Button;
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.White;
                }
            }
        }
        void ClickedButton(Button btn)
        {
            btn.BackColor = Color.LightSkyBlue;
            btn.ForeColor = Color.Black;
        }
      

      

        private void btnPeopleManagement_Click(object sender, EventArgs e)
        {
            panelSubPeopleManagement.Visible = !panelSubPeopleManagement.Visible;
        }

        private void btnContribution_Click(object sender, EventArgs e)
        {
            panelChange.Visible = !panelChange.Visible;
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
           
            DefaultAllButton();
            ClickedButton(btnPerson);
            OpenChildForm(new PersonForm());
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnFamily);
            OpenChildForm(new FamilyForm());
        }

     

        private void btnContribution_Click_1(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnAbsent);
        }

        private void btnChangePeople_Click(object sender, EventArgs e)
        {
            panelChange.Visible = !panelChange.Visible;
        }

        private void btnContribution_Click_2(object sender, EventArgs e)
        {
            panelContribution.Visible = !panelContribution.Visible;
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnStay);
            OpenChildForm(new StayForm());
        }

        private void btnAbsent_Click(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnAbsent);
            OpenChildForm(new LeaveForm());
        }

        private void btnDie_Click(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnDie);
            OpenChildForm(new DeclareDeadForm());
        }

        private void btnFund_Click(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnFund);
            OpenChildForm(new FundForm());
        }

        private void btnContribute_Click(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnContribute);
            OpenChildForm(new ContributionForm());
        }

        
     
        private void btnInfor_MouseEnter(object sender, EventArgs e)
        {
            panelInfor.Visible = true;
        }

        private void btnInfor_MouseLeave(object sender, EventArgs e)
        {
            panelInfor.Visible = false;
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            if(this.childform!=null)
            this.childform.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            File.Delete(config.Config.configfile);
            Application.Restart();
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            panelInfor.Visible = !panelInfor.Visible;
        }
    }
}
