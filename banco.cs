using System;
using System.Globalization;


namespace Exercicios
{
    internal class Banco
    {
        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public void Dep(double Quantia)
        {
            Saldo += Quantia;
        }
        public void Saq(double Quantia)
        {
            Saldo -= Quantia + 5.0;
        }

        //sld == saldo
        public Banco (string titular, int num)
        {
            Titular = titular;
            Numero = num;
        }

        public Banco(string titular, int num, double depositoinicial) : this (titular, num)
        {
            Dep(depositoinicial);
        }
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2");
        }
    }
}
