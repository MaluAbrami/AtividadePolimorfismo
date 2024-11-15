using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    internal class Televisor : Produto
    {
        public Televisor(int id, string name, double price) : base(id, name, price)
        {
        }

        public override void reajustarPreco()
        {
            this.Price += this.Price * 0.01;
        }
    }
}
