using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.XML.ParseToClass.DTOs
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
    }
}
