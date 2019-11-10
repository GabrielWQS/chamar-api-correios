using System;
using System.Collections.Generic;
using System.Text;

namespace ChamarApiCorreios
{
    class Carrinho
    {
        public int Id { get; set; }
        public List<Frete> Fretes { get; set; }
        public double PrecoTotal { get; set; }
    }
}
