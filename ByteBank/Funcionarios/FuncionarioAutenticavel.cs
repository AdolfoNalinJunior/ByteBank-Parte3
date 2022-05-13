using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
/*
 * Para que o sistema fique mais organizado, o professor cria uma classe 
 * que recebe a herança da classe Funcionario e cria também a FuncionarioAutenticavel.
 * 
 * Na classe Autenticavel é faz a mudança para interface.
 * 
 * Essa mudança ou a criação da interface é necessario quando você precisa que a classe
 * que você vai passar tenha esse método atribuido e também por conta que o C# não aceita
 * uma classe ter duas classes pai, quando você passa isso para um classe você está obrigando 
 * que isso seja feito.
 * 
 * Dentro da própria interface você tem que colocar dessa maneira para que seja válido: 
 * 
 *     public interface IAutenticavel 
    {
        bool Autenticar(string senha);
    }

    Repare que não tem o nome classe é somente interface, e quando é atribuido um médoto
    ele já é automaticamente público e não possui bloco com o corpo, dentro dos parentes você pode
    colocar atributos que na classe que vai ser passada é obrigadorio ser colocada.

    OBS: Quando for criada um intermaface é muito importante que seja colocado I para ajudar na itentificação
    Lembrando também que na onde para passar uma herença e uma interface, que depentendo do projeto pode ser várias,
    é sempre a classe que vai ser passada a herança e depois as interfaces 
 */