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
    public partial class SubChangeOwnerFamily : UserControl
    {
        public SubChangeOwnerFamily(Form ownerform,string idfamily)
        {
            InitializeComponent();
            lbFamily.Text = idfamily;
           
           
            this.idfamily = idfamily;
            this.ownerform = ownerform;
            LoadCb(idfamily);
            panelContainer.Visible = false;
        }
        void LoadCb(string idfamily)
        {
            FamilyDAO familyDAO = new FamilyDAO();
            members = familyDAO.GetListMembers(idfamily);
            int max = members.Count;
            for(int i = max-1; i >=0; i--)
            {
                if (string.Compare(members[i].Status, Citizen.Dstatus[Citizen.Estatus.DIE]) == 0) { members.Remove(members[i]); continue; }
                if (string.Compare(members[i].Status, Citizen.Dstatus[Citizen.Estatus.NEW]) == 0) members.Remove(members[i]);
            }
           
            foreach (var item in members)
            {

                cbMember.Items.Add($"{item.Name} - {item.Idcitizen}");
            }
        }
        Form ownerform;
        List<Citizen> members;
        string idfamily;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbMember.SelectedIndex < 0)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Chưa chọn thành viên!", Color.Red);
                return;
            }
            int selected = cbMember.SelectedIndex;
            
            FamilyDAO familyDAO = new FamilyDAO();
            if (!familyDAO.AlterNewRelationship(members[selected].Iddatabase, "chủ hộ"))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thay đổi nhân khẩu thất bại!", Color.Red);
                return;
            }
            foreach (var item in panelContainer.Controls)
            {
                var subitem = item as SubItemChangeOwnerForm;
              if(!familyDAO.AlterNewRelationship(subitem.citizen.Iddatabase, subitem.txtNewRelationship.Texts))
                {
                    MsgNotifyBox msgbox = new MsgNotifyBox(ownerform, "Thay đổi nhân khẩu thất bại!", Color.Red);
                    return;
                }
            }

            MsgNotifyBox msg = new MsgNotifyBox(ownerform, "Tách hộ khẩu thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
           ((FamilyForm) ownerform).LoadData();
            LoadCb(this.idfamily);
        }

        private void cbMember_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            panelContainer.Visible = true;
            panelContainer.Controls.Clear();
            int max = cbMember.Items.Count;
            int selected = cbMember.SelectedIndex;
            var familyDao = new FamilyDAO();
            var Allmembers = new List<Citizen>();
            Allmembers.AddRange( familyDao.GetAllMembers(this.idfamily));
            foreach(var item in Allmembers)
            {
                if (item.Iddatabase == members[selected].Iddatabase) { Allmembers.Remove(item); break; }
            }
            for(int i = 0; i < max; i++)
            {
                
                panelContainer.Controls.Add(new SubItemChangeOwnerForm( Allmembers[i]));
            }
        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
