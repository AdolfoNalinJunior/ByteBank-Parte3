using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
        }

        public static void UsarSistema() 
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "1234";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12345";

            sistemaInterno.Logar(parceiro,"12345");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

                Designer pedro = new Designer("833.222.048-39");
                pedro.Nome = "Pedro";

                Diretor roberta = new Diretor("159.753.398-04");
                roberta.Nome = "Roberta";

                Auxiliar igor = new Auxiliar("981.198.778-53");
                igor.Nome = "Igor";

                GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
                camila.Nome = "Camila";

            Desenvolvedor adolfo = new Desenvolvedor("378.034.334-90");
            adolfo.Nome = "Adolfo ";

            gerenciador.Registrar(adolfo);
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciador.TotalBonificacao());
        }
    }
}
 