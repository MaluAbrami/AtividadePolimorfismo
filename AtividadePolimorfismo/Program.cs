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

            //INICIALIZANDO PRODUTOS DE BASE QUE PODERÃO TER SEUS VALORES REAJUSTADOS
            Produto televisorBase = new Televisor(1, "Tv Samsung", 1099.90);
            Produto dvdBase = new DVD(2, "DVD LG", 399.90);
            Produto guitarraBase = new Guitarra(3, "Guitarra Gibson", 799.90);
            Produto videogameBase = new Videogame(4, "Playstation 5", 3399.90);
            Produto notebookBase = new Notebook(5, "Notebook Gamer Dell", 4589.90);

            //INICIALIZANDO OBJETOS PRODUTOS POR SEUS TIPOS(SUBCLASSES)
            Produto televisor = new Televisor(0, null, 0);
            Produto dvd = new DVD(0, null, 0);
            Produto guitarra = new Guitarra(0, null, 0);
            Produto videogame = new Videogame(0, null, 0);
            Produto notebook = new Notebook(0, null, 0);

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
                                    televisor = televisorBase;
                                    cestaDeCompras.AdicionarProdutoNaCesta(televisor);
                                    break;
                                }
                            case 2:
                                {
                                    notebook = notebookBase;
                                    cestaDeCompras.AdicionarProdutoNaCesta(notebook);
                                    break;
                                }
                            case 3:
                                {
                                    dvd = dvdBase;
                                    cestaDeCompras.AdicionarProdutoNaCesta(dvd);
                                    break;
                                }
                            case 4:
                                {
                                    guitarra = guitarraBase;
                                    cestaDeCompras.AdicionarProdutoNaCesta(guitarra);
                                    break;
                                }
                            case 5:
                                {
                                    videogame = videogameBase;
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
