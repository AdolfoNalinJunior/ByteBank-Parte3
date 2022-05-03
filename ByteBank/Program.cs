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

            Funcionario carlos = new Funcionario(2000,"546.879.157-20");
            carlos.Nome = "Carlos";

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            carlos.AumentarSalario();
            Console.WriteLine("O salario do Carlos é: " + carlos.Salario);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            //roberta.Cpf = "454.658.148-3";
            roberta.Salario = 5000;

            roberta.AumentarSalario();
            Console.WriteLine("O salario da roberta é: " + roberta.Salario);

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta .GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine("Total da Bonificação: " + gerenciador.TotalBonificacao());

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

        }
    }
}
