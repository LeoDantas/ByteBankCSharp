using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            Diretor eduardo = new Diretor();

            carlos.Nome = "Carlos";
            carlos.CPF = "09277901497";
            carlos.Salario = 3000;

            gerenciador.Registrar(carlos);

            eduardo.Nome = "Eduardo";
            eduardo.CPF = "08577401269";
            eduardo.Salario = 15000;

            gerenciador.Registrar(eduardo);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(eduardo.Nome);
            Console.WriteLine(eduardo.GetBonificacao());

            Console.Write("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
