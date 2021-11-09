﻿using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
           //CalcularBonificacao();
           UsarSistema();
           Console.ReadLine();

        }

        public static void UsarSistema() {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "leo";

            

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "123";

            sistemaInterno.Logar(roberta, "leo");
            sistemaInterno.Logar(camila, "123");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "dantas";
            sistemaInterno.Logar(parceiro, "danSAtas");


        }

        public static void CalcularBonificacao() {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.22.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de Bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
