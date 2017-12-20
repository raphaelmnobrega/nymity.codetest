using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nymity.codetest.domain.Model
{
    //[DataContract]
    public class Supplier
    {
        //[DataMember]
        public int SupplierId { get; set; }
        //[DataMember]
        public string CompanyName { get; set; }
        //[DataMember]
        public string ContactName { get; set; }
        //[DataMember]
        public string ContactTitle { get; set; }
        //[DataMember]
        public string Address { get; set; }
        //[DataMember]
        public string City { get; set; }
        //[DataMember]
        public string Region { get; set; }
        //[DataMember]
        public string PostalCode { get; set; }
        //[DataMember]
        public string Country { get; set; }
        //[DataMember]
        public string Phone { get; set; }
        //[DataMember]
        public string Fax { get; set; }
        //[DataMember]
        public string HomePage { get; set; }
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
