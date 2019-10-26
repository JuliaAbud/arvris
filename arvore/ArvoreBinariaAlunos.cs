using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvore
{
    class ArvoreBinariaAlunos
    {
        public Aluno raiz; // referência à raiz da árvore.
                           
public ArvoreBinariaAlunos()
        {
            raiz = null;
        }
     
        public Boolean arvoreVazia()
        {
          
            if (raiz == null)
             return true;
          
             else return false;
        }
        private Aluno adicionar(Aluno raizArvore, Aluno alunoNovo)
        {
            if (raizArvore == null)
                raizArvore = alunoNovo;
            else
            {
                if (raizArvore.numMatricula > alunoNovo.numMatricula)
                    raizArvore.esquerda = adicionar(raizArvore.esquerda, alunoNovo);
                else
                {
                    if (raizArvore.numMatricula < alunoNovo.numMatricula)
                        raizArvore.direita = adicionar(raizArvore.direita, alunoNovo);
                    else Console.WriteLine("O aluno {0}, cuja matrícula é {1},já foi inserido anteriormente.", alunoNovo.nome, alunoNovo.numMatricula);
                }
            }
            return raizArvore;
        }

        public void inserir(Aluno alunoNovo)
        {
            raiz = adicionar(raiz, alunoNovo);
        }

        private Aluno antecessor(Aluno alunoRetirar, Aluno raizArvore)
        {
            if (raizArvore.direita != null)
            {
                raizArvore.direita = antecessor(alunoRetirar, raizArvore.direita);
                return raizArvore;
            }
            else
            {
                alunoRetirar.numMatricula = raizArvore.numMatricula;
                alunoRetirar.nome = raizArvore.nome;
                alunoRetirar.nota = raizArvore.nota;
                return raizArvore.esquerda;

            }
        }

        private Aluno retirar(Aluno raizArvore, int matricula)
        {
            if (raizArvore == null)
            {
                Console.WriteLine("O aluno, cuja matrícula é {0}, não foi encontrado.", matricula);
                    return raizArvore;
            }
            else
            {
                if (raizArvore.numMatricula == matricula)
                {
                    if (raizArvore.direita == null)
                        return (raizArvore.esquerda);
                    else if (raizArvore.esquerda == null) return (raizArvore.direita);
                    else
                    {
                        raizArvore.esquerda = antecessor(raizArvore,raizArvore.esquerda);
                        return (raizArvore);
                    }
                }
                else if (raizArvore.numMatricula > matricula) raizArvore.esquerda = retirar(raizArvore.esquerda,matricula);
                else raizArvore.direita = retirar(raizArvore.direita, matricula);
                return raizArvore;
            }
        }

        public void remover(int matriculaRemover)
        {
            raiz = retirar(raiz, matriculaRemover);
        }


        public Aluno pesquisar(Aluno raizArvore, int matricula)
        {
            if (raizArvore.esquerda == null && raizArvore.direita == null)
            {
                return null;
            }
            if (raizArvore.numMatricula == matricula)
            {
                return raizArvore;
            } else
            {
                if (raizArvore.numMatricula > matricula)
                {
                    return pesquisar(raizArvore.esquerda, matricula);
                } else
                {
                    return pesquisar(raizArvore.direita, matricula);
                }
            }
        }





    }
}
