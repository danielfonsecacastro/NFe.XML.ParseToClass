using System;
using System.Collections.Generic;
using System.Text;

namespace NFeXML.ParseToClass.Standard.DTOs
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
        public decimal ValorICMSST { get; set; }
    }
}
