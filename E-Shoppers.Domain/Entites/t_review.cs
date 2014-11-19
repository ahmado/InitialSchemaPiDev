using System;
using System.Collections.Generic;

namespace E_Shoppers.Data.Models
{
    public partial class t_review
    {
        public int id { get; set; }
        public string text { get; set; }
        public string title { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> product_fk { get; set; }
        public virtual t_product t_product { get; set; }
        public virtual t_user t_user { get; set; }
    }
}
