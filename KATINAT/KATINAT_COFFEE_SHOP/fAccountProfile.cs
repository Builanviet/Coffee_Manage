using KATINAT_COFFEE_SHOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KATINAT_COFFEE_SHOP
{
    public partial class fAccountProfile : Form
    {
        private Account acc;
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            this.Acc = acc;
            loadProfile(acc);
        }
        public void loadProfile(Account acc)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var pr = con.Accounts.FirstOrDefault(x => x.UserName == acc.UserName.ToString());
            txbDisPlayName.Text = pr.DisplayName.ToString();
            txbUserName.Text = acc.UserName.ToString();
            txbPassWord.Text = acc.PassWord.ToString();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            string displayName = txbDisPlayName.Text;
            string newPassword = txbNewPassword.Text;
            string reNewPassword = txbReEnterPassword.Text;
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if(string.IsNullOrEmpty(reNewPassword) || string.IsNullOrEmpty(reNewPassword)||string.IsNullOrEmpty(newPassword)) 
            {
                MessageBox.Show("Input fields can not be empty");
            }else if (passWord.Equals(newPassword))
            {
                MessageBox.Show("New password has to be different to password");
            }
            else if (!reNewPassword.Equals(reNewPassword))
            {
                MessageBox.Show("Repassword is not similar to password");
            }
            else
            {
                var acc = con.Accounts.FirstOrDefault(x => x.UserName == userName);
                acc.PassWord = newPassword;
                con.SaveChanges();
                loadProfile(acc);
            }
        }

        //private LoadInfor()
        //{
        //    QuanLyKatinatContext con = new QuanLyKatinatContext();
        //    Account user = con.Accounts.Find(userId);
        //}
    }
}
