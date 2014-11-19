using System;
using System.Collections.Generic;

namespace E_Shoppers.Data.Models
{
    public partial class t_order_line
    {
        public t_order_line()
        {
            this.t_order = new List<t_order>();
        }

        public int id { get; set; }
        public int quantity { get; set; }
        public int item_fk { get; set; }
        public virtual t_product t_product { get; set; }
        public virtual ICollection<t_order> t_order { get; set; }
    }
}
