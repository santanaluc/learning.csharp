using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Restricoes.Entities
{
    class Products : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Products))
            {
                throw new ArgumentException("Error comparing");
            }
            Products other = obj as Products;
            return Price.CompareTo(other.Price);
        }
    }
}
