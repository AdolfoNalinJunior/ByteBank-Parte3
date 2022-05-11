using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public interface Autenticavel 
    {
        bool Autenticar(string senha);
    }
}

/*
 * A estrategi que o professor uso foi a seguinte: 
 * 
 * Um grupo de pessoas filtrados podem entrar no sistema interno
 * nesse caso, somente o Diretor e o Gerente de Conta.
 * 
 * Autenticável é uma classe que foi feita e moldade para ter 
 * somente métodos especificos, que atente a essas nessecidades.
 * 
 * Essa nessecidade é autorizar a entreda de um nome e uma senha no sistema interno,
 * esse sistema é somente visto pelo diretor e pelo Gerente de Conta
 * 
 * Para que isso tudo seja realizado o professor passa a herança da classe Autenticável para
 * as duas calasses que vão precisar serem logadas e passa a herança da classe Funcionario para a
 * Autenticável, para não dar erro na compilação. Esse erro é mostrado pelo compilador por conta que 
 * o Diretor e Gerente de Contas são dois funcioanrios que tem nome, salário e cpf. Que são atributos da 
 * classe funcionario, passando a herança da classe Funcionario para Autenticável, as classe que recebem a 
 * herença da classe Autenticável também vão receber a da classe Funcionario
 */
