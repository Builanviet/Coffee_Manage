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
    public partial class ShippingDetail : Form
    {
        private Account acc;
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public ShippingDetail(Account acc)
        {
            this.Acc = acc;
            InitializeComponent();
        }
    }
}
