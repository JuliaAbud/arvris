using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvore
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[300];
            ArvoreBinariaAlunos arvore = new ArvoreBinariaAlunos();
            for (int i = 0; i < 300; i++)
            {
                alunos[i] = new Aluno(i, "Jarvan " + i, 0);
            }
            arvore.inserir(alunos[300/2]);
            for (int i = 149; i > 0; i--)
            {
                arvore.inserir(alunos[i]);
               
            }
            for (int i = 151; i < 300; i++)
            {
                arvore.inserir(alunos[i]);
               
            }

            Console.WriteLine(arvore.pesquisar(alunos[150], 2).nome);
            Console.ReadKey();

        }
    }
}
