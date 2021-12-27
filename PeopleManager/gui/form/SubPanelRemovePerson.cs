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
    public partial class SubPanelRemovePerson : UserControl
    {
        public SubPanelRemovePerson()
        {
            InitializeComponent();
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
