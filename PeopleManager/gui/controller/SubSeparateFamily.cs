using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.service.DAO;
using PeopleManager.objectclass;
using PeopleManager.gui.customform;
using PeopleManager.gui.form;
namespace PeopleManager.gui.controller
{
    public partial class SubSeparateFamily : UserControl
    {
        public SubSeparateFamily(FamilyForm ownerform, string idfamily)
        {
            InitializeComponent();
            lbFamily.Text = idfamily;
            this.idfamily = idfamily;
            LoadCb(idfamily);

            this.ownerform = ownerform;
          
        }
        void LoadCb(string idfamily)
        {
            FamilyDAO familyDAO = new FamilyDAO();
            members = new List<Citizen>();
            members = familyDAO.GetListMembers(idfamily);
            int max = members.Count;
            for (int i = max - 1; i >= 0; i--)
            {
                if (string.Compare(members[i].Relationshipwithower.ToLower(), "chủ hộ") == 0) { members.Remove(members[i]); continue; }
                if (string.Compare(members[i].Status, Citizen.Dstatus[Citizen.Estatus.DIE]) == 0) { members.Remove(members[i]); continue; }
                if (string.Compare(members[i].Status, Citizen.Dstatus[Citizen.Estatus.NEW]) == 0) {members.Remove(members[i]); continue; }
            }
          
            cbMember.Items.Clear();
            foreach (var item in members)
            {

                cbMember.Items.Add($"{item.Name} - {item.Idcitizen}");
            }
        }
        List<Citizen> members;
        FamilyForm ownerform;
        string idfamily;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNewFamily.Texts))
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Chưa điền hộ khẩu mới!", Color.Red);
                txtNewFamily.Focus();
                return;
            }
            if(cbMember.SelectedIndex < 0)
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Chưa chọn thành viên!", Color.Red);
                return;
            }
          
            var familyDAO = new FamilyDAO();
            if (familyDAO.Exist(txtNewFamily.Texts))
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Đã tồn tại hộ khẩu mới rồi!", Color.Red);
                return;
            }
            string idcitizen = members[cbMember.SelectedIndex].Iddatabase;
            if (familyDAO.AlterFamily(idcitizen, txtNewFamily.Texts))
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Tách hộ khẩu thành công!", Color.Blue,FontAwesome.Sharp.IconChar.Info);
                ownerform.LoadData();
                LoadCb(this.idfamily);
                return;
            }
            else
            {
                MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Tách hộ khẩu thất bại!", Color.Red);
            }
        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
