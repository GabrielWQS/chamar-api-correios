using System;
using System.Collections.Generic;
using System.Text;

namespace ChamarApiCorreios
{
    class Frete
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public double ValorFrete { get; set; }
        public double ValorTotalProdutos { get; set; }
        public string CepOrigem { get; set; }
        public string CepDestino { get; set; }
        public double PesoTotal { get; set; }
        public double AlturaTotal { get; set; }
        public double LarguraTotal { get; set; }
        public double ComprimentoTotal { get; set; }
    }
}
