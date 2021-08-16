using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaCinaraProjetoLucasDaniel
{
    public class Funcionario : Pessoa
    {        
        public string Departamento;
        
        public void Trabalhar()
        {
            Console.WriteLine($"{Nome} está trabalhando no departamento {Departamento}");
        }
    }
}
