﻿
using System;

namespace ProductLabel.entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name + "(used) $ " + Price + "(Manufacture date: " + ManufactureDate + ")";
        }
    }
}
