using Livraria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Domain.Abstractions
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> ObterLivros();

        Task<Livro?> ObterLivroPorId(int id);

        Task<Livro> AdicionarLivro(Livro livro);
        Task AtualizarLivro(Livro livro);
        Task DeletarLivro(int id);
    }
}
