using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualDefineObtemSaldo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine("Banco Virtual - Definir e Obter Saldo: \r\n");

            // Conforme a regra criada na classe ContaCorrente, o saldo não pode ser menor que zero, por isso ele assume o saldo definido como padrão, ou seja, o 100.
            conta.DefinirSaldo(-200);
            Console.WriteLine("O saldo da conta é R$ " + conta.ObterSaldo() + ".");

            Console.ReadLine();
        }
    }
}
