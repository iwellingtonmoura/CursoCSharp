using System;
using System.Globalization;

namespace CourseAula215RestricaoGenericsIComparable.Entities
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public override string ToString()
        {
            return Name
                    + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Erro de comparação entre os objetos");
            }

            Product other = obj as Product;

            return Price.CompareTo(((Product)other).Price); 
        }
    }
}
