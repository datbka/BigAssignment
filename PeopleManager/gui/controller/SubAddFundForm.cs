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
    public partial class SubAddFundForm : UserControl
    {
        public SubAddFundForm(Form form)
        {
            InitializeComponent();
            this.owerform = form;
        }

        private void iconclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        Form owerform;
        private void btnOk_Click(object sender, EventArgs e)
        {
            #region valid input
            if (string.IsNullOrWhiteSpace(txtName.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(owerform, "Thiếu trường tên khoản thu!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValue.Texts))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(owerform, "Thiếu trường giá trị!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                txtValue.Focus();
                return;
            }
            int tmp = -1;
            if(!int.TryParse(txtValue.Texts, out tmp))
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(owerform, "Trường giá trị phải là 1 số!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                txtValue.Focus();
                return;
            }
            if (tmp < 0)
            {
                MsgNotifyBox msgbox = new MsgNotifyBox(owerform, "Trường giá trị phải lớn hơn 0!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                txtValue.Focus();
                return;
            }
            if (dateExpired.Value < DateTime.Now)
            {

                MsgNotifyBox msgbox = new MsgNotifyBox(owerform, "Thời gian kết thúc phải lớn hơn hiện tại!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
                txtValue.Focus();
                return;
            }
            #endregion
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var fund = new Fund(txtName.Texts, txtDecription.Texts, Convert.ToInt32(txtValue.Texts), dateExpired.Value, rbtnRequired.Checked ? true : false,rbtnForFamily.Checked ? true:false, now);
            if(FundDAO.Instance.Insert(fund))
            {

                MsgNotifyBox msgbox = new MsgNotifyBox(owerform, "Thêm  khoản thu thành công!", Color.Blue, FontAwesome.Sharp.IconChar.Info);
                ((FundForm)owerform).LoadData();
                return;
            }
            else
            {

                MsgNotifyBox msgbox = new MsgNotifyBox(owerform, "Thêm khoản thu thất bại!", Color.Red, FontAwesome.Sharp.IconChar.ExclamationTriangle);
              
                return;
            }
        }

        private void rbtnRequired_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}
