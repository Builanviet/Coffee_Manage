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
    public partial class OrderDetailForm : Form
    {
        int id;
        public OrderDetailForm(int id)
        {
            this.id = id;
            InitializeComponent();
            loadTable();
            loadOrderStatus();
        }
        public void loadTable()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var orderDetails = con.FoodShippingOrders
                .Where(x => x.IdShippingOrder == id)
                .Join(con.Foods, fso => fso.IdFood, f => f.Id, (fso, f) => new
                {
                    FoodId = f.Id,
                    FoodName = f.Name,
                    Quantity = fso.Num,
                    Price = f.Price
                }).ToList();

            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.DataSource = orderDetails;
            
        }
        public void loadOrderStatus()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var orderStatus = con.ShippingOrders
                .Where(x => x.Id == id)
                .Select(x => x.Status)
                .FirstOrDefault();

            txbStatus.Text = GetStatusText(orderStatus);
        }

        private string GetStatusText(int status)
        {
            switch (status)
            {
                case 0:
                    return "Pending";
                case 1:
                    return "Doing";
                case 2:
                    return "Done";
                default:
                    return "Unknown";
            }
        }
    }
}
