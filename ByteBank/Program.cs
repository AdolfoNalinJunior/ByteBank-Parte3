﻿using ByteBank.Funcionarios;
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

            Funcionario carlos = new Funcionario("546.879.157-20");
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            //roberta.Cpf = "454.658.148-3";
            roberta.Salario = 5000;

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta .GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine("Total da Bonificação: " + gerenciador.TotalBonificacao());

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

        }
    }
}
