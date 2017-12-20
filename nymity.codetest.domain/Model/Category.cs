using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nymity.codetest.domain.Model
{
    //[DataContract]
    public class Category
    {
        //[DataMember]
        public int CategoryId { get; set; }
        //[DataMember]
        public string CategoryName { get; set; }
        //[DataMember]
        public string Description { get; set; }
        //[DataMember]
        public byte[] Picture { get; set; }
        //[DataMember]
        private ICollection<Product> products;
        //[DataMember]
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
