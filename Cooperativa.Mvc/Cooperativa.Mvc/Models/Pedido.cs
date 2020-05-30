using Cooperativa.Mvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperativa.Mvc.Models
{
    //[Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; }


        public int IdCliente { get; set; }

        public List<Produto> Produtos { get; set; }

        public double ValorTotal { get; set; }

    }
}