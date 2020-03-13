using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio11032020.Data
{
    class Configuracao
    {
        public string StringConfiguracao { get; set; }

        public Configuracao()
        {
            StringConfiguracao = ConfigurationManager.ConnectionStrings["DB_IMC"].ConnectionString;
        }
    }
}
