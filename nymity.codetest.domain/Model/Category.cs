using System.Collections.Generic;

namespace nymity.codetest.domain.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        private ICollection<Product> _products;
        public virtual ICollection<Product> Products
        {
            get
            {
                if (_products == null)
                    _products = new List<Product>();
                return _products;

            }
            set { _products = value; }
        } 
    }
}
