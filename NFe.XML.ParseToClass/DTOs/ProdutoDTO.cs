using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFeXML.ParseToClass.DTOs
{
    public class ProdutoDTO
    {
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public decimal Valor { get; set; }
        public string Codigo { get; set; }
        public string CodigoEAN { get; set; }
        public decimal Quantidade { get; set; }
        public string NCM { get; set; }
        public decimal ValorIPI { get; set; }
        public decimal ValorICMS { get; set; }
        public decimal ValorPIS { get; set; }
        public decimal ValorCOFINS { get; set; }
    }
}
