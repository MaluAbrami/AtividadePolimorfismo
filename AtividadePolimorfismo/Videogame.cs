using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    internal class Videogame : Produto
    {
        public Videogame(int id, string name, double price, string tipo) : base(id, name, price, tipo)
        {
        }

        public override void reajustarPreco()
        {
            this.Price *= 0.015;
        }
    }
}
