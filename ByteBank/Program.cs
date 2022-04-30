using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerencioadorBonificacao gerenciador = new GerencioadorBonificacao();  

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.Cpf = "546.879.157-20";
            carlos.Salario = 2000;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.Cpf = "454.658.148-3";
            roberta.Salario = 5000;

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetObterBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine("Total da Bonificação: " + gerenciador.TotalBonificacao());

        }
    }
}
