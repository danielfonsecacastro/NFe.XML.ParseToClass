namespace NFeXML.ParseToClass.Standard.DTOs
{
    public class ProdutoVeiculoDTO
    {
        public string Chassi { get; set; }
        public string NumeroSerie { get; set; }
        public string NumeroMotor { get; set; }
        public string IdentificadorVIN { get; set; }
        public int? AnoFabricacao { get; set; }
        public int? AnoModelo { get; set; }
        public string CodigoModelo { get; set; }
        public string CondicaoVeiculo { get; set; }
        public string TipoVeiculo { get; set; }
        public string EspecieVeiculo { get; set; }
        public string TipoCombustivel { get; set; }
        public string TipoPintura { get; set; }
        public int? LotacaoMaxima { get; set; }
        public string PotenciaMotor { get; set; }
        public int? Cilindradas { get; set; }
        public decimal? PesoLiquido { get; set; }
        public decimal? PesoBruto { get; set; }
        public decimal? CapacidadeMaximaTracao { get; set; }
        public string DistanciaEntreEixos { get; set; }
        public string TipoOperacao { get; set; }
        public string CodigoCor { get; set; }
        public string DescricaoCor { get; set; }
        public string TipoRestricao { get; set; }
    }
}
