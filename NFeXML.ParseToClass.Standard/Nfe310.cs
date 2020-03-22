namespace nfe310
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TNfeProc
    {

        private TNFe nFeField;

        private TProtNFe protNFeField;

        private string versaoField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFe NFe
        {
            get
            {
                return this.nFeField;
            }
            set
            {
                this.nFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TProtNFe protNFe
        {
            get
            {
                return this.protNFeField;
            }
            set
            {
                this.protNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFe
    {

        private TNFeInfNFe infNFeField;

        private TNFeInfNFeSupl infNFeSuplField;

        private SignatureType signatureField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFe infNFe
        {
            get
            {
                return this.infNFeField;
            }
            set
            {
                this.infNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeSupl infNFeSupl
        {
            get
            {
                return this.infNFeSuplField;
            }
            set
            {
                this.infNFeSuplField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 2)]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFe
    {

        private TNFeInfNFeIde ideField;

        private TNFeInfNFeEmit emitField;

        private TNFeInfNFeAvulsa avulsaField;

        private TNFeInfNFeDest destField;

        private TLocal retiradaField;

        private TLocal entregaField;

        private TNFeInfNFeAutXML[] autXMLField;

        private TNFeInfNFeDet[] detField;

        private TNFeInfNFeTotal totalField;

        private TNFeInfNFeTransp transpField;

        private TNFeInfNFeCobr cobrField;

        private TNFeInfNFePag[] pagField;

        private TNFeInfNFeInfAdic infAdicField;

        private TNFeInfNFeExporta exportaField;

        private TNFeInfNFeCompra compraField;

        private TNFeInfNFeCana canaField;

        private string versaoField;

        private string idField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeIde ide
        {
            get
            {
                return this.ideField;
            }
            set
            {
                this.ideField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeEmit emit
        {
            get
            {
                return this.emitField;
            }
            set
            {
                this.emitField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeAvulsa avulsa
        {
            get
            {
                return this.avulsaField;
            }
            set
            {
                this.avulsaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TNFeInfNFeDest dest
        {
            get
            {
                return this.destField;
            }
            set
            {
                this.destField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TLocal retirada
        {
            get
            {
                return this.retiradaField;
            }
            set
            {
                this.retiradaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TLocal entrega
        {
            get
            {
                return this.entregaField;
            }
            set
            {
                this.entregaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("autXML", Order = 6)]
        public TNFeInfNFeAutXML[] autXML
        {
            get
            {
                return this.autXMLField;
            }
            set
            {
                this.autXMLField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("det", Order = 7)]
        public TNFeInfNFeDet[] det
        {
            get
            {
                return this.detField;
            }
            set
            {
                this.detField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TNFeInfNFeTotal total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TNFeInfNFeTransp transp
        {
            get
            {
                return this.transpField;
            }
            set
            {
                this.transpField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public TNFeInfNFeCobr cobr
        {
            get
            {
                return this.cobrField;
            }
            set
            {
                this.cobrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pag", Order = 11)]
        public TNFeInfNFePag[] pag
        {
            get
            {
                return this.pagField;
            }
            set
            {
                this.pagField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public TNFeInfNFeInfAdic infAdic
        {
            get
            {
                return this.infAdicField;
            }
            set
            {
                this.infAdicField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public TNFeInfNFeExporta exporta
        {
            get
            {
                return this.exportaField;
            }
            set
            {
                this.exportaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public TNFeInfNFeCompra compra
        {
            get
            {
                return this.compraField;
            }
            set
            {
                this.compraField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public TNFeInfNFeCana cana
        {
            get
            {
                return this.canaField;
            }
            set
            {
                this.canaField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIde
    {

        private TCodUfIBGE cUFField;

        private string cNFField;

        private string natOpField;

        private TNFeInfNFeIdeIndPag indPagField;

        private TMod modField;

        private string serieField;

        private string nNFField;

        private string dhEmiField;

        private string dhSaiEntField;

        private TNFeInfNFeIdeTpNF tpNFField;

        private TNFeInfNFeIdeIdDest idDestField;

        private string cMunFGField;

        private TNFeInfNFeIdeTpImp tpImpField;

        private TNFeInfNFeIdeTpEmis tpEmisField;

        private string cDVField;

        private TAmb tpAmbField;

        private TFinNFe finNFeField;

        private TNFeInfNFeIdeIndFinal indFinalField;

        private TNFeInfNFeIdeIndPres indPresField;

        private TProcEmi procEmiField;

        private string verProcField;

        private string dhContField;

        private string xJustField;

        private TNFeInfNFeIdeNFref[] nFrefField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string cNF
        {
            get
            {
                return this.cNFField;
            }
            set
            {
                this.cNFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string natOp
        {
            get
            {
                return this.natOpField;
            }
            set
            {
                this.natOpField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TNFeInfNFeIdeIndPag indPag
        {
            get
            {
                return this.indPagField;
            }
            set
            {
                this.indPagField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string dhEmi
        {
            get
            {
                return this.dhEmiField;
            }
            set
            {
                this.dhEmiField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string dhSaiEnt
        {
            get
            {
                return this.dhSaiEntField;
            }
            set
            {
                this.dhSaiEntField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TNFeInfNFeIdeTpNF tpNF
        {
            get
            {
                return this.tpNFField;
            }
            set
            {
                this.tpNFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public TNFeInfNFeIdeIdDest idDest
        {
            get
            {
                return this.idDestField;
            }
            set
            {
                this.idDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public TNFeInfNFeIdeTpImp tpImp
        {
            get
            {
                return this.tpImpField;
            }
            set
            {
                this.tpImpField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public TNFeInfNFeIdeTpEmis tpEmis
        {
            get
            {
                return this.tpEmisField;
            }
            set
            {
                this.tpEmisField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string cDV
        {
            get
            {
                return this.cDVField;
            }
            set
            {
                this.cDVField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public TFinNFe finNFe
        {
            get
            {
                return this.finNFeField;
            }
            set
            {
                this.finNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public TNFeInfNFeIdeIndFinal indFinal
        {
            get
            {
                return this.indFinalField;
            }
            set
            {
                this.indFinalField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public TNFeInfNFeIdeIndPres indPres
        {
            get
            {
                return this.indPresField;
            }
            set
            {
                this.indPresField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public TProcEmi procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string dhCont
        {
            get
            {
                return this.dhContField;
            }
            set
            {
                this.dhContField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public string xJust
        {
            get
            {
                return this.xJustField;
            }
            set
            {
                this.xJustField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("NFref", Order = 23)]
        public TNFeInfNFeIdeNFref[] NFref
        {
            get
            {
                return this.nFrefField;
            }
            set
            {
                this.nFrefField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCodUfIBGE
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPag
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpNF
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIdDest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpImp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpEmis
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TAmb
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TFinNFe
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndFinal
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPres
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TProcEmi
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFref
    {

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        [System.Xml.Serialization.XmlElementAttribute("refCTe", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("refECF", typeof(TNFeInfNFeIdeNFrefRefECF), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("refNF", typeof(TNFeInfNFeIdeNFrefRefNF), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("refNFP", typeof(TNFeInfNFeIdeNFrefRefNFP), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("refNFe", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefECF
    {

        private TNFeInfNFeIdeNFrefRefECFMod modField;

        private string nECFField;

        private string nCOOField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeIdeNFrefRefECFMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string nECF
        {
            get
            {
                return this.nECFField;
            }
            set
            {
                this.nECFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string nCOO
        {
            get
            {
                return this.nCOOField;
            }
            set
            {
                this.nCOOField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefECFMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2B")]
        Item2B,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2C")]
        Item2C,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2D")]
        Item2D,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFe
    {

        private TProtNFeInfProt infProtField;

        private SignatureType signatureField;

        private string versaoField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TProtNFeInfProt infProt
        {
            get
            {
                return this.infProtField;
            }
            set
            {
                this.infProtField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 1)]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return this.versaoField;
            }
            set
            {
                this.versaoField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFeInfProt
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string chNFeField;

        private string dhRecbtoField;

        private string nProtField;

        private byte[] digValField;

        private string cStatField;

        private string xMotivoField;

        private string idField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TAmb tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string verAplic
        {
            get
            {
                return this.verAplicField;
            }
            set
            {
                this.verAplicField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string dhRecbto
        {
            get
            {
                return this.dhRecbtoField;
            }
            set
            {
                this.dhRecbtoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string nProt
        {
            get
            {
                return this.nProtField;
            }
            set
            {
                this.nProtField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 5)]
        public byte[] digVal
        {
            get
            {
                return this.digValField;
            }
            set
            {
                this.digValField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string cStat
        {
            get
            {
                return this.cStatField;
            }
            set
            {
                this.cStatField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string xMotivo
        {
            get
            {
                return this.xMotivoField;
            }
            set
            {
                this.xMotivoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private string idField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SignedInfoType SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public SignatureValueType SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public KeyInfoType KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {

        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;

        private SignedInfoTypeSignatureMethod signatureMethodField;

        private ReferenceType referenceField;

        private string idField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public SignedInfoTypeSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ReferenceType Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {

        private string algorithmField;

        public SignedInfoTypeCanonicalizationMethod()
        {
            this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {

        private string algorithmField;

        public SignedInfoTypeSignatureMethod()
        {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {

        private TransformType[] transformsField;

        private ReferenceTypeDigestMethod digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ReferenceTypeDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 2)]
        public byte[] DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {

        private string[] xPathField;

        private TTransformURI algorithmField;

        [System.Xml.Serialization.XmlElementAttribute("XPath", Order = 0)]
        public string[] XPath
        {
            get
            {
                return this.xPathField;
            }
            set
            {
                this.xPathField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod
    {

        private string algorithmField;

        public ReferenceTypeDigestMethod()
        {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {

        private X509DataType x509DataField;

        private string idField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X509DataType X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {

        private byte[] x509CertificateField;

        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 0)]
        public byte[] X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TVeiculo
    {

        private string placaField;

        private TUf ufField;

        private string rNTCField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string placa
        {
            get
            {
                return this.placaField;
            }
            set
            {
                this.placaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string RNTC
        {
            get
            {
                return this.rNTCField;
            }
            set
            {
                this.rNTCField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUf
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,

        /// <remarks/>
        EX,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpi
    {

        private string clEnqField;

        private string cNPJProdField;

        private string cSeloField;

        private string qSeloField;

        private string cEnqField;

        private object itemField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string clEnq
        {
            get
            {
                return this.clEnqField;
            }
            set
            {
                this.clEnqField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CNPJProd
        {
            get
            {
                return this.cNPJProdField;
            }
            set
            {
                this.cNPJProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string cSelo
        {
            get
            {
                return this.cSeloField;
            }
            set
            {
                this.cSeloField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string qSelo
        {
            get
            {
                return this.qSeloField;
            }
            set
            {
                this.qSeloField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string cEnq
        {
            get
            {
                return this.cEnqField;
            }
            set
            {
                this.cEnqField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("IPINT", typeof(TIpiIPINT), Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("IPITrib", typeof(TIpiIPITrib), Order = 5)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpiIPINT
    {

        private TIpiIPINTCST cSTField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TIpiIPINTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TIpiIPINTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpiIPITrib
    {

        private TIpiIPITribCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string vIPIField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TIpiIPITribCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pIPI", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("qUnid", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("vUnid", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vIPI
        {
            get
            {
                return this.vIPIField;
            }
            set
            {
                this.vIPIField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TIpiIPITribCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        pIPI,

        /// <remarks/>
        qUnid,

        /// <remarks/>
        vBC,

        /// <remarks/>
        vUnid,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TLocal
    {

        private string itemField;

        private ItemChoiceType4 itemElementNameField;

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUf ufField;

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType4
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEndereco
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUf ufField;

        private string cEPField;

        private string cPaisField;

        private string xPaisField;

        private string foneField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEnderEmi
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUfEmi ufField;

        private string cEPField;

        private TEnderEmiCPais cPaisField;

        private bool cPaisFieldSpecified;

        private TEnderEmiXPais xPaisField;

        private bool xPaisFieldSpecified;

        private string foneField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string xLgr
        {
            get
            {
                return this.xLgrField;
            }
            set
            {
                this.xLgrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string nro
        {
            get
            {
                return this.nroField;
            }
            set
            {
                this.nroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xCpl
        {
            get
            {
                return this.xCplField;
            }
            set
            {
                this.xCplField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string xBairro
        {
            get
            {
                return this.xBairroField;
            }
            set
            {
                this.xBairroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TUfEmi UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string CEP
        {
            get
            {
                return this.cEPField;
            }
            set
            {
                this.cEPField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TEnderEmiCPais cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cPaisSpecified
        {
            get
            {
                return this.cPaisFieldSpecified;
            }
            set
            {
                this.cPaisFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TEnderEmiXPais xPais
        {
            get
            {
                return this.xPaisField;
            }
            set
            {
                this.xPaisField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xPaisSpecified
        {
            get
            {
                return this.xPaisFieldSpecified;
            }
            set
            {
                this.xPaisFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUfEmi
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiCPais
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1058")]
        Item1058,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiXPais
    {

        /// <remarks/>
        Brasil,

        /// <remarks/>
        BRASIL,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNF
    {

        private TCodUfIBGE cUFField;

        private string aAMMField;

        private string cNPJField;

        private TNFeInfNFeIdeNFrefRefNFMod modField;

        private string serieField;

        private string nNFField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string AAMM
        {
            get
            {
                return this.aAMMField;
            }
            set
            {
                this.aAMMField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TNFeInfNFeIdeNFrefRefNFMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNFP
    {

        private TCodUfIBGE cUFField;

        private string aAMMField;

        private string itemField;

        private ItemChoiceType itemElementNameField;

        private string ieField;

        private TNFeInfNFeIdeNFrefRefNFPMod modField;

        private string serieField;

        private string nNFField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TCodUfIBGE cUF
        {
            get
            {
                return this.cUFField;
            }
            set
            {
                this.cUFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string AAMM
        {
            get
            {
                return this.aAMMField;
            }
            set
            {
                this.aAMMField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string), Order = 2)]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string), Order = 2)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TNFeInfNFeIdeNFrefRefNFPMod mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string nNF
        {
            get
            {
                return this.nNFField;
            }
            set
            {
                this.nNFField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFPMod
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        refCTe,

        /// <remarks/>
        refECF,

        /// <remarks/>
        refNF,

        /// <remarks/>
        refNFP,

        /// <remarks/>
        refNFe,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeEmit
    {

        private string itemField;

        private ItemChoiceType2 itemElementNameField;

        private string xNomeField;

        private string xFantField;

        private TEnderEmi enderEmitField;

        private string ieField;

        private string iESTField;

        private string imField;

        private string cNAEField;

        private TNFeInfNFeEmitCRT cRTField;

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string xFant
        {
            get
            {
                return this.xFantField;
            }
            set
            {
                this.xFantField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TEnderEmi enderEmit
        {
            get
            {
                return this.enderEmitField;
            }
            set
            {
                this.enderEmitField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string IEST
        {
            get
            {
                return this.iESTField;
            }
            set
            {
                this.iESTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string IM
        {
            get
            {
                return this.imField;
            }
            set
            {
                this.imField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string CNAE
        {
            get
            {
                return this.cNAEField;
            }
            set
            {
                this.cNAEField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TNFeInfNFeEmitCRT CRT
        {
            get
            {
                return this.cRTField;
            }
            set
            {
                this.cRTField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeEmitCRT
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAvulsa
    {

        private string cNPJField;

        private string xOrgaoField;

        private string matrField;

        private string xAgenteField;

        private string foneField;

        private TUfEmi ufField;

        private string nDARField;

        private string dEmiField;

        private string vDARField;

        private string repEmiField;

        private string dPagField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string xOrgao
        {
            get
            {
                return this.xOrgaoField;
            }
            set
            {
                this.xOrgaoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string matr
        {
            get
            {
                return this.matrField;
            }
            set
            {
                this.matrField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string xAgente
        {
            get
            {
                return this.xAgenteField;
            }
            set
            {
                this.xAgenteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string fone
        {
            get
            {
                return this.foneField;
            }
            set
            {
                this.foneField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TUfEmi UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string nDAR
        {
            get
            {
                return this.nDARField;
            }
            set
            {
                this.nDARField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string dEmi
        {
            get
            {
                return this.dEmiField;
            }
            set
            {
                this.dEmiField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string vDAR
        {
            get
            {
                return this.vDARField;
            }
            set
            {
                this.vDARField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string repEmi
        {
            get
            {
                return this.repEmiField;
            }
            set
            {
                this.repEmiField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string dPag
        {
            get
            {
                return this.dPagField;
            }
            set
            {
                this.dPagField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDest
    {

        private string itemField;

        private ItemChoiceType3 itemElementNameField;

        private string xNomeField;

        private TEndereco enderDestField;

        private TNFeInfNFeDestIndIEDest indIEDestField;

        private string ieField;

        private string iSUFField;

        private string imField;

        private string emailField;

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("idEstrangeiro", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TEndereco enderDest
        {
            get
            {
                return this.enderDestField;
            }
            set
            {
                this.enderDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TNFeInfNFeDestIndIEDest indIEDest
        {
            get
            {
                return this.indIEDestField;
            }
            set
            {
                this.indIEDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string ISUF
        {
            get
            {
                return this.iSUFField;
            }
            set
            {
                this.iSUFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string IM
        {
            get
            {
                return this.imField;
            }
            set
            {
                this.imField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        idEstrangeiro,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDestIndIEDest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAutXML
    {

        private string itemField;

        private ItemChoiceType5 itemElementNameField;

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType5 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType5
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDet
    {

        private TNFeInfNFeDetProd prodField;

        private TNFeInfNFeDetImposto impostoField;

        private TNFeInfNFeDetImpostoDevol impostoDevolField;

        private string infAdProdField;

        private string nItemField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetProd prod
        {
            get
            {
                return this.prodField;
            }
            set
            {
                this.prodField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImposto imposto
        {
            get
            {
                return this.impostoField;
            }
            set
            {
                this.impostoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoDevol impostoDevol
        {
            get
            {
                return this.impostoDevolField;
            }
            set
            {
                this.impostoDevolField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string infAdProd
        {
            get
            {
                return this.infAdProdField;
            }
            set
            {
                this.infAdProdField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nItem
        {
            get
            {
                return this.nItemField;
            }
            set
            {
                this.nItemField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProd
    {

        private string cProdField;

        private string cEANField;

        private string xProdField;

        private string nCMField;

        private string[] nVEField;

        private string cESTField;

        private string eXTIPIField;

        private string cFOPField;

        private string uComField;

        private string qComField;

        private string vUnComField;

        private string vProdField;

        private string cEANTribField;

        private string uTribField;

        private string qTribField;

        private string vUnTribField;

        private string vFreteField;

        private string vSegField;

        private string vDescField;

        private string vOutroField;

        private TNFeInfNFeDetProdIndTot indTotField;

        private TNFeInfNFeDetProdDI[] diField;

        private TNFeInfNFeDetProdDetExport[] detExportField;

        private string xPedField;

        private string nItemPedField;

        private string nFCIField;

        private object[] itemsField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string cProd
        {
            get
            {
                return this.cProdField;
            }
            set
            {
                this.cProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string cEAN
        {
            get
            {
                return this.cEANField;
            }
            set
            {
                this.cEANField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xProd
        {
            get
            {
                return this.xProdField;
            }
            set
            {
                this.xProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string NCM
        {
            get
            {
                return this.nCMField;
            }
            set
            {
                this.nCMField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("NVE", Order = 4)]
        public string[] NVE
        {
            get
            {
                return this.nVEField;
            }
            set
            {
                this.nVEField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string CEST
        {
            get
            {
                return this.cESTField;
            }
            set
            {
                this.cESTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string EXTIPI
        {
            get
            {
                return this.eXTIPIField;
            }
            set
            {
                this.eXTIPIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string uCom
        {
            get
            {
                return this.uComField;
            }
            set
            {
                this.uComField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string qCom
        {
            get
            {
                return this.qComField;
            }
            set
            {
                this.qComField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string vUnCom
        {
            get
            {
                return this.vUnComField;
            }
            set
            {
                this.vUnComField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string cEANTrib
        {
            get
            {
                return this.cEANTribField;
            }
            set
            {
                this.cEANTribField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string uTrib
        {
            get
            {
                return this.uTribField;
            }
            set
            {
                this.uTribField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string qTrib
        {
            get
            {
                return this.qTribField;
            }
            set
            {
                this.qTribField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string vUnTrib
        {
            get
            {
                return this.vUnTribField;
            }
            set
            {
                this.vUnTribField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string vSeg
        {
            get
            {
                return this.vSegField;
            }
            set
            {
                this.vSegField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public TNFeInfNFeDetProdIndTot indTot
        {
            get
            {
                return this.indTotField;
            }
            set
            {
                this.indTotField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("DI", Order = 21)]
        public TNFeInfNFeDetProdDI[] DI
        {
            get
            {
                return this.diField;
            }
            set
            {
                this.diField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("detExport", Order = 22)]
        public TNFeInfNFeDetProdDetExport[] detExport
        {
            get
            {
                return this.detExportField;
            }
            set
            {
                this.detExportField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public string xPed
        {
            get
            {
                return this.xPedField;
            }
            set
            {
                this.xPedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public string nItemPed
        {
            get
            {
                return this.nItemPedField;
            }
            set
            {
                this.nItemPedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public string nFCI
        {
            get
            {
                return this.nFCIField;
            }
            set
            {
                this.nFCIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma), Order = 26)]
        [System.Xml.Serialization.XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb), Order = 26)]
        [System.Xml.Serialization.XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed), Order = 26)]
        [System.Xml.Serialization.XmlElementAttribute("nRECOPI", typeof(string), Order = 26)]
        [System.Xml.Serialization.XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd), Order = 26)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdIndTot
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDI
    {

        private string nDIField;

        private string dDIField;

        private string xLocDesembField;

        private TUfEmi uFDesembField;

        private string dDesembField;

        private TNFeInfNFeDetProdDITpViaTransp tpViaTranspField;

        private string vAFRMMField;

        private TNFeInfNFeDetProdDITpIntermedio tpIntermedioField;

        private string cNPJField;

        private TUfEmi uFTerceiroField;

        private bool uFTerceiroFieldSpecified;

        private string cExportadorField;

        private TNFeInfNFeDetProdDIAdi[] adiField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nDI
        {
            get
            {
                return this.nDIField;
            }
            set
            {
                this.nDIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string dDI
        {
            get
            {
                return this.dDIField;
            }
            set
            {
                this.dDIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xLocDesemb
        {
            get
            {
                return this.xLocDesembField;
            }
            set
            {
                this.xLocDesembField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TUfEmi UFDesemb
        {
            get
            {
                return this.uFDesembField;
            }
            set
            {
                this.uFDesembField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string dDesemb
        {
            get
            {
                return this.dDesembField;
            }
            set
            {
                this.dDesembField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TNFeInfNFeDetProdDITpViaTransp tpViaTransp
        {
            get
            {
                return this.tpViaTranspField;
            }
            set
            {
                this.tpViaTranspField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vAFRMM
        {
            get
            {
                return this.vAFRMMField;
            }
            set
            {
                this.vAFRMMField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public TNFeInfNFeDetProdDITpIntermedio tpIntermedio
        {
            get
            {
                return this.tpIntermedioField;
            }
            set
            {
                this.tpIntermedioField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TUfEmi UFTerceiro
        {
            get
            {
                return this.uFTerceiroField;
            }
            set
            {
                this.uFTerceiroField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFTerceiroSpecified
        {
            get
            {
                return this.uFTerceiroFieldSpecified;
            }
            set
            {
                this.uFTerceiroFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string cExportador
        {
            get
            {
                return this.cExportadorField;
            }
            set
            {
                this.cExportadorField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("adi", Order = 11)]
        public TNFeInfNFeDetProdDIAdi[] adi
        {
            get
            {
                return this.adiField;
            }
            set
            {
                this.adiField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdDITpViaTransp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdDITpIntermedio
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDIAdi
    {

        private string nAdicaoField;

        private string nSeqAdicField;

        private string cFabricanteField;

        private string vDescDIField;

        private string nDrawField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nAdicao
        {
            get
            {
                return this.nAdicaoField;
            }
            set
            {
                this.nAdicaoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string nSeqAdic
        {
            get
            {
                return this.nSeqAdicField;
            }
            set
            {
                this.nSeqAdicField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string cFabricante
        {
            get
            {
                return this.cFabricanteField;
            }
            set
            {
                this.cFabricanteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vDescDI
        {
            get
            {
                return this.vDescDIField;
            }
            set
            {
                this.vDescDIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string nDraw
        {
            get
            {
                return this.nDrawField;
            }
            set
            {
                this.nDrawField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDetExport
    {

        private string nDrawField;

        private TNFeInfNFeDetProdDetExportExportInd exportIndField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nDraw
        {
            get
            {
                return this.nDrawField;
            }
            set
            {
                this.nDrawField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetProdDetExportExportInd exportInd
        {
            get
            {
                return this.exportIndField;
            }
            set
            {
                this.exportIndField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDetExportExportInd
    {

        private string nREField;

        private string chNFeField;

        private string qExportField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nRE
        {
            get
            {
                return this.nREField;
            }
            set
            {
                this.nREField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string chNFe
        {
            get
            {
                return this.chNFeField;
            }
            set
            {
                this.chNFeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string qExport
        {
            get
            {
                return this.qExportField;
            }
            set
            {
                this.qExportField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdArma
    {

        private TNFeInfNFeDetProdArmaTpArma tpArmaField;

        private string nSerieField;

        private string nCanoField;

        private string descrField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetProdArmaTpArma tpArma
        {
            get
            {
                return this.tpArmaField;
            }
            set
            {
                this.tpArmaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string nSerie
        {
            get
            {
                return this.nSerieField;
            }
            set
            {
                this.nSerieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string nCano
        {
            get
            {
                return this.nCanoField;
            }
            set
            {
                this.nCanoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string descr
        {
            get
            {
                return this.descrField;
            }
            set
            {
                this.descrField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdArmaTpArma
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdComb
    {

        private string cProdANPField;

        private string pMixGNField;

        private string cODIFField;

        private string qTempField;

        private TUf uFConsField;

        private TNFeInfNFeDetProdCombCIDE cIDEField;

        private TNFeInfNFeDetProdCombEncerrante encerranteField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string cProdANP
        {
            get
            {
                return this.cProdANPField;
            }
            set
            {
                this.cProdANPField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string pMixGN
        {
            get
            {
                return this.pMixGNField;
            }
            set
            {
                this.pMixGNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CODIF
        {
            get
            {
                return this.cODIFField;
            }
            set
            {
                this.cODIFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string qTemp
        {
            get
            {
                return this.qTempField;
            }
            set
            {
                this.qTempField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TUf UFCons
        {
            get
            {
                return this.uFConsField;
            }
            set
            {
                this.uFConsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TNFeInfNFeDetProdCombCIDE CIDE
        {
            get
            {
                return this.cIDEField;
            }
            set
            {
                this.cIDEField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TNFeInfNFeDetProdCombEncerrante encerrante
        {
            get
            {
                return this.encerranteField;
            }
            set
            {
                this.encerranteField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdCombCIDE
    {

        private string qBCProdField;

        private string vAliqProdField;

        private string vCIDEField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vCIDE
        {
            get
            {
                return this.vCIDEField;
            }
            set
            {
                this.vCIDEField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdCombEncerrante
    {

        private string nBicoField;

        private string nBombaField;

        private string nTanqueField;

        private string vEncIniField;

        private string vEncFinField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nBico
        {
            get
            {
                return this.nBicoField;
            }
            set
            {
                this.nBicoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string nBomba
        {
            get
            {
                return this.nBombaField;
            }
            set
            {
                this.nBombaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string nTanque
        {
            get
            {
                return this.nTanqueField;
            }
            set
            {
                this.nTanqueField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vEncIni
        {
            get
            {
                return this.vEncIniField;
            }
            set
            {
                this.vEncIniField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vEncFin
        {
            get
            {
                return this.vEncFinField;
            }
            set
            {
                this.vEncFinField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdMed
    {

        private string nLoteField;

        private string qLoteField;

        private string dFabField;

        private string dValField;

        private string vPMCField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nLote
        {
            get
            {
                return this.nLoteField;
            }
            set
            {
                this.nLoteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string qLote
        {
            get
            {
                return this.qLoteField;
            }
            set
            {
                this.qLoteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string dFab
        {
            get
            {
                return this.dFabField;
            }
            set
            {
                this.dFabField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string dVal
        {
            get
            {
                return this.dValField;
            }
            set
            {
                this.dValField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vPMC
        {
            get
            {
                return this.vPMCField;
            }
            set
            {
                this.vPMCField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdVeicProd
    {

        private TNFeInfNFeDetProdVeicProdTpOp tpOpField;

        private string chassiField;

        private string cCorField;

        private string xCorField;

        private string potField;

        private string cilinField;

        private string pesoLField;

        private string pesoBField;

        private string nSerieField;

        private string tpCombField;

        private string nMotorField;

        private string cMTField;

        private string distField;

        private string anoModField;

        private string anoFabField;

        private string tpPintField;

        private string tpVeicField;

        private string espVeicField;

        private TNFeInfNFeDetProdVeicProdVIN vINField;

        private TNFeInfNFeDetProdVeicProdCondVeic condVeicField;

        private string cModField;

        private string cCorDENATRANField;

        private string lotaField;

        private TNFeInfNFeDetProdVeicProdTpRest tpRestField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetProdVeicProdTpOp tpOp
        {
            get
            {
                return this.tpOpField;
            }
            set
            {
                this.tpOpField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string chassi
        {
            get
            {
                return this.chassiField;
            }
            set
            {
                this.chassiField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string cCor
        {
            get
            {
                return this.cCorField;
            }
            set
            {
                this.cCorField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string xCor
        {
            get
            {
                return this.xCorField;
            }
            set
            {
                this.xCorField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pot
        {
            get
            {
                return this.potField;
            }
            set
            {
                this.potField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string cilin
        {
            get
            {
                return this.cilinField;
            }
            set
            {
                this.cilinField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string pesoL
        {
            get
            {
                return this.pesoLField;
            }
            set
            {
                this.pesoLField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string pesoB
        {
            get
            {
                return this.pesoBField;
            }
            set
            {
                this.pesoBField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string nSerie
        {
            get
            {
                return this.nSerieField;
            }
            set
            {
                this.nSerieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string tpComb
        {
            get
            {
                return this.tpCombField;
            }
            set
            {
                this.tpCombField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string nMotor
        {
            get
            {
                return this.nMotorField;
            }
            set
            {
                this.nMotorField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string CMT
        {
            get
            {
                return this.cMTField;
            }
            set
            {
                this.cMTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string dist
        {
            get
            {
                return this.distField;
            }
            set
            {
                this.distField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string anoMod
        {
            get
            {
                return this.anoModField;
            }
            set
            {
                this.anoModField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string anoFab
        {
            get
            {
                return this.anoFabField;
            }
            set
            {
                this.anoFabField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string tpPint
        {
            get
            {
                return this.tpPintField;
            }
            set
            {
                this.tpPintField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string tpVeic
        {
            get
            {
                return this.tpVeicField;
            }
            set
            {
                this.tpVeicField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string espVeic
        {
            get
            {
                return this.espVeicField;
            }
            set
            {
                this.espVeicField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public TNFeInfNFeDetProdVeicProdVIN VIN
        {
            get
            {
                return this.vINField;
            }
            set
            {
                this.vINField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public TNFeInfNFeDetProdVeicProdCondVeic condVeic
        {
            get
            {
                return this.condVeicField;
            }
            set
            {
                this.condVeicField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string cMod
        {
            get
            {
                return this.cModField;
            }
            set
            {
                this.cModField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string cCorDENATRAN
        {
            get
            {
                return this.cCorDENATRANField;
            }
            set
            {
                this.cCorDENATRANField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public string lota
        {
            get
            {
                return this.lotaField;
            }
            set
            {
                this.lotaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public TNFeInfNFeDetProdVeicProdTpRest tpRest
        {
            get
            {
                return this.tpRestField;
            }
            set
            {
                this.tpRestField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpOp
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdVIN
    {

        /// <remarks/>
        R,

        /// <remarks/>
        N,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdCondVeic
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpRest
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImposto
    {

        private string vTotTribField;

        private object[] itemsField;

        private TNFeInfNFeDetImpostoPIS pISField;

        private TNFeInfNFeDetImpostoPISST pISSTField;

        private TNFeInfNFeDetImpostoCOFINS cOFINSField;

        private TNFeInfNFeDetImpostoCOFINSST cOFINSSTField;

        private TNFeInfNFeDetImpostoICMSUFDest iCMSUFDestField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("IPI", typeof(TIpi), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN), Order = 1)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoPIS PIS
        {
            get
            {
                return this.pISField;
            }
            set
            {
                this.pISField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TNFeInfNFeDetImpostoPISST PISST
        {
            get
            {
                return this.pISSTField;
            }
            set
            {
                this.pISSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TNFeInfNFeDetImpostoCOFINS COFINS
        {
            get
            {
                return this.cOFINSField;
            }
            set
            {
                this.cOFINSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public TNFeInfNFeDetImpostoCOFINSST COFINSST
        {
            get
            {
                return this.cOFINSSTField;
            }
            set
            {
                this.cOFINSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TNFeInfNFeDetImpostoICMSUFDest ICMSUFDest
        {
            get
            {
                return this.iCMSUFDestField;
            }
            set
            {
                this.iCMSUFDestField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMS
    {

        private object itemField;

        [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS00
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS00CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS00ModBC modBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS00CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum Torig
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("00")]
        Item00,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS10
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS10CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS10ModBC modBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS10CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS20
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS20CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS20ModBC modBCField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS20CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS30
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS30CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS30CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS40
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS40CST cSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS40CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS51
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS51CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS51ModBC modBCField;

        private bool modBCFieldSpecified;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSOpField;

        private string pDifField;

        private string vICMSDifField;

        private string vICMSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS51CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool modBCSpecified
        {
            get
            {
                return this.modBCFieldSpecified;
            }
            set
            {
                this.modBCFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vICMSOp
        {
            get
            {
                return this.vICMSOpField;
            }
            set
            {
                this.vICMSOpField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string pDif
        {
            get
            {
                return this.pDifField;
            }
            set
            {
                this.pDifField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string vICMSDif
        {
            get
            {
                return this.vICMSDifField;
            }
            set
            {
                this.vICMSDifField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS60
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS60CST cSTField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS60CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS60CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS70
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS70CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS70ModBC modBCField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS70CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS90
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS90CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS90ModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMS90CST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMS
        {
            get
            {
                return this.motDesICMSField;
            }
            set
            {
                this.motDesICMSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90CST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSPart
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSPartCST cSTField;

        private TNFeInfNFeDetImpostoICMSICMSPartModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pBCOpField;

        private TUf uFSTField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMSPartCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string pBCOp
        {
            get
            {
                return this.pBCOpField;
            }
            set
            {
                this.pBCOpField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public TUf UFST
        {
            get
            {
                return this.uFSTField;
            }
            set
            {
                this.uFSTField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("90")]
        Item90,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN101
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN101CSOSN cSOSNField;

        private string pCredSNField;

        private string vCredICMSSNField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("101")]
        Item101,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN102
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN102CSOSN cSOSNField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("102")]
        Item102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("103")]
        Item103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN201
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN201CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pCredSNField;

        private string vCredICMSSNField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("201")]
        Item201,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN202
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN202CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("202")]
        Item202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("203")]
        Item203,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN500
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN500CSOSN cSOSNField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("500")]
        Item500,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN900
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN900CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pCredSNField;

        private string vCredICMSSNField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN
        {
            get
            {
                return this.cSOSNField;
            }
            set
            {
                this.cSOSNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC
        {
            get
            {
                return this.modBCField;
            }
            set
            {
                this.modBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pRedBC
        {
            get
            {
                return this.pRedBCField;
            }
            set
            {
                this.pRedBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string pICMS
        {
            get
            {
                return this.pICMSField;
            }
            set
            {
                this.pICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST
        {
            get
            {
                return this.modBCSTField;
            }
            set
            {
                this.modBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string pMVAST
        {
            get
            {
                return this.pMVASTField;
            }
            set
            {
                this.pMVASTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string pRedBCST
        {
            get
            {
                return this.pRedBCSTField;
            }
            set
            {
                this.pRedBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string pICMSST
        {
            get
            {
                return this.pICMSSTField;
            }
            set
            {
                this.pICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string vICMSST
        {
            get
            {
                return this.vICMSSTField;
            }
            set
            {
                this.vICMSSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string pCredSN
        {
            get
            {
                return this.pCredSNField;
            }
            set
            {
                this.pCredSNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string vCredICMSSN
        {
            get
            {
                return this.vCredICMSSNField;
            }
            set
            {
                this.vCredICMSSNField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("900")]
        Item900,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSST
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSTCST cSTField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        private string vBCSTDestField;

        private string vICMSSTDestField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Torig orig
        {
            get
            {
                return this.origField;
            }
            set
            {
                this.origField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoICMSICMSSTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vBCSTRet
        {
            get
            {
                return this.vBCSTRetField;
            }
            set
            {
                this.vBCSTRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vICMSSTRet
        {
            get
            {
                return this.vICMSSTRetField;
            }
            set
            {
                this.vICMSSTRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vBCSTDest
        {
            get
            {
                return this.vBCSTDestField;
            }
            set
            {
                this.vBCSTDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vICMSSTDest
        {
            get
            {
                return this.vICMSSTDestField;
            }
            set
            {
                this.vICMSSTDestField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoII
    {

        private string vBCField;

        private string vDespAduField;

        private string vIIField;

        private string vIOFField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vDespAdu
        {
            get
            {
                return this.vDespAduField;
            }
            set
            {
                this.vDespAduField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vII
        {
            get
            {
                return this.vIIField;
            }
            set
            {
                this.vIIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vIOF
        {
            get
            {
                return this.vIOFField;
            }
            set
            {
                this.vIOFField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoISSQN
    {

        private string vBCField;

        private string vAliqField;

        private string vISSQNField;

        private string cMunFGField;

        private TCListServ cListServField;

        private string vDeducaoField;

        private string vOutroField;

        private string vDescIncondField;

        private string vDescCondField;

        private string vISSRetField;

        private TNFeInfNFeDetImpostoISSQNIndISS indISSField;

        private string cServicoField;

        private string cMunField;

        private string cPaisField;

        private string nProcessoField;

        private TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivoField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vAliq
        {
            get
            {
                return this.vAliqField;
            }
            set
            {
                this.vAliqField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vISSQN
        {
            get
            {
                return this.vISSQNField;
            }
            set
            {
                this.vISSQNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public TCListServ cListServ
        {
            get
            {
                return this.cListServField;
            }
            set
            {
                this.cListServField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vDeducao
        {
            get
            {
                return this.vDeducaoField;
            }
            set
            {
                this.vDeducaoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vDescIncond
        {
            get
            {
                return this.vDescIncondField;
            }
            set
            {
                this.vDescIncondField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string vDescCond
        {
            get
            {
                return this.vDescCondField;
            }
            set
            {
                this.vDescCondField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string vISSRet
        {
            get
            {
                return this.vISSRetField;
            }
            set
            {
                this.vISSRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public TNFeInfNFeDetImpostoISSQNIndISS indISS
        {
            get
            {
                return this.indISSField;
            }
            set
            {
                this.indISSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string cServico
        {
            get
            {
                return this.cServicoField;
            }
            set
            {
                this.cServicoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string cMun
        {
            get
            {
                return this.cMunField;
            }
            set
            {
                this.cMunField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string cPais
        {
            get
            {
                return this.cPaisField;
            }
            set
            {
                this.cPaisField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string nProcesso
        {
            get
            {
                return this.nProcessoField;
            }
            set
            {
                this.nProcessoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivo
        {
            get
            {
                return this.indIncentivoField;
            }
            set
            {
                this.indIncentivoField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCListServ
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.01")]
        Item0101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.02")]
        Item0102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.03")]
        Item0103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.04")]
        Item0104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.05")]
        Item0105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.06")]
        Item0106,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.07")]
        Item0107,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01.08")]
        Item0108,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02.01")]
        Item0201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03.02")]
        Item0302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03.03")]
        Item0303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03.04")]
        Item0304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03.05")]
        Item0305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.01")]
        Item0401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.02")]
        Item0402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.03")]
        Item0403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.04")]
        Item0404,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.05")]
        Item0405,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.06")]
        Item0406,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.07")]
        Item0407,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.08")]
        Item0408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.09")]
        Item0409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.10")]
        Item0410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.11")]
        Item0411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.12")]
        Item0412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.13")]
        Item0413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.14")]
        Item0414,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.15")]
        Item0415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.16")]
        Item0416,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.17")]
        Item0417,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.18")]
        Item0418,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.19")]
        Item0419,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.20")]
        Item0420,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.21")]
        Item0421,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.22")]
        Item0422,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04.23")]
        Item0423,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.01")]
        Item0501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.02")]
        Item0502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.03")]
        Item0503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.04")]
        Item0504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.05")]
        Item0505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.06")]
        Item0506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.07")]
        Item0507,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.08")]
        Item0508,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05.09")]
        Item0509,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.01")]
        Item0601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.02")]
        Item0602,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.03")]
        Item0603,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.04")]
        Item0604,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06.05")]
        Item0605,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.01")]
        Item0701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.02")]
        Item0702,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.03")]
        Item0703,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.04")]
        Item0704,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.05")]
        Item0705,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.06")]
        Item0706,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.07")]
        Item0707,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.08")]
        Item0708,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.09")]
        Item0709,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.10")]
        Item0710,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.11")]
        Item0711,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.12")]
        Item0712,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.13")]
        Item0713,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.16")]
        Item0716,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.17")]
        Item0717,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.18")]
        Item0718,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.19")]
        Item0719,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.20")]
        Item0720,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.21")]
        Item0721,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07.22")]
        Item0722,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08.01")]
        Item0801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08.02")]
        Item0802,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09.01")]
        Item0901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09.02")]
        Item0902,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09.03")]
        Item0903,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.01")]
        Item1001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.02")]
        Item1002,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.03")]
        Item1003,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.04")]
        Item1004,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.05")]
        Item1005,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.06")]
        Item1006,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.07")]
        Item1007,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.08")]
        Item1008,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.09")]
        Item1009,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10.10")]
        Item1010,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11.01")]
        Item1101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11.02")]
        Item1102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11.03")]
        Item1103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11.04")]
        Item1104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.01")]
        Item1201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.02")]
        Item1202,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.03")]
        Item1203,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.04")]
        Item1204,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.05")]
        Item1205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.06")]
        Item1206,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.07")]
        Item1207,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.08")]
        Item1208,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.09")]
        Item1209,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.10")]
        Item1210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.11")]
        Item1211,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.12")]
        Item1212,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.13")]
        Item1213,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.14")]
        Item1214,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.15")]
        Item1215,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.16")]
        Item1216,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.17")]
        Item1217,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13.02")]
        Item1302,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13.03")]
        Item1303,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13.04")]
        Item1304,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13.05")]
        Item1305,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.01")]
        Item1401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.02")]
        Item1402,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.03")]
        Item1403,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.04")]
        Item1404,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.05")]
        Item1405,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.06")]
        Item1406,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.07")]
        Item1407,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.08")]
        Item1408,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.09")]
        Item1409,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.10")]
        Item1410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.11")]
        Item1411,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.12")]
        Item1412,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14.13")]
        Item1413,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.01")]
        Item1501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.02")]
        Item1502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.03")]
        Item1503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.04")]
        Item1504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.05")]
        Item1505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.06")]
        Item1506,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.07")]
        Item1507,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.08")]
        Item1508,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.09")]
        Item1509,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.10")]
        Item1510,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.11")]
        Item1511,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.12")]
        Item1512,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.13")]
        Item1513,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.14")]
        Item1514,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.15")]
        Item1515,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.16")]
        Item1516,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.17")]
        Item1517,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15.18")]
        Item1518,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16.01")]
        Item1601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.01")]
        Item1701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.02")]
        Item1702,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.03")]
        Item1703,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.04")]
        Item1704,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.05")]
        Item1705,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.06")]
        Item1706,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.08")]
        Item1708,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.09")]
        Item1709,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.10")]
        Item1710,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.11")]
        Item1711,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.12")]
        Item1712,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.13")]
        Item1713,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.14")]
        Item1714,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.15")]
        Item1715,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.16")]
        Item1716,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.17")]
        Item1717,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.18")]
        Item1718,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.19")]
        Item1719,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.20")]
        Item1720,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.21")]
        Item1721,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.22")]
        Item1722,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.23")]
        Item1723,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17.24")]
        Item1724,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18.01")]
        Item1801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19.01")]
        Item1901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20.01")]
        Item2001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20.02")]
        Item2002,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20.03")]
        Item2003,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21.01")]
        Item2101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22.01")]
        Item2201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23.01")]
        Item2301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24.01")]
        Item2401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.01")]
        Item2501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.02")]
        Item2502,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.03")]
        Item2503,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25.04")]
        Item2504,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26.01")]
        Item2601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27.01")]
        Item2701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28.01")]
        Item2801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29.01")]
        Item2901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30.01")]
        Item3001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31.01")]
        Item3101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32.01")]
        Item3201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33.01")]
        Item3301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34.01")]
        Item3401,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35.01")]
        Item3501,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36.01")]
        Item3601,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37.01")]
        Item3701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38.01")]
        Item3801,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39.01")]
        Item3901,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40.01")]
        Item4001,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNIndISS
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNIndIncentivo
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPIS
    {

        private object itemField;

        [System.Xml.Serialization.XmlElementAttribute("PISAliq", typeof(TNFeInfNFeDetImpostoPISPISAliq), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PISNT", typeof(TNFeInfNFeDetImpostoPISPISNT), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PISOutr", typeof(TNFeInfNFeDetImpostoPISPISOutr), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("PISQtde", typeof(TNFeInfNFeDetImpostoPISPISQtde), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISAliq
    {

        private TNFeInfNFeDetImpostoPISPISAliqCST cSTField;

        private string vBCField;

        private string pPISField;

        private string vPISField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetImpostoPISPISAliqCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string pPIS
        {
            get
            {
                return this.pPISField;
            }
            set
            {
                this.pPISField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISAliqCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISNT
    {

        private TNFeInfNFeDetImpostoPISPISNTCST cSTField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetImpostoPISPISNTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISNTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISOutr
    {

        private TNFeInfNFeDetImpostoPISPISOutrCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private string vPISField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetImpostoPISPISOutrCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISOutrCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        pPIS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISQtde
    {

        private TNFeInfNFeDetImpostoPISPISQtdeCST cSTField;

        private string qBCProdField;

        private string vAliqProdField;

        private string vPISField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetImpostoPISPISQtdeCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISST
    {

        private string[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private string vPISField;

        [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        pPIS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINS
    {

        private object itemField;

        [System.Xml.Serialization.XmlElementAttribute("COFINSAliq", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliq), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("COFINSNT", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNT), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("COFINSOutr", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutr), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("COFINSQtde", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtde), Order = 0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST cSTField;

        private string vBCField;

        private string pCOFINSField;

        private string vCOFINSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string pCOFINS
        {
            get
            {
                return this.pCOFINSField;
            }
            set
            {
                this.pCOFINSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSNTCST cSTField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        private string vCOFINSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string), Order = 1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {

        /// <remarks/>
        pCOFINS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST cSTField;

        private string qBCProdField;

        private string vAliqProdField;

        private string vCOFINSField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST
        {
            get
            {
                return this.cSTField;
            }
            set
            {
                this.cSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string qBCProd
        {
            get
            {
                return this.qBCProdField;
            }
            set
            {
                this.qBCProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vAliqProd
        {
            get
            {
                return this.vAliqProdField;
            }
            set
            {
                this.vAliqProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSST
    {

        private string[] itemsField;

        private ItemsChoiceType4[] itemsElementNameField;

        private string vCOFINSField;

        [System.Xml.Serialization.XmlElementAttribute("pCOFINS", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType4[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {

        /// <remarks/>
        pCOFINS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSUFDest
    {

        private string vBCUFDestField;

        private string pFCPUFDestField;

        private string pICMSUFDestField;

        private TNFeInfNFeDetImpostoICMSUFDestPICMSInter pICMSInterField;

        private string pICMSInterPartField;

        private string vFCPUFDestField;

        private string vICMSUFDestField;

        private string vICMSUFRemetField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vBCUFDest
        {
            get
            {
                return this.vBCUFDestField;
            }
            set
            {
                this.vBCUFDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string pFCPUFDest
        {
            get
            {
                return this.pFCPUFDestField;
            }
            set
            {
                this.pFCPUFDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string pICMSUFDest
        {
            get
            {
                return this.pICMSUFDestField;
            }
            set
            {
                this.pICMSUFDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public TNFeInfNFeDetImpostoICMSUFDestPICMSInter pICMSInter
        {
            get
            {
                return this.pICMSInterField;
            }
            set
            {
                this.pICMSInterField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pICMSInterPart
        {
            get
            {
                return this.pICMSInterPartField;
            }
            set
            {
                this.pICMSInterPartField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vFCPUFDest
        {
            get
            {
                return this.vFCPUFDestField;
            }
            set
            {
                this.vFCPUFDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vICMSUFDest
        {
            get
            {
                return this.vICMSUFDestField;
            }
            set
            {
                this.vICMSUFDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vICMSUFRemet
        {
            get
            {
                return this.vICMSUFRemetField;
            }
            set
            {
                this.vICMSUFRemetField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSUFDestPICMSInter
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4.00")]
        Item400,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7.00")]
        Item700,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12.00")]
        Item1200,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevol
    {

        private string pDevolField;

        private TNFeInfNFeDetImpostoDevolIPI iPIField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string pDevol
        {
            get
            {
                return this.pDevolField;
            }
            set
            {
                this.pDevolField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeDetImpostoDevolIPI IPI
        {
            get
            {
                return this.iPIField;
            }
            set
            {
                this.iPIField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevolIPI
    {

        private string vIPIDevolField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vIPIDevol
        {
            get
            {
                return this.vIPIDevolField;
            }
            set
            {
                this.vIPIDevolField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotal
    {

        private TNFeInfNFeTotalICMSTot iCMSTotField;

        private TNFeInfNFeTotalISSQNtot iSSQNtotField;

        private TNFeInfNFeTotalRetTrib retTribField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeTotalICMSTot ICMSTot
        {
            get
            {
                return this.iCMSTotField;
            }
            set
            {
                this.iCMSTotField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeTotalISSQNtot ISSQNtot
        {
            get
            {
                return this.iSSQNtotField;
            }
            set
            {
                this.iSSQNtotField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeTotalRetTrib retTrib
        {
            get
            {
                return this.retTribField;
            }
            set
            {
                this.retTribField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalICMSTot
    {

        private string vBCField;

        private string vICMSField;

        private string vICMSDesonField;

        private string vFCPUFDestField;

        private string vICMSUFDestField;

        private string vICMSUFRemetField;

        private string vBCSTField;

        private string vSTField;

        private string vProdField;

        private string vFreteField;

        private string vSegField;

        private string vDescField;

        private string vIIField;

        private string vIPIField;

        private string vPISField;

        private string vCOFINSField;

        private string vOutroField;

        private string vNFField;

        private string vTotTribField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vICMS
        {
            get
            {
                return this.vICMSField;
            }
            set
            {
                this.vICMSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vICMSDeson
        {
            get
            {
                return this.vICMSDesonField;
            }
            set
            {
                this.vICMSDesonField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vFCPUFDest
        {
            get
            {
                return this.vFCPUFDestField;
            }
            set
            {
                this.vFCPUFDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vICMSUFDest
        {
            get
            {
                return this.vICMSUFDestField;
            }
            set
            {
                this.vICMSUFDestField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vICMSUFRemet
        {
            get
            {
                return this.vICMSUFRemetField;
            }
            set
            {
                this.vICMSUFRemetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vBCST
        {
            get
            {
                return this.vBCSTField;
            }
            set
            {
                this.vBCSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vST
        {
            get
            {
                return this.vSTField;
            }
            set
            {
                this.vSTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string vProd
        {
            get
            {
                return this.vProdField;
            }
            set
            {
                this.vProdField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string vFrete
        {
            get
            {
                return this.vFreteField;
            }
            set
            {
                this.vFreteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string vSeg
        {
            get
            {
                return this.vSegField;
            }
            set
            {
                this.vSegField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string vII
        {
            get
            {
                return this.vIIField;
            }
            set
            {
                this.vIIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string vIPI
        {
            get
            {
                return this.vIPIField;
            }
            set
            {
                this.vIPIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string vNF
        {
            get
            {
                return this.vNFField;
            }
            set
            {
                this.vNFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string vTotTrib
        {
            get
            {
                return this.vTotTribField;
            }
            set
            {
                this.vTotTribField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalISSQNtot
    {

        private string vServField;

        private string vBCField;

        private string vISSField;

        private string vPISField;

        private string vCOFINSField;

        private string dCompetField;

        private string vDeducaoField;

        private string vOutroField;

        private string vDescIncondField;

        private string vDescCondField;

        private string vISSRetField;

        private TNFeInfNFeTotalISSQNtotCRegTrib cRegTribField;

        private bool cRegTribFieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vServ
        {
            get
            {
                return this.vServField;
            }
            set
            {
                this.vServField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vBC
        {
            get
            {
                return this.vBCField;
            }
            set
            {
                this.vBCField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vISS
        {
            get
            {
                return this.vISSField;
            }
            set
            {
                this.vISSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vPIS
        {
            get
            {
                return this.vPISField;
            }
            set
            {
                this.vPISField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vCOFINS
        {
            get
            {
                return this.vCOFINSField;
            }
            set
            {
                this.vCOFINSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string dCompet
        {
            get
            {
                return this.dCompetField;
            }
            set
            {
                this.dCompetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vDeducao
        {
            get
            {
                return this.vDeducaoField;
            }
            set
            {
                this.vDeducaoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vOutro
        {
            get
            {
                return this.vOutroField;
            }
            set
            {
                this.vOutroField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string vDescIncond
        {
            get
            {
                return this.vDescIncondField;
            }
            set
            {
                this.vDescIncondField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string vDescCond
        {
            get
            {
                return this.vDescCondField;
            }
            set
            {
                this.vDescCondField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string vISSRet
        {
            get
            {
                return this.vISSRetField;
            }
            set
            {
                this.vISSRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public TNFeInfNFeTotalISSQNtotCRegTrib cRegTrib
        {
            get
            {
                return this.cRegTribField;
            }
            set
            {
                this.cRegTribField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cRegTribSpecified
        {
            get
            {
                return this.cRegTribFieldSpecified;
            }
            set
            {
                this.cRegTribFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTotalISSQNtotCRegTrib
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalRetTrib
    {

        private string vRetPISField;

        private string vRetCOFINSField;

        private string vRetCSLLField;

        private string vBCIRRFField;

        private string vIRRFField;

        private string vBCRetPrevField;

        private string vRetPrevField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vRetPIS
        {
            get
            {
                return this.vRetPISField;
            }
            set
            {
                this.vRetPISField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vRetCOFINS
        {
            get
            {
                return this.vRetCOFINSField;
            }
            set
            {
                this.vRetCOFINSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vRetCSLL
        {
            get
            {
                return this.vRetCSLLField;
            }
            set
            {
                this.vRetCSLLField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vBCIRRF
        {
            get
            {
                return this.vBCIRRFField;
            }
            set
            {
                this.vBCIRRFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string vIRRF
        {
            get
            {
                return this.vIRRFField;
            }
            set
            {
                this.vIRRFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string vBCRetPrev
        {
            get
            {
                return this.vBCRetPrevField;
            }
            set
            {
                this.vBCRetPrevField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string vRetPrev
        {
            get
            {
                return this.vRetPrevField;
            }
            set
            {
                this.vRetPrevField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTransp
    {

        private TNFeInfNFeTranspModFrete modFreteField;

        private TNFeInfNFeTranspTransporta transportaField;

        private TNFeInfNFeTranspRetTransp retTranspField;

        private object[] itemsField;

        private ItemsChoiceType5[] itemsElementNameField;

        private TNFeInfNFeTranspVol[] volField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeTranspModFrete modFrete
        {
            get
            {
                return this.modFreteField;
            }
            set
            {
                this.modFreteField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeTranspTransporta transporta
        {
            get
            {
                return this.transportaField;
            }
            set
            {
                this.transportaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFeTranspRetTransp retTransp
        {
            get
            {
                return this.retTranspField;
            }
            set
            {
                this.retTranspField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("balsa", typeof(string), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("reboque", typeof(TVeiculo), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("vagao", typeof(string), Order = 3)]
        [System.Xml.Serialization.XmlElementAttribute("veicTransp", typeof(TVeiculo), Order = 3)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 4)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType5[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("vol", Order = 5)]
        public TNFeInfNFeTranspVol[] vol
        {
            get
            {
                return this.volField;
            }
            set
            {
                this.volField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTranspModFrete
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspTransporta
    {

        private string itemField;

        private ItemChoiceType6 itemElementNameField;

        private string xNomeField;

        private string ieField;

        private string xEnderField;

        private string xMunField;

        private TUf ufField;

        private bool ufFieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string), Order = 0)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType6 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xNome
        {
            get
            {
                return this.xNomeField;
            }
            set
            {
                this.xNomeField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string IE
        {
            get
            {
                return this.ieField;
            }
            set
            {
                this.ieField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string xEnder
        {
            get
            {
                return this.xEnderField;
            }
            set
            {
                this.xEnderField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string xMun
        {
            get
            {
                return this.xMunField;
            }
            set
            {
                this.xMunField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public TUf UF
        {
            get
            {
                return this.ufField;
            }
            set
            {
                this.ufField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UFSpecified
        {
            get
            {
                return this.ufFieldSpecified;
            }
            set
            {
                this.ufFieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType6
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspRetTransp
    {

        private string vServField;

        private string vBCRetField;

        private string pICMSRetField;

        private string vICMSRetField;

        private string cFOPField;

        private string cMunFGField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string vServ
        {
            get
            {
                return this.vServField;
            }
            set
            {
                this.vServField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vBCRet
        {
            get
            {
                return this.vBCRetField;
            }
            set
            {
                this.vBCRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string pICMSRet
        {
            get
            {
                return this.pICMSRetField;
            }
            set
            {
                this.pICMSRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vICMSRet
        {
            get
            {
                return this.vICMSRetField;
            }
            set
            {
                this.vICMSRetField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string CFOP
        {
            get
            {
                return this.cFOPField;
            }
            set
            {
                this.cFOPField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string cMunFG
        {
            get
            {
                return this.cMunFGField;
            }
            set
            {
                this.cMunFGField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType5
    {

        /// <remarks/>
        balsa,

        /// <remarks/>
        reboque,

        /// <remarks/>
        vagao,

        /// <remarks/>
        veicTransp,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVol
    {

        private string qVolField;

        private string espField;

        private string marcaField;

        private string nVolField;

        private string pesoLField;

        private string pesoBField;

        private TNFeInfNFeTranspVolLacres[] lacresField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string qVol
        {
            get
            {
                return this.qVolField;
            }
            set
            {
                this.qVolField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string esp
        {
            get
            {
                return this.espField;
            }
            set
            {
                this.espField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string marca
        {
            get
            {
                return this.marcaField;
            }
            set
            {
                this.marcaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string nVol
        {
            get
            {
                return this.nVolField;
            }
            set
            {
                this.nVolField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string pesoL
        {
            get
            {
                return this.pesoLField;
            }
            set
            {
                this.pesoLField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string pesoB
        {
            get
            {
                return this.pesoBField;
            }
            set
            {
                this.pesoBField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("lacres", Order = 6)]
        public TNFeInfNFeTranspVolLacres[] lacres
        {
            get
            {
                return this.lacresField;
            }
            set
            {
                this.lacresField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVolLacres
    {

        private string nLacreField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nLacre
        {
            get
            {
                return this.nLacreField;
            }
            set
            {
                this.nLacreField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobr
    {

        private TNFeInfNFeCobrFat fatField;

        private TNFeInfNFeCobrDup[] dupField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFeCobrFat fat
        {
            get
            {
                return this.fatField;
            }
            set
            {
                this.fatField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("dup", Order = 1)]
        public TNFeInfNFeCobrDup[] dup
        {
            get
            {
                return this.dupField;
            }
            set
            {
                this.dupField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrFat
    {

        private string nFatField;

        private string vOrigField;

        private string vDescField;

        private string vLiqField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nFat
        {
            get
            {
                return this.nFatField;
            }
            set
            {
                this.nFatField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vOrig
        {
            get
            {
                return this.vOrigField;
            }
            set
            {
                this.vOrigField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vDesc
        {
            get
            {
                return this.vDescField;
            }
            set
            {
                this.vDescField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string vLiq
        {
            get
            {
                return this.vLiqField;
            }
            set
            {
                this.vLiqField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrDup
    {

        private string nDupField;

        private string dVencField;

        private string vDupField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nDup
        {
            get
            {
                return this.nDupField;
            }
            set
            {
                this.nDupField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string dVenc
        {
            get
            {
                return this.dVencField;
            }
            set
            {
                this.dVencField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string vDup
        {
            get
            {
                return this.vDupField;
            }
            set
            {
                this.vDupField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePag
    {

        private TNFeInfNFePagTPag tPagField;

        private string vPagField;

        private TNFeInfNFePagCard cardField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFePagTPag tPag
        {
            get
            {
                return this.tPagField;
            }
            set
            {
                this.tPagField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vPag
        {
            get
            {
                return this.vPagField;
            }
            set
            {
                this.vPagField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFePagCard card
        {
            get
            {
                return this.cardField;
            }
            set
            {
                this.cardField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagTPag
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePagCard
    {

        private TNFeInfNFePagCardTpIntegra tpIntegraField;

        private bool tpIntegraFieldSpecified;

        private string cNPJField;

        private TNFeInfNFePagCardTBand tBandField;

        private bool tBandFieldSpecified;

        private string cAutField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TNFeInfNFePagCardTpIntegra tpIntegra
        {
            get
            {
                return this.tpIntegraField;
            }
            set
            {
                this.tpIntegraField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tpIntegraSpecified
        {
            get
            {
                return this.tpIntegraFieldSpecified;
            }
            set
            {
                this.tpIntegraFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CNPJ
        {
            get
            {
                return this.cNPJField;
            }
            set
            {
                this.cNPJField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public TNFeInfNFePagCardTBand tBand
        {
            get
            {
                return this.tBandField;
            }
            set
            {
                this.tBandField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool tBandSpecified
        {
            get
            {
                return this.tBandFieldSpecified;
            }
            set
            {
                this.tBandFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string cAut
        {
            get
            {
                return this.cAutField;
            }
            set
            {
                this.cAutField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagCardTpIntegra
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagCardTBand
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdic
    {

        private string infAdFiscoField;

        private string infCplField;

        private TNFeInfNFeInfAdicObsCont[] obsContField;

        private TNFeInfNFeInfAdicObsFisco[] obsFiscoField;

        private TNFeInfNFeInfAdicProcRef[] procRefField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string infAdFisco
        {
            get
            {
                return this.infAdFiscoField;
            }
            set
            {
                this.infAdFiscoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string infCpl
        {
            get
            {
                return this.infCplField;
            }
            set
            {
                this.infCplField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("obsCont", Order = 2)]
        public TNFeInfNFeInfAdicObsCont[] obsCont
        {
            get
            {
                return this.obsContField;
            }
            set
            {
                this.obsContField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("obsFisco", Order = 3)]
        public TNFeInfNFeInfAdicObsFisco[] obsFisco
        {
            get
            {
                return this.obsFiscoField;
            }
            set
            {
                this.obsFiscoField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("procRef", Order = 4)]
        public TNFeInfNFeInfAdicProcRef[] procRef
        {
            get
            {
                return this.procRefField;
            }
            set
            {
                this.procRefField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsCont
    {

        private string xTextoField;

        private string xCampoField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsFisco
    {

        private string xTextoField;

        private string xCampoField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string xTexto
        {
            get
            {
                return this.xTextoField;
            }
            set
            {
                this.xTextoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return this.xCampoField;
            }
            set
            {
                this.xCampoField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicProcRef
    {

        private string nProcField;

        private TNFeInfNFeInfAdicProcRefIndProc indProcField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string nProc
        {
            get
            {
                return this.nProcField;
            }
            set
            {
                this.nProcField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public TNFeInfNFeInfAdicProcRefIndProc indProc
        {
            get
            {
                return this.indProcField;
            }
            set
            {
                this.indProcField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeInfAdicProcRefIndProc
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeExporta
    {

        private TUfEmi uFSaidaPaisField;

        private string xLocExportaField;

        private string xLocDespachoField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public TUfEmi UFSaidaPais
        {
            get
            {
                return this.uFSaidaPaisField;
            }
            set
            {
                this.uFSaidaPaisField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string xLocExporta
        {
            get
            {
                return this.xLocExportaField;
            }
            set
            {
                this.xLocExportaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xLocDespacho
        {
            get
            {
                return this.xLocDespachoField;
            }
            set
            {
                this.xLocDespachoField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCompra
    {

        private string xNEmpField;

        private string xPedField;

        private string xContField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string xNEmp
        {
            get
            {
                return this.xNEmpField;
            }
            set
            {
                this.xNEmpField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string xPed
        {
            get
            {
                return this.xPedField;
            }
            set
            {
                this.xPedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string xCont
        {
            get
            {
                return this.xContField;
            }
            set
            {
                this.xContField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCana
    {

        private string safraField;

        private string refField;

        private TNFeInfNFeCanaForDia[] forDiaField;

        private string qTotMesField;

        private string qTotAntField;

        private string qTotGerField;

        private TNFeInfNFeCanaDeduc[] deducField;

        private string vForField;

        private string vTotDedField;

        private string vLiqForField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string safra
        {
            get
            {
                return this.safraField;
            }
            set
            {
                this.safraField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("forDia", Order = 2)]
        public TNFeInfNFeCanaForDia[] forDia
        {
            get
            {
                return this.forDiaField;
            }
            set
            {
                this.forDiaField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string qTotMes
        {
            get
            {
                return this.qTotMesField;
            }
            set
            {
                this.qTotMesField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string qTotAnt
        {
            get
            {
                return this.qTotAntField;
            }
            set
            {
                this.qTotAntField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string qTotGer
        {
            get
            {
                return this.qTotGerField;
            }
            set
            {
                this.qTotGerField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("deduc", Order = 6)]
        public TNFeInfNFeCanaDeduc[] deduc
        {
            get
            {
                return this.deducField;
            }
            set
            {
                this.deducField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string vFor
        {
            get
            {
                return this.vForField;
            }
            set
            {
                this.vForField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string vTotDed
        {
            get
            {
                return this.vTotDedField;
            }
            set
            {
                this.vTotDedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string vLiqFor
        {
            get
            {
                return this.vLiqForField;
            }
            set
            {
                this.vLiqForField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaForDia
    {

        private string qtdeField;

        private string diaField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string qtde
        {
            get
            {
                return this.qtdeField;
            }
            set
            {
                this.qtdeField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dia
        {
            get
            {
                return this.diaField;
            }
            set
            {
                this.diaField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaDeduc
    {

        private string xDedField;

        private string vDedField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string xDed
        {
            get
            {
                return this.xDedField;
            }
            set
            {
                this.xDedField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string vDed
        {
            get
            {
                return this.vDedField;
            }
            set
            {
                this.vDedField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeSupl
    {

        private string qrCodeField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string qrCode
        {
            get
            {
                return this.qrCodeField;
            }
            set
            {
                this.qrCodeField = value;
            }
        }
    }
}