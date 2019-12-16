using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.ViewModels
{
    public class ProdutoViewModel
    {

        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }
    }
}