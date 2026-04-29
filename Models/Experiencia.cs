using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCurriculo.Models
{
    public class Experiencia
    {
        public string Empresa { get; set;} = String.Empty;

        public string Cargo { get; set;} = String.Empty;

        public string Inicio { get; set;} = String.Empty;

        public string Fim { get; set;} = "Atual";

        public string Descricao { get; set;} = String.Empty;
    }
}