using System;
using System.Collections.Generic;
using System.Text;

namespace ChamarApiCorreios
{
    class Produto
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public double Preco { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        public double Percentual { get; set; }
        public int Vendedor { get; set; }
        public double Peso { get; internal set; }
    }
}
