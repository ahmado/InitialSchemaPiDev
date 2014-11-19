using System;
using System.Collections.Generic;

namespace E_Shoppers.Data.Models
{
    public partial class t_product
    {
        public t_product()
        {
            this.t_order_line = new List<t_order_line>();
            this.t_review = new List<t_review>();
        }

        public int id { get; set; }
        public string detail { get; set; }
        public Nullable<float> price { get; set; }
        public int quantity { get; set; }
        public string title { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<int> vendor_id { get; set; }
        public virtual t_category t_category { get; set; }
        public virtual ICollection<t_order_line> t_order_line { get; set; }
        public virtual ICollection<t_review> t_review { get; set; }
        public virtual t_user t_user { get; set; }
    }
}
