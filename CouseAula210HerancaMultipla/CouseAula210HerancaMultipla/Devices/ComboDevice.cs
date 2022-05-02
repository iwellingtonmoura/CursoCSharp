using System;
namespace CouseAula210HerancaMultipla.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {

        //Implementa IPrinter
        public void Print(string document)
        {
            Console.WriteLine("Combodevice print " + document);
        }

        //Implementa Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combodevice processing " + document);
        }

        //Implementa IScanner
        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
