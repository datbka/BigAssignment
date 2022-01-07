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
    public partial class ViewDatagvPersonForm : Form
    {
        public ViewDatagvPersonForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ckCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCheckAll.Checked)
            {
                foreach(var item in panelck.Controls)
                {
                    var ck = item as CheckBox;
                    ck.Checked = true;
                }
            }
        }
    }
}
