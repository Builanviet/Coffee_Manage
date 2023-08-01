using System;
using System.Collections.Generic;

namespace KATINAT_COFFEE_SHOP.Models
{
    public partial class ShippingOrder
    {
        public ShippingOrder()
        {
            FoodShippingOrders = new HashSet<FoodShippingOrder>();
            ShippingOrderNotes = new HashSet<ShippingOrderNote>();
        }

        public int Id { get; set; }
        public DateTime DateCheckIn { get; set; }
        public DateTime DateCheckOut { get; set; }
        public int Status { get; set; }
        public string IdRequest { get; set; } = null!;
        public string? IdConfirm { get; set; }

        public virtual Account? IdConfirmNavigation { get; set; }
        public virtual Account IdRequestNavigation { get; set; } = null!;
        public virtual ICollection<FoodShippingOrder> FoodShippingOrders { get; set; }
        public virtual ICollection<ShippingOrderNote> ShippingOrderNotes { get; set; }
    }
}
