using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MestreDetalhe1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // Vendas
        public virtual List<Venda> Vendas { get; set; }
    }
}