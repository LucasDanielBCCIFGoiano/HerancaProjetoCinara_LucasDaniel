using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaCinaraProjetoLucasDaniel
{
    public class Aluno : Pessoa
    {
        public int Matricula;

        public void Estudar()
        {
            Console.WriteLine(Nome + " está estudando.");
        }
    }
}
