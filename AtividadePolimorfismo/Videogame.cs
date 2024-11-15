using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    internal class Videogame : Produto
    {
        public Videogame(int id, string name, double price) : base(id, name, price)
        {
        }

        public override void reajustarPreco()
        {
            throw new NotImplementedException();
        }
    }
}
