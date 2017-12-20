using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nymity.codetest.domain.Model
{
    //[DataContract]
    public class Product
    {
        //[DataMember]
        public int ProductId { get; set; }
        //[DataMember]
        public string ProductName { get; set; }
        //[DataMember]
        public int? SupplierId { get; set; }
        //[DataMember]
        public int? CategoryId { get; set; }
        //[DataMember]
        public string QuantityPerUnit { get; set; }
        //[DataMember]
        public decimal? UnitPrice { get; set; }
        //[DataMember]
        public short? UnitsInStock { get; set; }
        //[DataMember]
        public short? UnitsOnOrder { get; set; }
        //[DataMember]
        public short? ReorderLevel { get; set; }
        //[DataMember]
        public bool Discontinued { get; set; }
        //[DataMember]
        public virtual Category Category { get; set; }
        //[DataMember]
        public virtual Supplier Supplier { get; set; }

        public Product()
        {
            //UnitPrice = 0m;
            //UnitsInStock = 0;
            //UnitsOnOrder = 0;
            //ReorderLevel = 0;
            //Discontinued = false;
        }
    }
}
