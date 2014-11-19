using System;
using System.Collections.Generic;

namespace E_Shoppers.Data.Models
{
    public partial class t_category
    {
        public t_category()
        {
            this.t_product = new List<t_product>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<t_product> t_product { get; set; }
    }
}
