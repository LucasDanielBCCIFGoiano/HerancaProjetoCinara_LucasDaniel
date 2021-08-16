using System;

namespace HerancaCinaraProjetoLucasDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Eduardo";
            aluno.Matricula = 12345;
            aluno.Estudar();
            aluno.Dormir();

            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Cinara";
            funcionario.Departamento = "Desenvolvimento";
            funcionario.Trabalhar();
            funcionario.Dormir();

            Console.ReadLine();
        }
    }
}
