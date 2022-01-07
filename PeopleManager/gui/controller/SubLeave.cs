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
using PeopleManager.objectclass;
using PeopleManager.service.DAO;
namespace PeopleManager.gui.controller
{
    public partial class SubLeave : UserControl
    {
        public SubLeave(Form ownerform,Citizen citizen)
        {
            InitializeComponent();
            this.citizen = citizen;
            this.ownerform = ownerform;
            this.labelperson.Text = citizen.Name;
        }
        Citizen citizen;
        Form ownerform;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDestination.Texts))
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Không thể để nơi đến trống!", Color.Red);
                return;
            }
            if(dateExpired.Value <= DateTime.Now)
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Giá trị thời gian dự kiến phải lớn hơn hiện tại!", Color.Red);
                return;
            }
            CitizenDAO citizenDAO = new CitizenDAO();
            string update = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (citizenDAO.Leave(citizen.Iddatabase, txtDestination.Texts, txtNote.Texts, dateExpired.Value.ToString("yyyy-MM-dd"), update))
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Khai báo tạm vắng thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);

            }
            else
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Khai báo tạm vắng thất bại!", Color.Red);
            }
        }
    }
}
