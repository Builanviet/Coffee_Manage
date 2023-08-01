using ClosedXML.Excel;
using KATINAT_COFFEE_SHOP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KATINAT_COFFEE_SHOP
{
    public partial class fTableManager : Form
    {
        private Account acc;
        public Account Acc
        {
            get { return acc; }
            set { acc = value; ChangeAccount(acc.Type); }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.Acc = acc;
            LoadTable();
            LoadCategory();
            //LoadTableSwitch();


        }
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            shippingSiteToolStripMenuItem.Enabled = type == 2;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(acc);
            f.ShowDialog();

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin(acc);
            f.ShowDialog();
        }


        private void LoadTable()
        {
            flpTable.Controls.Clear();
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var ta = con.TableFoods.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Status = x.Status

            });
            foreach (var t in ta)
            {
                Button btn = new Button();
                btn.Text = t.Name + Environment.NewLine + t.Status.ToString();

                btn.Click += btn_Click;
                btn.Tag = t.Id;
                switch (t.Status)
                {
                    case "Empty":
                        btn.BackColor = Color.LightSeaGreen;
                        break;
                    default: btn.BackColor = Color.LightSalmon; break;
                }
                // Cấu hình vị trí và kích thước của nút
                btn.Width = 100;
                btn.Height = 100;
                btn.Margin = new Padding(5);


                // Thêm nút vào panel
                flpTable.Controls.Add(btn);
            }
        }
        private void LoadCategory()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var ca = con.FoodCategories.Select(x => new
            {
                Id = x.Id,
                Name = x.Name

            }).ToList();

            cbxCategory.DataSource = ca;
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";
        }

        private void LoadFoodByCategory(int id)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var fo = con.Foods.Where(x => x.IdCategory == id).ToList();
            cbxFood.DataSource = fo;
            cbxFood.DisplayMember = "Name";
            cbxFood.ValueMember = "Id";
            UpdateAvailableFoodQuantity();

        }


        private void UpdateAvailableFoodQuantity()
        {
            if (cbxFood.SelectedItem != null)
            {
                QuanLyKatinatContext con = new QuanLyKatinatContext();
                int selectedFoodId = ((Food)cbxFood.SelectedItem).Id;
                int availableQuantity = con.Foods.Where(x => x.Id == selectedFoodId).Select(x => x.Num).FirstOrDefault();

                if (lblAvailableQuantity != null)
                {
                    lblAvailableQuantity.Text = $"Available: {availableQuantity}";
                    if (availableQuantity < 10)
                    {
                        lblAvailableQuantity.ForeColor = Color.Red;
                        lblAvailableQuantity.Text += " - Almost out of order";
                    }
                    else
                    {
                        lblAvailableQuantity.ForeColor = DefaultForeColor; // Reset to default color
                    }
                }
                UpdateNumericUpDownMinMax(1, availableQuantity);

            }
        }
        private void UpdateNumericUpDownMinMax(int minValue, int maxValue)
        {
            // Set the minimum and maximum values for the NumericUpDown control
            nmFoodCount.Minimum = minValue;
            nmFoodCount.Maximum = maxValue;
        }
        void btn_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is int tableFood)
            {

                int tableId = tableFood;
                lsvBill.Tag = (sender as Button).Tag;
                ShowBill(tableId);
            }
        }
        void ShowBill(int id)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            //var bill = con.Bills.Select(x => x.IdTable == id && x.Status == 0) => new
            //{ 
            //    Id = ,

            //    Status = status
            //};
            //lsvBill.Items.Clear();//Xóa các item hiện tại trên ListView
            //foreach (var t in bill)
            //{
            //    var billInfo = t.BillInfos;


            //}
            var billsWithInfo = con.Bills
             .Where(x => x.IdTable == id && x.Status == 0)
               .Join(con.BillInfos, bill => bill.Id, billInfo => billInfo.IdBill, (bill, billInfo) => new
               {
                   IdBill = billInfo.IdBill,
                   IdFood = billInfo.IdFood,
                   Count = billInfo.Count
               })
            .Join(con.Foods, bill => bill.IdFood, food => food.Id, (bill, food) => new
            {
                BillId = bill.IdBill,
                FoodId = bill.IdFood,
                FoodName = food.Name,
                Quantity = bill.Count,
                Price = food.Price,
                TotalPrice = bill.Count * food.Price

            });
            double totalPriceBill = 0;


            lsvBill.Items.Clear();

            foreach (var t in billsWithInfo)
            {
                ListViewItem l = new ListViewItem(t.FoodId.ToString());
                l.SubItems.Add(t.FoodName);
                l.SubItems.Add(t.Quantity.ToString());
                l.SubItems.Add(t.Price.ToString());
                l.SubItems.Add(t.TotalPrice.ToString());
                totalPriceBill += t.TotalPrice;
                lsvBill.Items.Add(l);

            }
            //CultureInfo culture = new CultureInfo("vi-VN");
            // txbTotalBill.Text = totalPriceBill.ToString("c", culture);
            txbTotalBill.Text = totalPriceBill.ToString();
            lsvBill.Visible = true;
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (dynamic)cbxCategory.SelectedItem;
            int id = selected.Id;
            LoadFoodByCategory(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            if (lsvBill.Tag == null)
            {
                MessageBox.Show("Please choose a table");

            }
            else
            {
                int tableId = (int)lsvBill.Tag;
                Food selected = (Food)cbxFood.SelectedItem;
                int foodId = selected.Id;
                string foodName = selected.Name;
                double foodPrice = selected.Price;

                int quantity = Convert.ToInt32(nmFoodCount.Value);
                int? billId = con.Bills.Where(b => b.IdTable == tableId && b.Status == 0)
                                      .Select(b => (int?)b.Id).FirstOrDefault();
                if (billId == null)
                {
                    var table = con.TableFoods.Where(x => x.Id == tableId).FirstOrDefault();

                    Bill bill = new Bill
                    {
                        DateCheckIn = DateTime.Now,
                        DateCheckOut = DateTime.Now,
                        IdTable = tableId,
                        Status = 0,
                        Total = 0,
                        IdAccount = acc.UserName
                    };
                    BillInfo billInfo = new BillInfo
                    {
                        IdFood = foodId,
                        IdBill = bill.Id,
                        Count = quantity
                    };
                    bill.BillInfos.Add(billInfo);
                    con.Bills.Add(bill);
                    table.Status = "Full";
                    table.Bills.Add(bill);

                }
                else
                {
                    BillInfo existingBillInfo = con.BillInfos.FirstOrDefault(x => x.IdFood == foodId && x.IdBill == billId);

                    if (existingBillInfo != null)
                    {
                        existingBillInfo.Count += quantity;
                    }
                    else
                    {

                        BillInfo billInfo = new BillInfo
                        {
                            IdFood = foodId,
                            IdBill = billId.Value,
                            Count = quantity
                        };

                        con.BillInfos.Add(billInfo);



                    }

                }
                con.SaveChanges();
                LoadTable();
                ShowBill(tableId);
            }

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            if (lsvBill.Tag == null)
            {
                MessageBox.Show("Please choose a table");

            }
            else
            {
                int tableId = (int)lsvBill.Tag;
                var bill = con.Bills.FirstOrDefault(x => x.IdTable == tableId && x.Status == 0);
                // var table = con.TableFoods.FirstOrDefault(x => x.Id == tableId);
                if (bill != null)
                {
                    var table = con.TableFoods.Where(x => x.Id == tableId).FirstOrDefault();
                    bill.DateCheckOut = DateTime.Now;
                    bill.Status = 1;
                    bill.Total = Convert.ToDouble(txbTotalBill.Text);

                    var billInfos = con.BillInfos.Where(x => x.IdBill == bill.Id).ToList();
                    foreach (var billInfo in billInfos)
                    {
                        var food = con.Foods.FirstOrDefault(x => x.Id == billInfo.IdFood);
                        if (food != null)
                        {
                            food.Num -= billInfo.Count;
                        }


                    }
                    table.Status = "Empty";
                    con.SaveChanges();


                    // Save the changes to the database
                    //TẠO HÓA ĐƠN ĐỂ CHO KHÁCH
                    string folderPath = @"D:\PRN211\KATINAT\Bill";
                    string fileName = Path.Combine(folderPath, DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".txt"); using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine("HÓA ĐƠN");
                        writer.WriteLine("---------------------");
                        writer.WriteLine("Mã hóa đơn: " + bill.Id);
                        writer.WriteLine("Ngày thanh toán: " + bill.DateCheckOut);
                        writer.WriteLine("---------------------");
                        writer.WriteLine("Sản phẩm\t\t\tSố lượng\t\t\tĐơn giá\t\t\tThành tiền");
                        foreach (ListViewItem item in lsvBill.Items)
                        {
                            writer.WriteLine(item.SubItems[1].Text + "\t\t\t" + item.SubItems[2].Text + "\t\t\t" +
                                item.SubItems[3].Text + "\t\t\t\t" + item.SubItems[4].Text);
                        }
                        writer.WriteLine("---------------------");
                        writer.WriteLine("Tổng tiền: " + txbTotalBill.Text);
                    }

                    MessageBox.Show("Hóa đơn đã được lưu vào tệp " + fileName);



                    //EXCEL DOANH THU
                    string existingFilePath = "D:\\PRN211\\KATINAT\\Bill.xlsx";

                    // Mở tệp Excel đã có

                    using (var workbook = new XLWorkbook(existingFilePath))
                    {
                        var worksheet = workbook.Worksheet("Bill");

                        int lastRow = worksheet.LastRowUsed().RowNumber(); // Tìm số dòng cuối cùng đã sử dụng

                        // Tìm vị trí ô trống trong cột dữ liệu cần ghi
                        int startRow = lastRow + 1;

                        // Ghi dữ liệu từ ListView vào các ô trống
                        for (int i = 0; i < lsvBill.Items.Count; i++)
                        {
                            for (int j = 0; j < lsvBill.Items[i].SubItems.Count; j++)
                            {
                                string value = lsvBill.Items[i].SubItems[j].Text;
                                if (int.TryParse(value, out int number))
                                {
                                    var cell = worksheet.Cell(startRow + i, j + 1);
                                    cell.Value = number;

                                }
                                else
                                {
                                    worksheet.Cell(startRow + i, j + 1).Value = value;
                                }
                            }
                        }

                        workbook.Save();
                    }
                    MessageBox.Show("Data has been written to the existing Excel file.");

                    LoadTable();
                    UpdateAvailableFoodQuantity();

                    ShowBill(tableId);
                    MessageBox.Show("Checkout successful!");
                }
                else
                {
                    MessageBox.Show("No bill found for the selected table.");
                }

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxFood_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateAvailableFoodQuantity();
        }

        private void shippingSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
