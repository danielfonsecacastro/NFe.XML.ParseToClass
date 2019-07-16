using System;

namespace NFeXML.ParseToClass.DTOs
{
    public class Fatura
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string NumeroFatura { get; set; }
    }
}
