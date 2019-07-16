using NFeXML.ParseToClass.DTOs;
using nfeV400;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace NFeXML.ParseToClass
{
    public class Analizar
    {
        public static TNFe Nfe400(string caminhoXML)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(caminhoXML);

            var buffer = Encoding.UTF8.GetBytes(doc.GetElementsByTagName("NFe").Item(0).OuterXml);
            using (var stream = new MemoryStream(buffer))
            {
                return Deserializar(stream);
            }
        }

        public static TNFe Nfe400(MemoryStream stream)
        {
            return Deserializar(stream);
        }

        private static TNFe Deserializar(MemoryStream stream)
        {
            var serializer = new XmlSerializer(typeof(TNFe));
            return (TNFe)serializer.Deserialize(stream);
        }

        public static nfe310.TNFe Nfe310(string caminhoXML)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(caminhoXML);

            var buffer = Encoding.UTF8.GetBytes(doc.OuterXml);
            using (var stream = new MemoryStream(buffer))
            {
                return Deserializar310(stream);
            }
        }

        public static nfe310.TNFe Nfe310(MemoryStream stream)
        {
            return Deserializar310(stream);
        }

        private static nfe310.TNFe Deserializar310(MemoryStream stream)
        {
            var serializer = new XmlSerializer(typeof(nfe310.TNfeProc));
            var proc = (nfe310.TNfeProc)serializer.Deserialize(stream);
            return proc.NFe;
        }

        private static decimal ConverterParaDecimal(string valor)
        {
            return Math.Round(decimal.Parse(valor.Replace(".", ","), new CultureInfo("pt-BR")), 2);
        }

        public static ResultadoDTO GerarDTO(string caminhoXML)
        {
            var resultado = new ResultadoDTO();
            var nfe = Nfe400(caminhoXML);

            if (nfe.infNFe.versao == "3.10")
                return GerarDTODaNFe3100(caminhoXML);

            resultado.Fornecedor.Bairro = nfe.infNFe.emit.enderEmit.xBairro;
            resultado.Fornecedor.CEP = nfe.infNFe.emit.enderEmit.CEP;
            resultado.Fornecedor.Logradouro = nfe.infNFe.emit.enderEmit.xLgr;
            resultado.Fornecedor.MunicipioId = nfe.infNFe.emit.enderEmit.cMun;
            resultado.Fornecedor.Numero = nfe.infNFe.emit.enderEmit.nro;
            resultado.Fornecedor.Pais = nfe.infNFe.emit.enderEmit.xPais.ToString();
            resultado.Fornecedor.Telefone = nfe.infNFe.emit.enderEmit.fone;
            resultado.Fornecedor.UF = nfe.infNFe.emit.enderEmit.UF.ToString();

            resultado.Fornecedor.CNPJ = nfe.infNFe.emit.Item;
            resultado.Fornecedor.IE = nfe.infNFe.emit.IE;
            resultado.Fornecedor.Nome = nfe.infNFe.emit.xNome;
            resultado.Fornecedor.NomeFantasia = nfe.infNFe.emit.xFant;

            foreach (var item in nfe.infNFe.det)
            {
                resultado.Produtos.Add(new ProdutoDTO
                {
                    Codigo = item.prod.cProd,
                    CodigoEAN = item.prod.cEAN,
                    NCM = item.prod.NCM,
                    Nome = item.prod.xProd,
                    Quantidade = ConverterParaDecimal(item.prod.qCom),
                    Unidade = item.prod.uCom,
                    Valor = ConverterParaDecimal(item.prod.vUnCom)
                });
            }

            if (nfe.infNFe != null && nfe.infNFe.cobr != null)
            {
                foreach (var item in nfe.infNFe.cobr.dup)
                {
                    resultado.Faturas.Add(new Fatura
                    {
                        Data = DateTime.Parse(item.dVenc),
                        NumeroFatura = item.nDup,
                        Valor = ConverterParaDecimal(item.vDup)
                    });
                }
            }

            return resultado;
        }

        private static ResultadoDTO GerarDTODaNFe3100(string caminhoXML)
        {
            var resultado = new ResultadoDTO();
            var nfe = Nfe310(caminhoXML);

            resultado.Fornecedor.Bairro = nfe.infNFe.emit.enderEmit.xBairro;
            resultado.Fornecedor.CEP = nfe.infNFe.emit.enderEmit.CEP;
            resultado.Fornecedor.Logradouro = nfe.infNFe.emit.enderEmit.xLgr;
            resultado.Fornecedor.MunicipioId = nfe.infNFe.emit.enderEmit.cMun;
            resultado.Fornecedor.Numero = nfe.infNFe.emit.enderEmit.nro;
            resultado.Fornecedor.Pais = nfe.infNFe.emit.enderEmit.xPais.ToString();
            resultado.Fornecedor.Telefone = nfe.infNFe.emit.enderEmit.fone;
            resultado.Fornecedor.UF = nfe.infNFe.emit.enderEmit.UF.ToString();

            resultado.Fornecedor.CNPJ = nfe.infNFe.emit.Item;
            resultado.Fornecedor.IE = nfe.infNFe.emit.IE;
            resultado.Fornecedor.Nome = nfe.infNFe.emit.xNome;
            resultado.Fornecedor.NomeFantasia = nfe.infNFe.emit.xFant;

            foreach (var item in nfe.infNFe.det)
            {
                resultado.Produtos.Add(new ProdutoDTO
                {
                    Codigo = item.prod.cProd,
                    CodigoEAN = item.prod.cEAN,
                    NCM = item.prod.NCM,
                    Nome = item.prod.xProd,
                    Quantidade = ConverterParaDecimal(item.prod.qCom.ToString()),
                    Unidade = item.prod.uCom,
                    Valor = ConverterParaDecimal(item.prod.vUnCom.ToString())
                });
            }

            foreach (var item in nfe.infNFe.cobr.dup)
            {
                resultado.Faturas.Add(new Fatura
                {
                    Data = DateTime.Parse(item.dVenc),
                    NumeroFatura = item.nDup,
                    Valor = ConverterParaDecimal(item.vDup)
                });
            }

            return resultado;
        }
    }
}
