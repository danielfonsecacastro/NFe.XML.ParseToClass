using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFeXML.ParseToClass;

namespace NFe.XML.ParseToClass.Testes
{
    [TestClass]
    public class AnalizarTestes
    {
        [TestMethod]
        public void DeveriaConter34DetalhesNFe400()
        {
            var resultado = Analizar.Nfe400("teste400.XML");

            Assert.IsTrue(resultado.infNFe.det.Count() == 36);
        }

        [TestMethod]
        public void DeveriaConter27DetalhesNFe310()
        {
            var resultado = Analizar.Nfe310("teste310.XML");

            Assert.IsTrue(resultado.infNFe.det.Count() == 27);
        }

        [TestMethod]
        public void DeveriaGerarEnderecoForncedorCorretamenteParaNFe400()
        {
            var resultado = Analizar.GerarDTO("teste400.XML");

            Assert.AreEqual("VL STA CATARINA", resultado.Fornecedor.Bairro);
            Assert.AreEqual("04376006", resultado.Fornecedor.CEP);
            Assert.AreEqual("49748689000126", resultado.Fornecedor.CNPJ);
            Assert.AreEqual("489021200990", resultado.Fornecedor.IE);
            Assert.AreEqual("Rua Quinze de Novembro", resultado.Fornecedor.Logradouro);
            Assert.AreEqual("3550308", resultado.Fornecedor.MunicipioId);
            Assert.AreEqual("SP", resultado.Fornecedor.UF);
            Assert.AreEqual("Brasil", resultado.Fornecedor.Pais);
        }

        [TestMethod]
        public void DeveriaGerarDadosForncedorCorretamenteParaNFe400()
        {
            var resultado = Analizar.GerarDTO("teste400.XML");

            Assert.AreEqual("49748689000126", resultado.Fornecedor.CNPJ);
            Assert.AreEqual("489021200990", resultado.Fornecedor.IE);
            Assert.AreEqual("Laís e Pedro Henrique Comercio de Bebidas ME", resultado.Fornecedor.Nome);
            Assert.AreEqual("LaísME", resultado.Fornecedor.NomeFantasia);
        }

        [TestMethod]
        public void DeveriaGerarEnderecoForncedorCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML");

            Assert.AreEqual("Vila São João", resultado.Fornecedor.Bairro);
            Assert.AreEqual("05308000", resultado.Fornecedor.CEP);
            Assert.AreEqual("65952835000197", resultado.Fornecedor.CNPJ);
            Assert.AreEqual("569927446281", resultado.Fornecedor.IE);
            Assert.AreEqual("Rua Santa Cruz", resultado.Fornecedor.Logradouro);
            Assert.AreEqual("3550308", resultado.Fornecedor.MunicipioId);
            Assert.AreEqual("SP", resultado.Fornecedor.UF);
            Assert.AreEqual("BRASIL", resultado.Fornecedor.Pais);
        }

        [TestMethod]
        public void DeveriaGerarDadosForncedorCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML");

            Assert.AreEqual("65952835000197", resultado.Fornecedor.CNPJ);
            Assert.AreEqual("569927446281", resultado.Fornecedor.IE);
            Assert.AreEqual("Enrico e Olivia Mudanças ME.", resultado.Fornecedor.Nome);
            Assert.AreEqual("EnricoME", resultado.Fornecedor.NomeFantasia);
        }

        [TestMethod]
        public void DeveriaGerarDadosPrimeiroProdutoCorretamenteParaNFe410()
        {
            var resultado = Analizar.GerarDTO("teste400.XML").Produtos.First();

            Assert.AreEqual("2445-055", resultado.Codigo);
            Assert.AreEqual("7899033234918", resultado.CodigoEAN);
            Assert.AreEqual("87149310", resultado.NCM);
            Assert.AreEqual("BLOCAGEM P/ CUBOS CLY ALUM  DIANT/TRAS", resultado.Nome);
            Assert.AreEqual(3, resultado.Quantidade);
            Assert.AreEqual("UN", resultado.Unidade);
            Assert.AreEqual(15.37M, resultado.Valor);
        }

        [TestMethod]
        public void DeveriaGerarDadosUltimoProdutoCorretamenteParaNFe410()
        {
            var resultado = Analizar.GerarDTO("teste400.XML").Produtos.Last();

            Assert.AreEqual("4267-055", resultado.Codigo);
            Assert.AreEqual("7899033272743", resultado.CodigoEAN);
            Assert.AreEqual("87149990", resultado.NCM);
            Assert.AreEqual("ARANHA EXPANSIVA EM ALUMINIO", resultado.Nome);
            Assert.AreEqual(1, resultado.Quantidade);
            Assert.AreEqual("UN", resultado.Unidade);
            Assert.AreEqual(45.50M, resultado.Valor);
        }

        [TestMethod]
        public void DeveriaGerarDadosPrimeiroProdutoCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML").Produtos.First();

            Assert.AreEqual("39069", resultado.Codigo);
            Assert.AreEqual("", resultado.CodigoEAN);
            Assert.AreEqual("64041100", resultado.NCM);
            Assert.AreEqual("SAPATILHA URBANA GIRO GRYND PTO/BCO T.43", resultado.Nome);
            Assert.AreEqual(1, resultado.Quantidade);
            Assert.AreEqual("PR", resultado.Unidade);
            Assert.AreEqual(318.60M, resultado.Valor);
        }

        [TestMethod]
        public void DeveriaGerarDadosUltimoProdutoCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML").Produtos.Last();

            Assert.AreEqual("6430", resultado.Codigo);
            Assert.AreEqual("", resultado.CodigoEAN);
            Assert.AreEqual("87149490", resultado.NCM);
            Assert.AreEqual("SAPATA SPEED 450 50MM PTO", resultado.Nome);
            Assert.AreEqual(2, resultado.Quantidade);
            Assert.AreEqual("PR", resultado.Unidade);
            Assert.AreEqual(4.81M, resultado.Valor);
        }


        [TestMethod]
        public void DeveriaGerarDadosPrimeiraFaturaCorretamenteParaNFe410()
        {
            var resultado = Analizar.GerarDTO("teste400.XML").Faturas.First();

            Assert.AreEqual("09/06/2019", resultado.Data.ToString("dd/MM/yyyy"));
            Assert.AreEqual("001", resultado.NumeroFatura);
            Assert.AreEqual(838.63M, resultado.Valor);
        }

        [TestMethod]
        public void DeveriaGerarDadosUltimaFaturaCorretamenteParaNFe410()
        {
            var resultado = Analizar.GerarDTO("teste400.XML").Faturas.Last();

            Assert.AreEqual("08/08/2019", resultado.Data.ToString("dd/MM/yyyy"));
            Assert.AreEqual("003", resultado.NumeroFatura);
            Assert.AreEqual(662.99M, resultado.Valor);
        }


        [TestMethod]
        public void DeveriaGerarDadosPrimeiraFaturaCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML").Faturas.First();

            Assert.AreEqual("25/01/2017", resultado.Data.ToString("dd/MM/yyyy"));
            Assert.AreEqual("1  0002183871", resultado.NumeroFatura);
            Assert.AreEqual(725.45M, resultado.Valor);
        }

        [TestMethod]
        public void DeveriaGerarDadosUltimaFaturaCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML").Faturas.Last();

            Assert.AreEqual("25/04/2017", resultado.Data.ToString("dd/MM/yyyy"));
            Assert.AreEqual("1  0002183874", resultado.NumeroFatura);
            Assert.AreEqual(722.00M, resultado.Valor);
        }
    }
}
