using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Banco
    {
        public string nombre { get; set; }
        Cliente[] clientes;
        public Banco()
        {
            clientes = new Cliente[]
            {
                new Cliente(){ nombre = "juan", edad = 18, saldo = 0 },
                new Cliente(){ nombre = "Edgar", edad = 19, saldo = 0 },
                new Cliente(){ nombre = "daniela", edad = 20, saldo = 0 },
                new Cliente(){ nombre = "Daniel", edad = 21, saldo = 0 },
                new Cliente(){ nombre = "Erick", edad = 22, saldo = 0 }

            };
        }

        public void Depositar(float deposito, int nCliente)
        {
            clientes[nCliente].saldo += deposito;
        }
        public void Imprimir(int cliente)
        {
            Console.WriteLine($"{clientes[cliente].nombre}tiene de saldo: {clientes[cliente].saldo}");
        }
    }
}
