using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTecnica.Db
{
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=DSK83CWB92\SQLEXPRESS;Initial Catalog=DBListaTecnica;User ID=sa;Password=x";
            }
        }

    }
}
