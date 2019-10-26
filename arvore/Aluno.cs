using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvore
{
  
        class Aluno
        {
            public int numMatricula; // número de matrícula do aluno.
            public String nome; // nome do aluno.
            public Double nota; // nota do aluno.
            public Aluno direita; // referência ao aluno armazenado, na árvore de alunos, à direita do aluno em questão.
            public Aluno esquerda; // referência ao aluno armazenado, na árvore de alunos, à esquerda do aluno em questão.
                                   /// <summary>
                                   /// Construtor da classe.
                                   /// Esse construtor cria um novo objeto da classe Aluno atribuindo esse objeto os seguintes valores:
                                   /// /// -- numMatricula recebe o valor que foi passado através do parâmetro matricula.
                                   /// -- nome recebe o valor que foi passado através do parâmetro nomeAluno.
                                   /// -- nota recebe o valor que foi passado através do parâmetro notaTurma.
                                   /// -- direita e esquerda recebem null.
                                   /// </summary>
                                   /// <param name="matricula"> número de matrícula do aluno que será criado. </param>
                                   /// <param name="nomeAluno"> nome do aluno que será criado. </param>
                                   /// <param name="notaTurma"> nota do aluno que será criado. </param>                       
            public Aluno(int matricula, String nomeAluno, Double notaTurma)
            {
                this.numMatricula = matricula;
                this.nome = nomeAluno;
                this.nota = notaTurma;
                this.direita = null;
                this.esquerda = null;
            }
        }
}