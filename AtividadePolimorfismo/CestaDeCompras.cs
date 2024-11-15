using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    internal class CestaDeCompras
    {
        private List<Produto> produtos;

        public List<Produto> Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }

        public CestaDeCompras()
        {
            Produtos = new List<Produto>();
        }

        public void AdicionarProdutoNaCesta(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void ExibirProdutosDaCesta()
        {
            Console.WriteLine("---------Cesta de compras---------");

            foreach (Produto produto in Produtos)
            {
                Console.WriteLine($"Produto: {produto.Name}\nTipo do Produto: {produto.Tipo}\nValor: {produto.Price}\n");
            }
        }

        public double CalcularValorTotal()
        {
            double valorTotal = 0;

            foreach (Produto produto in Produtos)
            {
                valorTotal += produto.Price;
            }

            return valorTotal;
        }
    }
}
