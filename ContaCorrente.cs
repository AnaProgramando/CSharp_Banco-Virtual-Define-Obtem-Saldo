using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualDefineObtemSaldo
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numConta;
        //Valor padrão do saldo inicial da conta é de 100 e não 0
        private double saldo = 100;

        //Encapsulamento do campo saldo
        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            this.saldo = saldo;            
        }
        public double ObterSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            saldo -= valor;
            return true;
        }


        //Void, pois a função não tem retorno
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                return false;
            }
            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
