using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTecnica.Models
{
    public class Caderno
    {
        public int Id { get; set; }
        public string Elemento { get; set; }
        public int QtdPaginas { get; set; }
        public string TipoDePapel { get; set; }
        public int Gramatura { get; set; }
        public double KgBrutoPapel { get; set; }


        public Caderno()
        {

        }

        public Caderno(int id, string elemento, int qtdPaginas, string tipoDePapel, int gramatura)
        {
            Id = id;
            Elemento = elemento;
            QtdPaginas = qtdPaginas;
            TipoDePapel = tipoDePapel;
            Gramatura = gramatura;
            KgBrutoPapel = CalculoPapelBruto();
        }

        public double CalculoPapelBruto()
        {
            return 1 + 1;
        }
    }
}
