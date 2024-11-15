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

            // Inicializando produtos base
            List<Produto> produtosBase = new List<Produto>
            {
                new Televisor(1, "Tv Samsung", 1099.90, "televisor"),
                new Notebook(2, "Notebook Gamer Dell", 4589.90, "notebook"),
                new DVD(3, "DVD LG", 399.90, "dvd"),
                new Guitarra(4, "Guitarra Gibson", 799.90, "guitarra"),
                new Videogame(5, "Playstation 5", 3399.90, "videogame")
            };

            Produto televisor = new Televisor(0, null, 0, "televisor");
            Produto dvd = new DVD(0, null, 0, "dvd");
            Produto guitarra = new Guitarra(0, null, 0, "guitarra");
            Produto videogame = new Videogame(0, null, 0, "videogame");
            Produto notebook = new Notebook(0, null, 0, "notebook");

            string res = "N";

            while (res != "S")
            {
                Console.WriteLine("-------------Menu-------------");
                Console.WriteLine("1 - Incluir um dos produtos na cesta\n2 - Reajustar o preço de todos os produtos\n3 - Exibir cesta de produtos\n4 - Exibir total da compra");
                Console.WriteLine("Selecione uma opção: ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Selecione o tipo do Produto que deseja incluir na cesta:\n1-Televisor\n2-Notebook\n3-DVD\n4-Guitarra\n5-Videogame\n");
                            int tipoProduto = Convert.ToInt32(Console.ReadLine());

                            switch (tipoProduto)
                            {
                                case 1:
                                    {
                                        televisor.Id = televisorBase.Id;
                                        televisor.Name = televisorBase.Name;
                                        televisor.Price = televisorBase.Price;

                                        cestaDeCompras.AdicionarProdutoNaCesta(televisor);
                                        break;
                                    }
                                case 2:
                                    {
                                        notebook.Id = notebookBase.Id;
                                        notebook.Name = notebookBase.Name;
                                        notebook.Price = notebookBase.Price;

                                        cestaDeCompras.AdicionarProdutoNaCesta(notebook);
                                        break;
                                    }
                                case 3:
                                    {
                                        dvd.Id = dvdBase.Id;
                                        dvd.Name = dvdBase.Name;
                                        dvd.Price = dvdBase.Price;

                                        cestaDeCompras.AdicionarProdutoNaCesta(dvd);
                                        break;
                                    }
                                case 4:
                                    {
                                        guitarra.Id = guitarraBase.Id;
                                        guitarra.Name = guitarraBase.Name;  
                                        guitarra.Price = guitarraBase.Price;

                                        cestaDeCompras.AdicionarProdutoNaCesta(guitarra);
                                        break;
                                    }
                                case 5:
                                    {
                                        videogame.Id = videogameBase.Id;
                                        videogame.Name = videogameBase.Name;
                                        videogame.Price = videogameBase.Price;

                                        cestaDeCompras.AdicionarProdutoNaCesta(videogame);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Tipo de produto não existe");
                                        Console.ReadLine();
                                        break;
                                    }
                            }

                            break;
                        }
                    case 2:
                        {
                            foreach (Produto produto in produtosBase)
                            {
                                produto.reajustarPreco();
                            }
                            Console.WriteLine("Preço de todos os Produtos reajustado com sucesso!");
                            break;
                        }
                    case 3:
                        {
                            cestaDeCompras.ExibirProdutosDaCesta();
                            break;
                        }
                    case 4:
                        {
                            double valorTotal = cestaDeCompras.CalcularValorTotal();
                            Console.WriteLine($"O valor total da sua cesta de compras é de R${valorTotal}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opção inválida!");
                            Console.ReadLine();
                            break;
                        }
                }

                Console.WriteLine("Encerrar programa?(S/N)\n");
                res = Console.ReadLine().ToUpper();
            }
        }
    }
}
