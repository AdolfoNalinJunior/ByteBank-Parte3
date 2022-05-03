using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(double salario,string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO! ");

            Cpf = cpf;

            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.10);
            //Salario = Salario * 1.10;
            Salario *= 1.10;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10; 
        }
    }
}
