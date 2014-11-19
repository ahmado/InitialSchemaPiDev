using System;
using System.Collections.Generic;

namespace E_Shoppers.Data.Models
{
    public partial class t_message
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string text { get; set; }
        public Nullable<int> customer_id { get; set; }
        public virtual t_user t_user { get; set; }
    }
}
