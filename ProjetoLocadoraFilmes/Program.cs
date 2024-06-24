using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFilmes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione A para alugar um filme ou S para sair da locadora");
            char opcao = Console.ReadKey(true).KeyChar;
            if(opcao == 'A' || opcao == 'a')
            {
                //Alugar um filme
                Console.WriteLine("Pressione 1 para alugar top gun");
                Console.WriteLine("Pressione 2 para alugar a bela e a fera");
                Console.WriteLine("Pressione 3 para alugar o homem-aranha");
                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                switch (opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Você alugou to gun");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou A bela e a fera");
                        break;
                    case 3:
                        Console.WriteLine("Você alugou homem-aranha");
                        break;
                    default:
                        Console.WriteLine("OPção desconhecida");
                        break;
                }
            }else if(opcao == 'S' || opcao == 's')
            {
                //Sair da locadora
                Console.WriteLine("Muito obrigado. Volte sempre!");
            }
            else
            {
                //Opção desconhecida
                Console.WriteLine("Opção Desconhecida... ");
            }
            Console.WriteLine("Pressione qualquer tecla para encerrar");
            Console.ReadKey(true);
        }
    }
}
