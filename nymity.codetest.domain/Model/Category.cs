using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nymity.codetest.domain.Model
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        private ICollection<Product> products;
        public virtual ICollection<Product> Products
        {
            get
            {
                if (products == null)
                    products = new List<Product>();
                return products;

            }
            set { products = value; }
        } 
    }
}
