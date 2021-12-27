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
    public partial class ThuPhiForm : Form
    {
        public ThuPhiForm()
        {
            InitializeComponent();
            HideControl();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        UserControl subcontrol;

        void HideControl()
        {
            panelContainer.Visible = false;
            panelMenu.Size = new Size(819, 55);
        }
        void ShowControl(UserControl control, int MenuHeight = 155)
        {
            panelContainer.Visible = true;
            if (this.subcontrol != null)
            {
                this.subcontrol.Disposed -= Control_Disposed;
                this.subcontrol.Dispose();
            }
            panelMenu.Size = new Size(819, MenuHeight + 55);
            panelContainer.Size = new Size(819, MenuHeight);

            control.Disposed += Control_Disposed;
            this.subcontrol = control;

            subcontrol.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(subcontrol);
            panelContainer.Tag = subcontrol;
            subcontrol.BringToFront();
            subcontrol.Show();

        }

        private void Control_Disposed(object sender, EventArgs e)
        {
            DefaultAllButton();
            HideControl();
        }

        void DefaultButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(36, 71, 176);
            btn.ForeColor = Color.White;
        }
        void DefaultAllButton()
        {
            DefaultButton(btnAdd);
            DefaultButton(btnRemove);
            DefaultButton(btnUpdate);
        }
        void ClickedButton(Button btn)
        {
            btn.BackColor = Color.LightSkyBlue;
            btn.ForeColor = Color.Black;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            if (btnAdd.BackColor != Color.LightSkyBlue)
            {
                DefaultAllButton();
                ShowControl(new SubPanelAddPerson());
                ClickedButton(btnAdd);
                return;
            }

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (btnRemove.BackColor != Color.LightSkyBlue)
            {
                DefaultAllButton();
                ShowControl(new SubPanelRemovePerson(), 70);
                ClickedButton(btnRemove);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.BackColor != Color.LightSkyBlue)
            {
                DefaultAllButton();
                ShowControl(new SubPanelUpdate());
                ClickedButton(btnUpdate);
                return;
            }
        }
    }
}

