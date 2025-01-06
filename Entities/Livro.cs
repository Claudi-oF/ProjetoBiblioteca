using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Entities
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        
        //ISBN = padrão numérico criado com o objetivo de fornecer uma espécie de "RG" para
        //publicações monográficas, como livros, artigos e apostilas.
        public int Isbn { get; set; }
        public string Categoria { get; set; }
    }
}
