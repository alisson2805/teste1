using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperativa.Mvc.Models
{
    //[Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; }

        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use apenas letras.")]
        public string Nome { get; set; }

        [Required, RegularExpression(@"\d*[1-9]\d*", ErrorMessage = "Por favor, insira somente números.")]
        public string Cpf { get; set; }

        [Required, RegularExpression(@"\d*[1-9]\d*", ErrorMessage = "Por favor, insira somente números.")]
        public string Telefone { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public char Numero { get; set; }

        [RegularExpression(@"\d*[1-9]\d*", ErrorMessage = "Por favor, insira somente números.")]
        public string Cep { get; set; }

        public string Complemento { get; set; }

        public int QtdePedidos { get; set; }
    }
}