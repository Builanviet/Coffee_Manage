using System;
using System.Collections.Generic;

namespace KATINAT_COFFEE_SHOP.Models
{
    public partial class ShippingOrderNote
    {
        public int Id { get; set; }
        public int IdShippingOrder { get; set; }
        public string Note { get; set; } = null!;
        public DateTime NoteDate { get; set; }

        public virtual ShippingOrder IdShippingOrderNavigation { get; set; } = null!;
    }
}
