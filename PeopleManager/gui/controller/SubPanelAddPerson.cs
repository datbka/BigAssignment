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
using PeopleManager.service.DAO;
using PeopleManager.gui.form;
using PeopleManager.gui.customform;

namespace PeopleManager.gui.controller
{
    public partial class SubPanelAddPerson : UserControl
    {
        public SubPanelAddPerson(PersonForm form)
        {
            InitializeComponent();
            this.personForm = form;
          
        }
        PersonForm personForm;
        private void SubPanelAddPerson_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            #region Valid Empty Input
            if (string.IsNullOrWhiteSpace(txtName.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thiếu thông tin Tên!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                txtName.Focus();
                return;
            }
            if (dateBirth.Value > DateTime.Now)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Ngày sinh lớn hơn hiện tại!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtbornplace.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thiếu thông tin nơi sinh!",Color.Red,FontAwesome.Sharp.IconChar.Exclamation);
               
                txtbornplace.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEthnic.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thiếu thông tin dân tộc!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtEthnic.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thiếu thông tin nơi ở!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFamily.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thiếu thông tin hộ khẩu!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtFamily.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRelationShip.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thiếu thông tin quan hệ với chủ hộ!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                txtRelationShip.Focus();
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
         
            if (familyDAO.Exist(txtFamily.Texts))
            {
                if (string.Compare(txtRelationShip.Texts.ToLower(), "chủ hộ")== 0)
                {

                    MessageBox.Show("Hộ khẩu này đã có chủ hộ!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (string.Compare(txtRelationShip.Texts.ToLower(), "chủ hộ") != 0)
                {

                    MessageBox.Show("Không tồn tại hộ khẩu này!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            var person = new Citizen(txtName.Texts, dateBirth.Value, rbtnMale.Checked ? Citizen.Gender.MALE : Citizen.Gender.FEMALE,
              txtNickname.Texts, txtbornplace.Texts, txtEthnic.Texts, txtJob.Texts, txtJobplace.Texts, txtCMND.Texts, txtAddress.Texts, txtFamily.Texts, txtRelationShip.Texts, "");

           
            if (string.IsNullOrEmpty(txtCMND.Texts) && string.IsNullOrEmpty(txtJob.Texts) && string.IsNullOrEmpty(txtJobplace.Texts))
            { 
                if(string.Compare(txtRelationShip.Texts.ToLower(),"chủ hộ") == 0)
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Mới sinh không thể làm chủ hộ!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                    return;
                }
                person.Status= Citizen.Dstatus[Citizen.Estatus.NEW];
             
            }
            else if(!string.IsNullOrEmpty(txtCMND.Texts) || !string.IsNullOrEmpty(txtJob.Texts) || !string.IsNullOrEmpty(txtJobplace.Texts))
            {
                if (string.IsNullOrWhiteSpace(txtCMND.Texts))
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thiếu thông tin!", Color.Red, FontAwesome.Sharp.IconChar.Exclamation);

                    return;
                }
            }
             person.Status = Citizen.Dstatus[Citizen.Estatus.ALIVE];
            
          var res =  citizenDAO.InsertCitizen(person);
            if (res)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thêm nhân khẩu thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                this.personForm.LoadData();
                return;
            }
            else
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(personForm, "Thêm nhân khẩu thất bại!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                return;
            }
        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
