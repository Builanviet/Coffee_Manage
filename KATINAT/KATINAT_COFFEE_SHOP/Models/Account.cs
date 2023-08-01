using System;
using System.Collections.Generic;

namespace KATINAT_COFFEE_SHOP.Models
{
    public partial class Account
    {
        public Account()
        {
            Bills = new HashSet<Bill>();
            ShippingOrderIdConfirmNavigations = new HashSet<ShippingOrder>();
            ShippingOrderIdRequestNavigations = new HashSet<ShippingOrder>();
        }

        public string UserName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public int Type { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<ShippingOrder> ShippingOrderIdConfirmNavigations { get; set; }
        public virtual ICollection<ShippingOrder> ShippingOrderIdRequestNavigations { get; set; }
    }
}
