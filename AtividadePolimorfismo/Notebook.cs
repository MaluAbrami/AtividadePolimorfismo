using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    internal class Notebook : Produto
    {
        public Notebook(int id, string name, double price, string tipo) : base(id, name, price, tipo)
        {
        }

        public override void reajustarPreco()
        {
            this.Price *= 0.02;
        }
    }
}
