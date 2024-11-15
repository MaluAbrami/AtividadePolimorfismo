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
        private string tipo;

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

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Produto(int id, string name, double price, string tipo)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Tipo = tipo;
        }

        public abstract void reajustarPreco();
    }
}
