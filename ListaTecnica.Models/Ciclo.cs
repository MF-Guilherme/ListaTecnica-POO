using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTecnica.Models
{
    public class Ciclo
    {
        public int Id { get; set; }
        public string Campanha { get; set; }
        public List<Produto> Produtos { get; set; }

        public Ciclo(int id, string campanha, List<Produto> produtos)
        {
            Id = id;
            Campanha = campanha;
            Produtos = produtos;
        }
    }
}
