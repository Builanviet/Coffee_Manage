using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using KATINAT_COFFEE_SHOP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KATINAT_COFFEE_SHOP
{
    public partial class fAdmin : Form
    {
        private Account acc;
        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public fAdmin(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
            loadAccount();
            loadTable();
            LoadDateTimePickerBill();
            LoadDateTime(dtpFromDate.Value, dtpToDate.Value);
            loadFood();
            LoadCategoryInfo();
            loadCategory();
            LoadCategoryCombobox();
            UpdateDataGridViewOrder();
            txbOrderBy.Text = acc.DisplayName;
            LoadOrdersToDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void LoadDateTime(DateTime a, DateTime b)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var bi = con.Bills.Where(x => x.Status == 1 && x.DateCheckIn.CompareTo(a) >= 1 && x.DateCheckOut.CompareTo(b) <= 1)
                  .Join(con.TableFoods, bi => bi.IdTable, ta => ta.Id, (bi, ta) => new
                  {
                      Name = ta.Name,
                      DateCheckIn = bi.DateCheckIn,
                      DateCheckOut = bi.DateCheckOut,
                      Total = bi.Total

                  });

            dgvRevenue.DataSource = bi.ToList();

        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        private void loadAccount()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var ac = con.Accounts.Select(x => new
            {
                UserName = x.UserName,
                Name = x.DisplayName,
                Password = x.PassWord,
                Type = x.Type
            });
            dgvAccount.DataSource = ac.ToList();
        }
        private void loadFood()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();


            var ta = con.Foods.Join(con.FoodCategories, fo => fo.IdCategory, fc => fc.Id, (fo, fc) => new
            {
                Id = fo.Id,
                Name = fo.Name,
                Category = fc.Name,
                Price = fo.Price,
                Quantity = fo.Num
            });
            dgvFood.DataSource = ta.ToList();
            //foreach (DataGridViewRow row in dgvFood.Rows)
            //{
            //    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
            //    if (quantity < 10)
            //    {
            //        // Thay đổi màu nền của dòng có Quantity < 10 thành màu đỏ
            //        row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;

            //        // Hiển thị thông báo cảnh báo
            //        MessageBox.Show($"Sản phẩm {row.Cells["Name"].Value} chỉ còn {quantity} món!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }
        private void loadCategory()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var ca = con.FoodCategories.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,

            });
            dgvCategoy.DataSource = ca.ToList();
        }

        private void loadTable()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var ta = con.TableFoods.Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Status = x.Status

            });
            dgvTable.DataSource = ta.ToList();
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                txbAccountUserName.Text = row.Cells["UserName"].Value.ToString();
                txbAccountName.Text = row.Cells["Name"].Value.ToString();
                txbAccountType.Text = row.Cells["Type"].Value.ToString();
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {

            DateTime from = dtpFromDate.Value;
            DateTime to = dtpToDate.Value;
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            if (from.CompareTo(to) >= 0)
            {
                MessageBox.Show("From needs to be smaller than to");
            }
            else
            {
                var bi = con.Bills.Where(x => x.Status == 1 && x.DateCheckIn.CompareTo(from) >= 1 && x.DateCheckOut.CompareTo(to) <= 1)
                    .Join(con.TableFoods, bi => bi.IdTable, ta => ta.Id, (bi, ta) => new
                    {
                        Name = ta.Name,
                        DateCheckIn = bi.DateCheckIn,
                        DateCheckOut = bi.DateCheckOut,
                        Total = bi.Total

                    });


                dgvRevenue.DataSource = bi.ToList();


            }

        }
        private void LoadCategoryInfo()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var ca = con.FoodCategories.Select(x => new
            {
                Id = x.Id,
                Name = x.Name

            }).ToList();

            cbxFoodCategory.DataSource = ca;
            cbxFoodCategory.DisplayMember = "Name";
            cbxFoodCategory.ValueMember = "Id";
        }
        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFood.Rows[e.RowIndex];
                txbId.Text = row.Cells["Id"].Value.ToString();
                txbFoodName.Text = row.Cells["Name"].Value.ToString();
                string selectedCategory = row.Cells["Category"].Value.ToString();

                foreach (var item in cbxFoodCategory.Items)
                {
                    if (item.GetType().GetProperty("Name")?.GetValue(item, null).ToString() == selectedCategory)
                    {
                        cbxFoodCategory.SelectedItem = item;
                        break;
                    }
                }

                // txbFoodCategory.Text = row.Cells["Category"].Value.ToString();
                string priceString = row.Cells["Price"].Value.ToString();
                if (float.TryParse(priceString, out float price))
                {
                    nmFoodPrice.Value = (decimal)price;
                }
                else
                {
                    MessageBox.Show("INvalid price");
                }

                nmQuantity.Value = Convert.ToInt32(row.Cells["quantity"].Value.ToString());


            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            string name = txbFoodName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Food name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double price = 0;

            price = float.Parse(nmFoodPrice.Value.ToString());
            if (price <= 0)
            {
                MessageBox.Show("Food price can not be less than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int num = Int32.Parse(nmQuantity.Value.ToString());
            int idCategory = Convert.ToInt32(cbxFoodCategory.SelectedValue);

            Food newFood = new Food
            {
                Name = name,
                Price = price,
                IdCategory = idCategory,
                Num = num,
            };
            con.Foods.Add(newFood);
            con.SaveChanges();
            UpdateDataGridViewOrder();
            loadFood();

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {

            QuanLyKatinatContext con = new QuanLyKatinatContext();
            if (string.IsNullOrEmpty(txbId.Text))
            {
                MessageBox.Show("PLease choose a food to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(txbId.Text.ToString());
            string name = txbFoodName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Food name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double price = 0;

            price = float.Parse(nmFoodPrice.Value.ToString());
            if (price <= 0)
            {
                MessageBox.Show("Food price can not be less than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idCategory = Convert.ToInt32(cbxFoodCategory.SelectedValue);

            var existingFood = con.Foods.FirstOrDefault(f => f.Id == id);
            existingFood.Name = name;
            existingFood.Price = price;
            existingFood.IdCategory = idCategory;
            con.SaveChanges();

            loadFood();
            MessageBox.Show("SUccess");


        }

        private void dgvCategoy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategoy.Rows[e.RowIndex];
                txbCategoryID.Text = row.Cells["Id"].Value.ToString();
                txbCategoryName.Text = row.Cells["Name"].Value.ToString();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            FoodCategory category = new FoodCategory();
            var fo = con.FoodCategories.Where(x => x.Name.Equals(txbCategoryName.Text)).FirstOrDefault();
            if (fo != null)
            {
                MessageBox.Show("This drink has been existed");
            }
            else
            {
                category.Name = txbCategoryName.Text;
                con.FoodCategories.Add(category);

                MessageBox.Show("Add Successfully!");

            }
            con.SaveChanges();
            loadCategory();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var a = con.FoodCategories.Include(x => x.Foods).Where(x => x.Id == Convert.ToInt32(txbCategoryID.Text)).FirstOrDefault();
            con.FoodCategories.Remove(a);
            con.SaveChanges();
            MessageBox.Show("Delete successful!");
            loadCategory();
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            string a = txbSearchFood.Text;

            var foods = con.Foods.Where(x => x.Name.Contains(a)).Select(x => new
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price
            }
            ).ToList();
            dgvFood.DataSource = foods;
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            loadFood();
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTable.Rows[e.RowIndex];
                txbTableID.Text = row.Cells["Id"].ToString();
                txbTableName.Text = row.Cells["Name"].ToString();

            }
        }

        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> lowQuantityItems = new List<string>();

            if (tcAdmin.SelectedTab == tpFood)
            {
                foreach (DataGridViewRow row in dgvFood.Rows)
                {
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    if (quantity < 10)
                    {
                        // Thay đổi màu nền của dòng có Quantity < 10 thành màu đỏ
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                        // Thêm tên sản phẩm có số lượng ít hơn 10 vào danh sách
                        string itemName = row.Cells["Name"].Value.ToString();
                        lowQuantityItems.Add(itemName);
                    }
                    else
                    {
                        // Nếu Quantity >= 10, đặt lại màu nền về mặc định
                        row.DefaultCellStyle.BackColor = dgvFood.DefaultCellStyle.BackColor;
                    }
                }
            }
            if (lowQuantityItems.Any())
            {
                // Hiển thị thông báo cảnh báo với danh sách các sản phẩm có số lượng ít hơn 10
                string message = $"There are some drinks that are almost out of order. Need to supply now:{Environment.NewLine}{string.Join(Environment.NewLine, lowQuantityItems)}";
                var result = MessageBox.Show(message + Environment.NewLine + "Do you want to have a supply order now?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Nếu người dùng chọn "Yes," chuyển sang tab "Shipping order"
                    tcAdmin.SelectedTab = tpShippingOrder;
                }
            }
        }


        //SHIPPING ORDER
        List<Food> foodOrders = GetFoodsBelow10();


        private void LoadCategoryCombobox()
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

        private void LoadFoodByCategoryCombobox(int id)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var fo = con.Foods.Where(x => x.IdCategory == id).ToList();
            cbxFood.DataSource = fo;
            cbxFood.DisplayMember = "Name";
            cbxFood.ValueMember = "Id";

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (dynamic)cbxCategory.SelectedItem;
            int id = selected.Id;
            LoadFoodByCategoryCombobox(id);
        }
        private void dgvOrder_Update(object sender, EventArgs e)
        {

            dgvOrder.DataSource = null; // Đặt DataSource về null trước khi gán mới để tránh lỗi
            dgvOrder.DataSource = foodOrders;

            // Cập nhật lại hiển thị của DataGridView
            dgvOrder.Refresh();

        }

        // Phương thức để lấy danh sách các món ăn có số lượng dưới 10 từ cơ sở dữ liệu
        private static List<Food> GetFoodsBelow10()
        {
            using (QuanLyKatinatContext con = new QuanLyKatinatContext())
            {
                return con.Foods.Where(x => x.Num < 10).ToList();
            }
        }

        // Hàm này được gọi khi có thay đổi trong dữ liệu món ăn (ví dụ: số lượng thay đổi hoặc có món mới có số lượng dưới 10)
        private void UpdateDataGridViewOrder()
        {
            // Gọi sự kiện cập nhật DataGridView
            dgvOrder_Update(null, EventArgs.Empty);
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrder.Rows[e.RowIndex];
                string foodName = row.Cells["Name"].Value.ToString();
                int foodId = Convert.ToInt32(row.Cells["Id"].Value);
                int foodQuantity = Convert.ToInt32(row.Cells["Num"].Value);


                cbxFood.SelectedValue = foodId;
                nmFoodCount.Value = foodQuantity;
                cbxCategory.SelectedValue = Convert.ToInt32(row.Cells["IdCategory"].Value);


            }
        }

        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            Food selected = (Food)cbxFood.SelectedItem;
            int num = Int32.Parse(nmFoodCount.Value.ToString());
            Food existingFood = foodOrders.FirstOrDefault(food => food.Id == selected.Id);

            if (existingFood != null)
            {
                // If the food already exists in the list, update its quantity
                existingFood.Num = num;
            }
            else
            {

                foodOrders.Add(new Food
                {
                    Id = selected.Id,
                    Name = selected.Name,
                    Price = selected.Price,
                    IdCategory = selected.IdCategory,
                    Num = num,
                    IdCategoryNavigation = selected.IdCategoryNavigation,
                    BillInfos = selected.BillInfos,
                });


            }
            UpdateDataGridViewOrder();
            // Update the DataGridView with the updated foodOrders list

        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            ShippingOrder newShippingOrder = new ShippingOrder
            {
                DateCheckIn = DateTime.Now,
                DateCheckOut = DateTime.Now,
                Status = 0,
                IdRequest = acc.UserName
            };
            con.ShippingOrders.Add(newShippingOrder);
            con.SaveChanges();
            int id = newShippingOrder.Id;
            MessageBox.Show(id.ToString());
            foreach (var order in foodOrders)
            {
                con.FoodShippingOrders.Add(new FoodShippingOrder
                {
                    IdShippingOrder = id,
                    IdFood = order.Id,
                    Num = order.Num,
                });
            }
            con.SaveChanges();
            string note = "";
            if (String.IsNullOrEmpty(txbNote.Text))
            {
                note = "";
            }
            else
            {
                note = txbNote.Text;
            }
            con.ShippingOrderNotes.Add(new ShippingOrderNote
            {
                IdShippingOrder = newShippingOrder.Id,
                Note = note,
                NoteDate = DateTime.Now,
            });
            con.SaveChanges();
            MessageBox.Show("Send Request Successfully");
            foodOrders = new List<Food>();
            LoadOrdersToDataGridView();
        }
        private List<ShippingOrder> GetOrdersFromDatabase()
        {
            using (QuanLyKatinatContext con = new QuanLyKatinatContext())
            {
                return con.ShippingOrders.ToList();
            }
        }

        // Gán danh sách order vào DataGridView
        private void LoadOrdersToDataGridView()
        {
            QuanLyKatinatContext con = new QuanLyKatinatContext();
            var orders = con.ShippingOrders.Select(x => new
            {
                Id = x.Id,
                DateCheckIn = x.DateCheckIn,
                DateCheckOut = x.DateCheckOut,
                Status = x.Status == 0 ? "pending" : (x.Status == 1 ? "doing" : "done")


            }).ToList();
            dgvShippingOrderList.DataSource = null;
            dgvShippingOrderList.DataSource = orders;
        }

        // Gọi hàm để tải dữ liệu vào DataGridView khi form được hiển thị
        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadOrdersToDataGridView();
        }

        private void dgvShippingOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                DataGridViewRow row = dgvShippingOrderList.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(row.Cells["Id"].Value);

                // Mở form chi tiết và hiển thị thông tin order
                OrderDetailForm detailForm = new OrderDetailForm(orderId);
                detailForm.ShowDialog();
            }
        }
    }
}
