using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CestaDeCompras cestaDeCompras = new CestaDeCompras();

            Produto televisor = new Televisor(1, "Tv Samsung", 1099.90);
            Produto dvd = new DVD(2, "DVD LG", 399.90);
            Produto guitarra = new Guitarra(3, "Guitarra Gibson", 799.90);
            Produto videogame = new Videogame(4, "Playstation 5", 3399.90);
            Produto notebook = new Notebook(5, "Notebook Gamer Dell", 4589.90);

            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("1 - Incluir um dos produtos na cesta\n2 - Reajustar o preço de todos os produtos\n3 - Exibir cesta de produtos\n4 - Exibir total da compra");
            Console.WriteLine("Selecione uma opção: ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }
}
