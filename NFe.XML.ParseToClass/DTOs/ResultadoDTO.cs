using System;
using System.Collections.Generic;

namespace NFeXML.ParseToClass.DTOs
{
    public class ResultadoDTO
    {
        public ResultadoDTO()
        {
            Produtos = new List<ProdutoDTO>();
            Fornecedor = new FornecedorDTO();
            Faturas = new List<Fatura>();
        }
        
        public long Numero { get; set; }
        public int Serie { get; set; }
        public DateTime DataEmissao { get; set; }
        public string Emitente { get; set; }
        public decimal Valor { get; set; }
        public List<ProdutoDTO> Produtos { get; set; }
        public List<Fatura> Faturas { get; set; }
        public FornecedorDTO Fornecedor { get; set; }
    }
}
