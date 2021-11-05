using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero Conta: " + ContaCorrente.TotaldeContasCriadas);

            ContaCorrente conta = new ContaCorrente(876, 185622);

            Console.WriteLine("Numero Conta: " + ContaCorrente.TotaldeContasCriadas);
            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDoLeo = new ContaCorrente(457, 098);
            Console.WriteLine("Numero Conta: " + ContaCorrente.TotaldeContasCriadas);
            Console.WriteLine(contaDoLeo.Agencia);
            Console.WriteLine(contaDoLeo.Numero);

            Console.ReadLine();
        }
    }
}
