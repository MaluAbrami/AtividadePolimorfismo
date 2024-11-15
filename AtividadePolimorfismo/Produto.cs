using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    internal abstract class Produto
    {
        private int id;
        private string name;
        private double price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Produto(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public abstract void reajustarPreco();
    }
}
