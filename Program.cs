using System;
using System.ComponentModel;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco conta;
            
            Console.WriteLine("Olá tudo bem? Bem-vindo(a) sua conta bancaria, vou te pedir alguns dados agora:)");
            
            Console.WriteLine();
            
            Console.Write("Entre o numero da conta, por favor: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            string Titular = Console.ReadLine();
            
            Console.Write("Havera algum deposito inicial? Por favor responder com (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double depin = double.Parse(Console.ReadLine());
                conta = new Banco(Titular, Numero, depin);
            }
            else
            {
                conta = new Banco(Titular, Numero);
            }
            Console.WriteLine();
            Console.WriteLine("dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            
            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            conta.Dep(deposito);
            Console.WriteLine("dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.WriteLine("deseja realizar o saque? por favor responder com (s/n) ");
            char respo = char.Parse(Console.ReadLine());
            if (respo == 's' || respo == 'S')
            {
                Console.Write("Entre com o valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                conta.Saq(saque);
                Console.WriteLine("dados da conta atualizados: ");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine(conta);
            }

        }
    }
}

