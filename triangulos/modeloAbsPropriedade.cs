using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulos
{
    abstract class modeloAbsPropriedade{
        public double L1 { get; set; }
        public double L2 { get; set; }
        public double L3 { get; set; }

        public string Lado1 { get; set; }
        public string Lado2 { get; set; }
        public string Lado3 { get; set; }

        public string Mensagem { get; set; }
        public string Resposta { get; set; }
    }
}
