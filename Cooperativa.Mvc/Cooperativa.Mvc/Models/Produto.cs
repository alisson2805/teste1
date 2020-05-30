using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperativa.Mvc.Models
{
    //[Table("Produtos")]
    public class Produto
    {
        
        public int ProdutoId { get; }

        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use apenas letras.")]
        //[Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }

        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use apenas letras.")]
        //[Column(TypeName = "varchar(50)")]
        public string Tipo { get; set; }

        [Required, RegularExpression(@"\d*[1-9]\d*", ErrorMessage = "Por favor, insira somente números.")]
        //[Column(TypeName = "decimal(3,2)")]
        public decimal Valor { get; set; }

        [Required, RegularExpression(@"\d*[1-9]\d*", ErrorMessage = "Por favor, insira somente números.")]
        //[Column(TypeName = "decimal(3,3)")]
        public decimal Quantidade { get; set; }

        public Produto() { }

        public Produto(string nome) 
        {
            this.Nome = nome;
        }
    }
}