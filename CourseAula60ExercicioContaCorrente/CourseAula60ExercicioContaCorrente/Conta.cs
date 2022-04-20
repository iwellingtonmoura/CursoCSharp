using System;
using System.Globalization;

namespace CourseAula60ExercicioContaCorrente
{

    public class Conta
    {

        const double TxSaque = 5.0;
        private int _numeroconta { get;  set; }
        private string _nome { get; set; }
        private double Saldo { get; set; }


        public Conta()
        {
        }



        //Construtor da classe contendo reutilização de outro construtor e utilizando o método Depositar para manter a regra em um lugar só.
        public Conta(int numeroConta, string nome, double depositoInicial): this( numeroConta, nome)
        {

            Depositar(depositoInicial);
        }

        public Conta (int numeroConta, string nome )
        {
           
            _nome = nome;
            _numeroconta = numeroConta;
  
        }


        public int NumeroConta
        {
            get { return _numeroconta; }
            set
            {
                if (value > 0)
                {
                    _numeroconta = value;
                }
            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public void Depositar(double valorDeposito)
        {

             Saldo += valorDeposito;

        }

        public void Sacar(double valorSaque)
        {

             Saldo -= valorSaque  + TxSaque;
        }


        public override string ToString()
        {
            return
           
                "Conta " + _numeroconta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }


}
