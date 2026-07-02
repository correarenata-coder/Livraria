using Livraria.Domain.Enumeracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Livraria.Domain.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        [Required(ErrorMessage ="Informe o título do livro")]
        [StringLength(150)]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "Informe o autor do livro")]
        [StringLength(200)]
        public string? Autor { get; set; }

        [Required(ErrorMessage = "Informe a data de lançamento")]
        [StringLength(200)]
        public DateTime Lancamento { get; set; }

        [Required(ErrorMessage = "Informe a imagem da capa")]
        [StringLength(200)]
        public string? Capa { get; set; }

        [Required]
        [EnumDataType(typeof(Editora), ErrorMessage = "Informe a editora do livro")]
        public Editora Editora { get; set; }
        [Required]
        [EnumDataType(typeof(Categoria), ErrorMessage = "Informe a categoria do livro")]
        public Categoria Categoria { get; set; }



        public Livro(
            int livroId,
            string? titulo,
            string? autor,
            DateTime lancamento,
            string? capa,
            Editora editora,
            Categoria categoria)
        {
            LivroId = livroId;
            Titulo = titulo;
            Autor = autor;
            Lancamento = lancamento;
            Capa = capa;
            Editora = editora;
            Categoria = categoria;
        }

    }
}
