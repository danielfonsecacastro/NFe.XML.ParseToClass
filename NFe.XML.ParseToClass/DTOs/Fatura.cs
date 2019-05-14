using System;

namespace NFe.XML.ParseToClass.DTOs
{
    public class Fatura
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string NumeroFatura { get; set; }
    }
}
