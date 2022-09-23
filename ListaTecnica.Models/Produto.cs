using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTecnica.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Versao { get; set; }
        public List<Caderno> Cadernos { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string tipo, string versao, List<Caderno> cadernos)
        {
            Id = id;
            Tipo = tipo;
            Versao = versao;
            Cadernos = cadernos;
        }
    }
}
