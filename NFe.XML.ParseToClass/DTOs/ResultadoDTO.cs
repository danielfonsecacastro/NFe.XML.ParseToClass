using System.Collections.Generic;

namespace NFe.XML.ParseToClass.DTOs
{
    public class ResultadoDTO
    {
        public ResultadoDTO()
        {
            Produtos = new List<ProdutoDTO>();
            Fornecedor = new FornecedorDTO();
        }

        public List<ProdutoDTO> Produtos { get; set; }
        public FornecedorDTO Fornecedor { get; set; }
    }
}
