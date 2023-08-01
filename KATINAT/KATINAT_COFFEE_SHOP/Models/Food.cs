using System;
using System.Collections.Generic;

namespace KATINAT_COFFEE_SHOP.Models
{
    public partial class Food
    {
        public Food()
        {
            BillInfos = new HashSet<BillInfo>();
            FoodShippingOrders = new HashSet<FoodShippingOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int IdCategory { get; set; }
        public double Price { get; set; }
        public int Num { get; set; }

        public virtual FoodCategory IdCategoryNavigation { get; set; } = null!;
        public virtual ICollection<BillInfo> BillInfos { get; set; }
        public virtual ICollection<FoodShippingOrder> FoodShippingOrders { get; set; }
    }
}
