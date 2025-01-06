using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBiblioteca.Entities;

namespace ProjetoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            while (numero != 5)
            {
                Console.WriteLine("========= Projeto Biblioteca =========");
                Console.WriteLine("Digite a opção que preferir: ");
                Console.WriteLine("1. Adicionar livro");
                Console.WriteLine("2. Listar livros");
                Console.WriteLine("3. Editar livros");
                Console.WriteLine("4. Remover livro");
                Console.WriteLine("5. Sair");

                GerenciamentoLivros gerenciamento = new GerenciamentoLivros();
                numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        gerenciamento.adicionarLivro();
                        break;
                    case 2:
                        gerenciamento.listarLivros();
                        break;
                    case 3:
                        gerenciamento.editarLivro();
                        break;
                    case 4:
                        gerenciamento.removerLivro();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}
