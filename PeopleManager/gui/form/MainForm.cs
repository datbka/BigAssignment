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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Form childform;
      
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
          foreach(var control in panelSubContribution.Controls)
            {
                if(control is Button)
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
            panelSubContribution.Visible = !panelSubContribution.Visible;
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
        }

        private void btnFund_Click(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnFund);
        }

        private void btnContribution_Click_1(object sender, EventArgs e)
        {
            DefaultAllButton();
            ClickedButton(btnContribution);
        }
    }
}
