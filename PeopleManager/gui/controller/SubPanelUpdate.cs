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
using PeopleManager.service;
using PeopleManager.gui.customform;
using PeopleManager.gui.form;
using PeopleManager.service.DAO;

namespace PeopleManager.gui.controller
{
    public partial class SubPanelUpdate : UserControl
    {
        public SubPanelUpdate(PersonForm ownerform,Citizen citizen,string id)
        {
            InitializeComponent();
            txtName.Texts = citizen.Name;
            txtNickname.Texts = citizen.Nickname;
            if (citizen.Gender1 == Citizen.Gender.MALE) rbtnMale.Checked = true; else rbtnFemale.Checked = true;
            txtCMND.Texts = citizen.Idcitizen;
            txtEthnic.Texts = citizen.Ethnic;
            txtJob.Texts = citizen.Job;
            txtJobplace.Texts = citizen.Jobplace;
            txtAddress.Texts = citizen.Address;
            txtFamily.Texts = citizen.Owerfamily;
            txtRelationShip.Texts = citizen.Relationshipwithower;
            if (citizen.Relationshipwithower.ToLower() == "chủ hộ")
            {
                txtRelationShip.Enabled = false;
                txtFamily.Enabled = false;
            }
            dateBirth.Value = citizen.DoB1;
            txtbornplace.Texts = citizen.Bornplace;
            this.citizen = citizen;
            this.iddatabase = id;
            this.personform = ownerform;
        }
        string iddatabase;
        PersonForm personform;
        Citizen citizen;
        private void btnOk_Click(object sender, EventArgs e)
        {
            #region Valid Empty Input
            if (string.IsNullOrWhiteSpace(txtName.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personform, "Thiếu thông tin Tên!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                txtName.Focus();
                return;
            }
            if (dateBirth.Value > DateTime.Now)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personform, "Ngày sinh lớn hơn hiện tại!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtbornplace.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personform, "Thiếu thông tin nơi sinh!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtbornplace.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEthnic.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personform, "Thiếu thông tin dân tộc!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtEthnic.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personform, "Thiếu thông tin nơi ở!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFamily.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personform, "Thiếu thông tin hộ khẩu!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtFamily.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRelationShip.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personform, "Thiếu thông tin quan hệ với chủ hộ!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtRelationShip.Focus();
                return;
            }
            #endregion
            if (string.Compare(txtRelationShip.Texts.ToLower(),"chủ hộ") == 0 && string.Compare(this.citizen.Relationshipwithower.ToLower(),"chủ hộ") !=0)
            {
                MsgNotifyBox msg = new MsgNotifyBox(this.personform, "Thay đổi thông tin liên quan đến chủ hộ, hãy chuyển sang phần quản lí hộ khẩu!", Color.Red);
                return;
            }
            CitizenDAO citizenDAO = new CitizenDAO();
            FamilyDAO familyDAO = new FamilyDAO();
            if (!citizenDAO.IsValidUpdateCMND(txtCMND.Texts, this.iddatabase))
            {

                MsgNotifyBox msg = new MsgNotifyBox(this.personform, "Số CMND trùng với người khác!", Color.Red);
                return;
            }
            if (!familyDAO.Exist(txtFamily.Texts))
            {
                MsgNotifyBox msg = new MsgNotifyBox(this.personform, "Không tồn tại hộ khẩu này!", Color.Red);
                return;
            }
            SqlService sql = new SqlService();
            string gender = rbtnMale.Checked ? "1" : "0";
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if(string.IsNullOrEmpty(citizen.Idcitizen) && string.Compare(citizen.Status.ToLower(), Citizen.Dstatus[Citizen.Estatus.NEW]) == 0)
            {
                if (!string.IsNullOrEmpty(txtCMND.Texts)) citizen.Status = Citizen.Dstatus[Citizen.Estatus.ALIVE];
            }
            var res = sql.Query($"UPDATE Citizen SET [Name] =N'{txtName.Texts}',nickname =N'{txtNickname.Texts}',Gender ={gender}," +
                $"CMND =N'{txtCMND.Texts}',DoB=N'{dateBirth.Value.ToString("yyyy-MM-dd")}',bornplace =N'{txtbornplace.Texts}',ethnic =N'{txtEthnic.Texts}',address =N'{txtAddress.Texts}'," +
                $"job =N'{txtJob.Texts}',jobplace =N'{txtJobplace.Texts}',idfamily =N'{txtFamily.Texts}',relationshipowner =N'{txtRelationShip.Texts}',Updated ='{now}',status =N'{citizen.Status}' WHERE id={this.iddatabase}");
            if (res > 0)
            {
                MsgNotifyBox msg = new MsgNotifyBox(this.personform, "Thay đổi thông tin thành công!", Color.Blue,FontAwesome.Sharp.IconChar.Info);
                personform.LoadData();
            }
            else
            {
                MsgNotifyBox msg = new MsgNotifyBox(this.personform, "Thay đổi thông tin thất bại!", Color.Red);
            }
        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
