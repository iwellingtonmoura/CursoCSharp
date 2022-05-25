using System;
namespace CouseAula219ColecaoHashComparacaoIgualdade.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {

            if(!(obj is Product))
            {
                return false;
            }

            //Downcast do objeto
            Product other = obj as Product;

          return ((Product)obj).Name.Equals(other.Name) && Price.Equals(other.Price);

        }
    }
}
