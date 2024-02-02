using ScreenSound1.Modelos;

namespace ScreenSound1.Menus
{
    internal class MenuAvaliarBanda : Menu
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Avaliar Banda: ");
            Console.Write("Digite o nomee da banda que deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine();
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write($"Qual nota a banda {nomeDaBanda} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                banda.AdicionarNota(nota);
                Console.WriteLine($"A nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} nao foi encontrada\n");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal: ");
                Console.ReadKey();
                Console.Clear();

            }
        }

    }
}   
    

    
