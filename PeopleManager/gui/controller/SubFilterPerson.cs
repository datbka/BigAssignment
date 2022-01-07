using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.gui.form;

namespace PeopleManager.gui.controller
{
    public partial class SubFilterPerson : UserControl
    {
        public SubFilterPerson(PersonForm form)
        {
            InitializeComponent();
            this.personform = form;
        }
        List<string> listfilter;
        PersonForm personform;
        private void cbFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            listfilter = new List<string>();
            switch (cbFilter.SelectedIndex)
            {
                case (0):
                    listfilter = personform.GetListFilter("gender");
                    break;
                case (1):
                    listfilter = personform.GetListFilter("ethnic");
                    break;
                case (2):
                    listfilter = personform.GetListFilter("status");
                    break;
            }
            cbFilterValue.Items.Clear();
            cbFilterValue.Items.AddRange(listfilter.ToArray());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(cbFilter.SelectedIndex<0 || cbFilterValue.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn cài đặt!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = "";
            switch (cbFilter.SelectedIndex)
            {
                case (0):
                    name = "gender";
                    break;
                case (1):
                    name = "ethnic";
                    break;
                case (2):
                    name = "status";
                    break;

            }
            personform.FilterDatagv(name, cbFilterValue.SelectedItem.ToString());
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
