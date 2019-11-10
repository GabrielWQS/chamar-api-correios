using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ChamarApiCorreios
{
    class ServicosXML
    {
        public static T DeserializeXML<T>(string xmlContent)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(xmlContent));
            return (T)serializer.Deserialize(memStream);
        }

    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Servicos
    {

        private ServicosCServico cServicoField;

        /// <remarks/>
        public ServicosCServico cServico
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ServicosCServico
    {

        private ushort codigoField;

        private string valorField;

        private byte prazoEntregaField;

        private string valorSemAdicionaisField;

        private string valorMaoPropriaField;

        private string valorAvisoRecebimentoField;

        private string valorValorDeclaradoField;

        private string entregaDomiciliarField;

        private string entregaSabadoField;

        private object obsFimField;

        private byte erroField;

        private object msgErroField;

        /// <remarks/>
        public ushort Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        /// <remarks/>
        public string Valor
        {
            get
            {
                return this.valorField;
            }
            set
            {
                this.valorField = value;
            }
        }

        /// <remarks/>
        public byte PrazoEntrega
        {
            get
            {
                return this.prazoEntregaField;
            }
            set
            {
                this.prazoEntregaField = value;
            }
        }

        /// <remarks/>
        public string ValorSemAdicionais
        {
            get
            {
                return this.valorSemAdicionaisField;
            }
            set
            {
                this.valorSemAdicionaisField = value;
            }
        }

        /// <remarks/>
        public string ValorMaoPropria
        {
            get
            {
                return this.valorMaoPropriaField;
            }
            set
            {
                this.valorMaoPropriaField = value;
            }
        }

        /// <remarks/>
        public string ValorAvisoRecebimento
        {
            get
            {
                return this.valorAvisoRecebimentoField;
            }
            set
            {
                this.valorAvisoRecebimentoField = value;
            }
        }

        /// <remarks/>
        public string ValorValorDeclarado
        {
            get
            {
                return this.valorValorDeclaradoField;
            }
            set
            {
                this.valorValorDeclaradoField = value;
            }
        }

        /// <remarks/>
        public string EntregaDomiciliar
        {
            get
            {
                return this.entregaDomiciliarField;
            }
            set
            {
                this.entregaDomiciliarField = value;
            }
        }

        /// <remarks/>
        public string EntregaSabado
        {
            get
            {
                return this.entregaSabadoField;
            }
            set
            {
                this.entregaSabadoField = value;
            }
        }

        /// <remarks/>
        public object obsFim
        {
            get
            {
                return this.obsFimField;
            }
            set
            {
                this.obsFimField = value;
            }
        }

        /// <remarks/>
        public byte Erro
        {
            get
            {
                return this.erroField;
            }
            set
            {
                this.erroField = value;
            }
        }

        /// <remarks/>
        public object MsgErro
        {
            get
            {
                return this.msgErroField;
            }
            set
            {
                this.msgErroField = value;
            }
        }
    }


}



