using System;
namespace CouseAula204AlugueldeCarrosSemInterface.Entities
{
    public class Vehicle
    {
        public string Model { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
