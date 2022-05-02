using System;
namespace CouseAula210HerancaMultipla.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
