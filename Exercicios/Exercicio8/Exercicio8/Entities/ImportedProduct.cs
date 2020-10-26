using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio8.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice() + " (Customs fee: $ " + CustomsFee.ToString("F2") + ")";
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }
    }
}
