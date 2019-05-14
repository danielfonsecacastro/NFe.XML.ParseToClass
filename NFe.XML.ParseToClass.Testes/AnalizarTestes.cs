using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            Assert.AreEqual(resultado.Fornecedor.Bairro, "VL STA CATARINA");
            Assert.AreEqual(resultado.Fornecedor.CEP, "04376006");
            Assert.AreEqual(resultado.Fornecedor.CNPJ, "49748689000126");
            Assert.AreEqual(resultado.Fornecedor.IE, "489021200990");
            Assert.AreEqual(resultado.Fornecedor.Logradouro, "Rua Quinze de Novembro");
            Assert.AreEqual(resultado.Fornecedor.MunicipioId, "3550308");
            Assert.AreEqual(resultado.Fornecedor.UF, "SP");
            Assert.AreEqual(resultado.Fornecedor.Pais, "Brasil");
        }

        [TestMethod]
        public void DeveriaGerarDadosForncedorCorretamenteParaNFe400()
        {
            var resultado = Analizar.GerarDTO("teste400.XML");

            Assert.AreEqual(resultado.Fornecedor.CNPJ, "49748689000126");
            Assert.AreEqual(resultado.Fornecedor.IE, "489021200990");
            Assert.AreEqual(resultado.Fornecedor.Nome, "Laís e Pedro Henrique Comercio de Bebidas ME");
            Assert.AreEqual(resultado.Fornecedor.NomeFantasia, "LaísME");
        }

        [TestMethod]
        public void DeveriaGerarEnderecoForncedorCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML");

            Assert.AreEqual(resultado.Fornecedor.Bairro, "Vila São João");
            Assert.AreEqual(resultado.Fornecedor.CEP, "05308000");
            Assert.AreEqual(resultado.Fornecedor.CNPJ, "65952835000197");
            Assert.AreEqual(resultado.Fornecedor.IE, "569927446281");
            Assert.AreEqual(resultado.Fornecedor.Logradouro, "Rua Santa Cruz");
            Assert.AreEqual(resultado.Fornecedor.MunicipioId, "3550308");
            Assert.AreEqual(resultado.Fornecedor.UF, "SP");
            Assert.AreEqual(resultado.Fornecedor.Pais, "BRASIL");
        }

        [TestMethod]
        public void DeveriaGerarDadosForncedorCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML");

            Assert.AreEqual(resultado.Fornecedor.CNPJ, "65952835000197");
            Assert.AreEqual(resultado.Fornecedor.IE, "569927446281");
            Assert.AreEqual(resultado.Fornecedor.Nome, "Enrico e Olivia Mudanças ME.");
            Assert.AreEqual(resultado.Fornecedor.NomeFantasia, "EnricoME");
        }

        [TestMethod]
        public void DeveriaGerarDadosPrimeiroProdutoCorretamenteParaNFe410()
        {
            var resultado = Analizar.GerarDTO("teste400.XML").Produtos.First();

            Assert.AreEqual(resultado.Codigo, "2445-055");
            Assert.AreEqual(resultado.CodigoEAN, "7899033234918");
            Assert.AreEqual(resultado.NCM, "87149310");
            Assert.AreEqual(resultado.Nome, "BLOCAGEM P/ CUBOS CLY ALUM  DIANT/TRAS");
            Assert.AreEqual(resultado.Quantidade, 3);
            Assert.AreEqual(resultado.Unidade, "UN");
            Assert.AreEqual(resultado.Valor, 15.37M);
        }

        [TestMethod]
        public void DeveriaGerarDadosUltimoProdutoCorretamenteParaNFe410()
        {
            var resultado = Analizar.GerarDTO("teste400.XML").Produtos.Last();

            Assert.AreEqual(resultado.Codigo, "4267-055");
            Assert.AreEqual(resultado.CodigoEAN, "7899033272743");
            Assert.AreEqual(resultado.NCM, "87149990");
            Assert.AreEqual(resultado.Nome, "ARANHA EXPANSIVA EM ALUMINIO");
            Assert.AreEqual(resultado.Quantidade, 1);
            Assert.AreEqual(resultado.Unidade, "UN");
            Assert.AreEqual(resultado.Valor, 45.50M);
        }

        [TestMethod]
        public void DeveriaGerarDadosPrimeiroProdutoCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML").Produtos.First();

            Assert.AreEqual(resultado.Codigo, "39069");
            Assert.AreEqual(resultado.CodigoEAN, "");
            Assert.AreEqual(resultado.NCM, "64041100");
            Assert.AreEqual(resultado.Nome, "SAPATILHA URBANA GIRO GRYND PTO/BCO T.43");
            Assert.AreEqual(resultado.Quantidade, 1);
            Assert.AreEqual(resultado.Unidade, "PR");
            Assert.AreEqual(resultado.Valor, 318.60M);
        }

        [TestMethod]
        public void DeveriaGerarDadosUltimoProdutoCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML").Produtos.Last();

            Assert.AreEqual(resultado.Codigo, "6430");
            Assert.AreEqual(resultado.CodigoEAN, "");
            Assert.AreEqual(resultado.NCM, "87149490");
            Assert.AreEqual(resultado.Nome, "SAPATA SPEED 450 50MM PTO");
            Assert.AreEqual(resultado.Quantidade, 2);
            Assert.AreEqual(resultado.Unidade, "PR");
            Assert.AreEqual(resultado.Valor, 4.81M);
        }


        [TestMethod]
        public void DeveriaGerarDadosPrimeiraFaturaCorretamenteParaNFe410()
        {
            var resultado = Analizar.GerarDTO("teste400.XML").Faturas.First();

            Assert.AreEqual(resultado.Data.ToShortDateString(), "09/06/2019");
            Assert.AreEqual(resultado.NumeroFatura, "001");
            Assert.AreEqual(resultado.Valor, 838.63M);
        }

        [TestMethod]
        public void DeveriaGerarDadosUltimaFaturaCorretamenteParaNFe410()
        {
            var resultado = Analizar.GerarDTO("teste400.XML").Faturas.Last();

            Assert.AreEqual(resultado.Data.ToShortDateString(), "08/08/2019");
            Assert.AreEqual(resultado.NumeroFatura, "003");
            Assert.AreEqual(resultado.Valor, 662.99M);
        }


        [TestMethod]
        public void DeveriaGerarDadosPrimeiraFaturaCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML").Faturas.First();

            Assert.AreEqual("25/01/2017", resultado.Data.ToShortDateString());
            Assert.AreEqual("1  0002183871", resultado.NumeroFatura);
            Assert.AreEqual(725.45M, resultado.Valor);
        }

        [TestMethod]
        public void DeveriaGerarDadosUltimaFaturaCorretamenteParaNFe310()
        {
            var resultado = Analizar.GerarDTO("teste310.XML").Faturas.Last();

            Assert.AreEqual("25/04/2017", resultado.Data.ToShortDateString());
            Assert.AreEqual("1  0002183874", resultado.NumeroFatura);
            Assert.AreEqual(722.00M, resultado.Valor);
        }
    }
}
