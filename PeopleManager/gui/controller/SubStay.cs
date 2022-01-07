using PeopleManager.gui.customform;
using PeopleManager.gui.form;
using PeopleManager.objectclass;
using PeopleManager.service.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleManager.gui.controller
{
    public partial class SubStay : UserControl
    {
        public SubStay(Form ownerform)
        {
            InitializeComponent();
            this.ownerform = ownerform;
        }
        Form ownerform;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            #region Valid Empty Input
            if (string.IsNullOrWhiteSpace(txtName.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thiếu thông tin Tên!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCMND.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thiếu thông tin số CMND!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                txtName.Focus();
                return;
            }
            if (dateBirth.Value > DateTime.Now)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Ngày sinh lớn hơn hiện tại!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                
                return;
            }
            if (dateExpired.Value < DateTime.Now)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Hạn tạm trú nhỏ hơn hiện tại!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
               
                return;
            }
            if (string.IsNullOrWhiteSpace(txtbornplace.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thiếu thông tin nơi sinh!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtbornplace.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEthnic.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thiếu thông tin dân tộc!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtEthnic.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thiếu thông tin nơi ở!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFrom.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thiếu thông tin nơi đến!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtFrom.Focus();
                return;
            }

            #endregion

            CitizenDAO citizenDAO = new CitizenDAO();
            FamilyDAO familyDAO = new FamilyDAO();
            if (citizenDAO.Exist(txtCMND.Texts) && !string.IsNullOrEmpty(txtCMND.Texts))
            {
                MessageBox.Show("Đã tồn tại CMND này!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int iddatabase = citizenDAO.MaxId(); ;
            var person = new Citizen(txtName.Texts, dateBirth.Value, rbtnMale.Checked ? Citizen.Gender.MALE : Citizen.Gender.FEMALE,
            txtNickname.Texts, txtbornplace.Texts, txtEthnic.Texts, txtJob.Texts, txtJobplace.Texts, txtCMND.Texts, txtAddress.Texts, "", "", Citizen.Dstatus[Citizen.Estatus.STAY]);
            var res = citizenDAO.InsertCitizen(person,iddatabase);
            if (res)
            {
                string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
               StayDAO.Instance.Insert(iddatabase.ToString(), txtFrom.Texts, txtnote.Texts, dateExpired.Value.ToString("yyyy-MM-dd"), now);
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thêm nhân khẩu thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                ((StayForm)ownerform).LoadStay();
                return;
            }
            else
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thêm nhân khẩu thất bại!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                return;
            }

        }
    }
}
