using System;
using System.Collections.Generic;

namespace E_Shoppers.Data.Models
{
    public partial class t_order
    {
        public t_order()
        {
            this.t_order_line = new List<t_order_line>();
        }

        public int id { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public int customer_fk { get; set; }
        public virtual t_user t_user { get; set; }
        public virtual ICollection<t_order_line> t_order_line { get; set; }
    }
}
