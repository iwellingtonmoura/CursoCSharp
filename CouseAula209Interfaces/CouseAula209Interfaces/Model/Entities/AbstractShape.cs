using System;
using CouseAula209Interfaces.Model.Enums;
namespace CouseAula209Interfaces.Model.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
