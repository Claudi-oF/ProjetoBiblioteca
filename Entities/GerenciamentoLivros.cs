using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Entities
{
    class GerenciamentoLivros
    {
        public Livro Livro { get; set; }

        public HashSet<Livro> Livros { get; set; } = new HashSet<Livro>();

        public void adicionarLivro()
        {
            Livro novoLivro = new Livro();

            Console.Write("Título: ");
            novoLivro.Titulo = Console.ReadLine();
            Console.Write("Autor: ");
            novoLivro.Autor = Console.ReadLine();
            Console.Write("ISBN: ");
            novoLivro.Isbn = int.Parse(Console.ReadLine());
            Console.Write("Categoria: ");
            novoLivro.Categoria = Console.ReadLine();
            
            Livros.Add(novoLivro);
            Console.WriteLine("Livro adicionado com sucesso!");
        }

        public void listarLivros()
        {
            if(Livros.Count > 0)
            {
                foreach (var livro in Livros)
                {
                    Console.WriteLine(livro.Titulo);
                }
            }
        }

        public void editarLivro()
        {
            Console.Write("Digite o ISBN do livro para a busca: ");
            int isbn = int.Parse(Console.ReadLine());

            if(Livros.Count > 0)
            {
                foreach (var livro in Livros)
                {
                    if(livro.Isbn == isbn)
                    {
                        Console.Write("Novo Título: ");
                        livro.Titulo = Console.ReadLine();
                        Console.Write("Novo Autor: ");
                        livro.Autor = Console.ReadLine();
                        Console.Write("Nova Categoria: ");
                        livro.Categoria = Console.ReadLine();
                    } 
                }
            }
        }

        public void removerLivro()
        {
            Console.Write("Digite o ISBN do livro para a remoção: ");
            int isbn = int.Parse(Console.ReadLine());

            if (Livros.Count > 0)
            {
                foreach (var livro in Livros)
                {
                    if (livro.Isbn == isbn)
                    {
                        Livros.Remove(livro);
                    }
                }
                Console.WriteLine("Livro removido!");
            }
        }

    }
}
