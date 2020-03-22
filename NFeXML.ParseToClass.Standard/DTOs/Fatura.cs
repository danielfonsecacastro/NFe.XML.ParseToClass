using System;
using System.Collections.Generic;
using System.Text;

namespace NFeXML.ParseToClass.Standard.DTOs
{
    public class Fatura
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string NumeroFatura { get; set; }
    }
}
