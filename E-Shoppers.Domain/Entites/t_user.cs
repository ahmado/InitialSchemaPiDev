using System;
using System.Collections.Generic;

namespace E_Shoppers.Data.Models
{
    public partial class t_user
    {
        public t_user()
        {
            this.t_message = new List<t_message>();
            this.t_order = new List<t_order>();
            this.t_product = new List<t_product>();
            this.t_review = new List<t_review>();
        }

        public string DTYPE { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> registerdate { get; set; }
        public string type { get; set; }
        public string username { get; set; }
        public Nullable<int> rate { get; set; }
        public Nullable<bool> status { get; set; }
        public string name { get; set; }
        public Nullable<float> solde { get; set; }
        public virtual ICollection<t_message> t_message { get; set; }
        public virtual ICollection<t_order> t_order { get; set; }
        public virtual ICollection<t_product> t_product { get; set; }
        public virtual ICollection<t_review> t_review { get; set; }
    }
}
