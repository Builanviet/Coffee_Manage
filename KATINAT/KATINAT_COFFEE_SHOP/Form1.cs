using KATINAT_COFFEE_SHOP.Models;
using System.Diagnostics.Eventing.Reader;

namespace KATINAT_COFFEE_SHOP
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username= txbUserName.Text;
            string password = txbPassWord.Text;

            if (!CheckLogin(username, password))
            {
                MessageBox.Show("This account does not exist!");
            }
            else
            {
                Account acc =login(username, password);
                fTableManager f = new fTableManager(acc);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "CONFIRMATION", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private bool CheckLogin(string username, string password)
        {
            using (QuanLyKatinatContext context = new QuanLyKatinatContext())
            {
                // Kiểm tra xem tên người dùng và mật khẩu có tồn tại và khớp trong cơ sở dữ liệu hay không
                return context.Accounts.Any(x => x.UserName == username && x.PassWord == password);
            }
        }
        Account login(string username, string password)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var acc= con.Accounts.FirstOrDefault(x => x.UserName == username && x.PassWord == password);
            return acc;
        }
    }
}