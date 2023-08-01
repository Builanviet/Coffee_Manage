using System;
using System.Collections.Generic;

namespace KATINAT_COFFEE_SHOP.Models
{
    public partial class FoodShippingOrder
    {
        public int Id { get; set; }
        public int IdShippingOrder { get; set; }
        public int IdFood { get; set; }
        public int Num { get; set; }

        public virtual Food IdFoodNavigation { get; set; } = null!;
        public virtual ShippingOrder IdShippingOrderNavigation { get; set; } = null!;
    }
}
