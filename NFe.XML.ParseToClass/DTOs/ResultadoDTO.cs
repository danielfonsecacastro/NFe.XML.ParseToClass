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

        public List<ProdutoDTO> Produtos { get; set; }
        public List<Fatura> Faturas { get; set; }
        public FornecedorDTO Fornecedor { get; set; }
    }
}
