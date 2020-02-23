using NFe.Classes.Servicos.DistribuicaoDFe.Schemas;
using nfeV400;
using NFeXML.ParseToClass.DTOs;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using NFe.Utils;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal.Tipos;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Federal;
using NFe.Classes;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual.Tipos;
using NFe.Classes.Informacoes.Detalhe.Tributacao.Estadual;

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

        public static ResultadoDTO GerarDTO(string caminhoXML)
        {
            var resultado = new ResultadoDTO();
            var nfe = NFe.Utils.NFe.ExtNFe.CarregarDeArquivoXml(new NFe.Classes.NFe(), caminhoXML);

            resultado.DataEmissao = nfe.infNFe.ide.dhEmi.DateTime;
            resultado.Valor = nfe.infNFe.total.ICMSTot.vNF;
            resultado.Emitente = nfe.infNFe.emit.xNome;
            resultado.Numero = nfe.infNFe.ide.nNF;
            resultado.Serie = nfe.infNFe.ide.serie;


            resultado.Fornecedor.Bairro = nfe.infNFe.emit.enderEmit.xBairro;
            resultado.Fornecedor.CEP = nfe.infNFe.emit.enderEmit.CEP;
            resultado.Fornecedor.Logradouro = nfe.infNFe.emit.enderEmit.xLgr;
            resultado.Fornecedor.MunicipioId = nfe.infNFe.emit.enderEmit.cMun.ToString();
            resultado.Fornecedor.Numero = nfe.infNFe.emit.enderEmit.nro;
            resultado.Fornecedor.Pais = nfe.infNFe.emit.enderEmit.xPais;
            resultado.Fornecedor.Telefone = nfe.infNFe.emit.enderEmit.fone == null ? "" : nfe.infNFe.emit.enderEmit.fone.ToString();
            resultado.Fornecedor.UF = nfe.infNFe.emit.enderEmit.UF.ToString();

            resultado.Fornecedor.CNPJ = nfe.infNFe.emit.CNPJ;
            resultado.Fornecedor.IE = nfe.infNFe.emit.IE;
            resultado.Fornecedor.Nome = nfe.infNFe.emit.xNome;
            resultado.Fornecedor.NomeFantasia = nfe.infNFe.emit.xFant;

            foreach (var item in nfe.infNFe.det)
            {
                var produto = new ProdutoDTO
                {
                    Codigo = item.prod.cProd,
                    CodigoEAN = item.prod.cEAN,
                    NCM = item.prod.NCM,
                    Nome = item.prod.xProd,
                    Quantidade = item.prod.qCom,
                    Unidade = item.prod.uCom,
                    Valor = item.prod.vUnTrib.Arredondar(2),
                    ValorIPI = item.imposto.IPI != null ? ObterValorIPI(item.imposto.IPI.TipoIPI).Arredondar(2) : 0,
                    ValorICMSST = item.imposto.ICMS != null ? ObterValorICMSST(item.imposto.ICMS.TipoICMS).Arredondar(2) : 0,
                };

                resultado.Produtos.Add(produto);
            }

            if (nfe.infNFe != null && nfe.infNFe.cobr != null)
            {
                foreach (var item in nfe.infNFe.cobr.dup)
                {
                    resultado.Faturas.Add(new Fatura
                    {
                        Data = item.dVenc ?? new DateTime(),
                        NumeroFatura = item.nDup,
                        Valor = item.vDup
                    });
                }
            }

            return resultado;
        }

        private static decimal ObterValorICMSST(ICMSBasico tipoICMS)
        {
            if (tipoICMS is ICMS10)
            {
                var icms = tipoICMS as ICMS10;
                return icms.vICMSST;
            }

            if (tipoICMS is ICMS30)
            {
                var icms = tipoICMS as ICMS30;
                return icms.vICMSST;
            }

            if (tipoICMS is ICMS60)
            {
                var icms = tipoICMS as ICMS60;
                return icms.vICMSSubstituto ?? 0;
            }

            if (tipoICMS is ICMS70)
            {
                var icms = tipoICMS as ICMS70;
                return icms.vICMSST;
            }

            return 0;
        }

        private static decimal ObterValorIPI(IPIBasico tipoIPI)
        {
            if (tipoIPI is IPITrib)
            {
                var ipi = tipoIPI as IPITrib;
                return ipi.vIPI ?? 0;
            }

            return 0;
        }
    }
}
