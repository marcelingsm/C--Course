using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLabel.entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(String name,double price, double customsFee)
            :base(name,price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
        public override String Pricetag()
        {
            return
        }
    }
}
