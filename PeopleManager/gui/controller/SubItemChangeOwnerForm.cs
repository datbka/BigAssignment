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
namespace PeopleManager.gui.controller
{
    public partial class SubItemChangeOwnerForm : UserControl
    {
        public SubItemChangeOwnerForm(Citizen citizen)
        {
            InitializeComponent();
            this.citizen = citizen;
            lbContent.Text = $"Cập nhật quan hệ với chủ hộ mới cho thành viên {citizen.Name} - {citizen.Idcitizen}" ;
        }
        public Citizen citizen;
    }
}
