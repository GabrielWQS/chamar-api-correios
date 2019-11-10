using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ChamarApiCorreios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste API Correios");

            Produto p1 = new Produto();
            p1.Id = 1;
            p1.Cep = "02248050";
            p1.Preco = 100;
            p1.Altura = 20;
            p1.Largura = 30;
            p1.Comprimento = 20;
            p1.Peso = 2;
            p1.Percentual = 10;
            p1.Vendedor = 666;

            Produto p2 = new Produto();
            p2.Id = 2;
            p2.Cep = "02248050";
            p2.Preco = 80;
            p2.Altura = 15;
            p2.Largura = 8;
            p2.Comprimento = 12;
            p1.Peso = 2.5;
            p2.Percentual = 8;
            p2.Vendedor = 666;

            Frete f1 = new Frete();
            f1.Id = 1;

            f1.Produtos = new List<Produto>();
            f1.Produtos.Add(p1);
            f1.Produtos.Add(p2);
            //f1.ValorFrete = 
            f1.ValorTotalProdutos = p1.Preco + p2.Preco;
            f1.CepOrigem = "02248050";
            f1.CepDestino = "69927000"; //alterar
            f1.PesoTotal = p1.Peso + p2.Peso;
            f1.AlturaTotal = p1.Altura;
            f1.LarguraTotal = p1.Largura;
            f1.ComprimentoTotal = p1.Comprimento;

            Carrinho c1 = new Carrinho();
            c1.Fretes = new List<Frete>();
            c1.Fretes.Add(f1);

        c1 = ChamarApiCorreios(c1);

        }

        private static Carrinho ChamarApiCorreios(Carrinho carrinho)
        {
            foreach (var item in carrinho.Fretes)
            {
                string uri = string.Format("http://ws.correios.com.br/calculador/CalcPrecoPrazo.aspx?nCdEmpresa={0}&" +
                                            "sDsSenha={1}&sCepOrigem={2}&sCepDestino={3}&nVlPeso={4}&nCdFormato={5}&" +
                                            "nVlComprimento={6}&nVlAltura={7}&nVlLargura={8}&sCdMaoPropria={9}&nVlValorDeclarado={10}&" +
                                            "sCdAvisoRecebimento={11}&nCdServico={12}&nVlDiametro={13}&StrRetorno=xml&nIndicaCalculo=3",
                "", "", item.CepOrigem,
                item.CepDestino, item.PesoTotal, "1",
                item.ComprimentoTotal, item.AlturaTotal, item.LarguraTotal,
                "n", item.ValorTotalProdutos, "n", "04014", "0"
                );

                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    Stream stream = response.GetResponseStream();
                    StreamReader readStream = new StreamReader(stream, Encoding.UTF8);

                    var xml = readStream.ReadToEnd();
                    Servicos retornoApiCorreio = ServicosXML.DeserializeXML<Servicos>(xml);
                    //carrinho.PrecoTotal = retornoApiCorreio.cServico.Valor;

                }
                else
                {
                    //Erro
                }

            }

            return carrinho;
        }
    }
}
