using ScreenSound1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound1.Menus
{
    internal class MenuExibirDetalhes : Menu
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibir media da banda: ");
            Console.Write("Digite o nome da manda que deseja ver a media: ");
            string nomeDaBanda = Console.ReadLine();

            if (bandasRegistradas.Keys.Contains(nomeDaBanda))
            {

                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.WriteLine($"\nA media da banda {nomeDaBanda} é {banda.Media}.");
                Console.Write("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
        
            }
            else
            {
                Console.WriteLine("Banda nao encontrada");
                Console.Write("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
           
            }
        }

     
    }
}
