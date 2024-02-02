using ScreenSound1.Menus;
using ScreenSound1.Modelos;



Banda ira = new Banda("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda beatles = new Banda("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ira.Nome, ira);
bandasRegistradas.Add(beatles.Nome, beatles);




void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝

░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("BOAS VINDAS AO SCREEN SOUND!");
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda: ");
    Console.WriteLine("Digite 2 para registrar o album de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas: ");
    Console.WriteLine("Digite 4 para avaliar uma banda: ");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda: ");
    Console.WriteLine("Digite 0 para sair: ");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida)!;

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda(); break;
        case 2: RegistrarAlbum(); break;
        case 3: MostrarBandasRegistradas(); ; break;
        case 4: MenuAvaliarBanda menu4 = new();
            menu4.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();    
                break;
        case 5: MenuExibirDetalhes menu5 = new MenuExibirDetalhes();
            menu5.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();

            break;
        case 0: Console.WriteLine("Saindo..."); break;

        default: Console.WriteLine("Opção inválida"); break;
    }
}

void RegistrarAlbum()
{
    Console.Clear();
    
    Console.Write("Digite a banda cujo album deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)) {
        Console.Write("Digite o titulo do album: ");
        string tituloDoAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarAlbum(new Album(tituloDoAlbum));

        Console.WriteLine($"O album {tituloDoAlbum} foi registrado com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
    }

    else
    {
        Console.WriteLine("Banda nao encontrada");
        Console.Write("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
       
    }

    ExibirLogo();
    ExibirOpcoesDoMenu();


}


void RegistrarBanda()
{
    Console.Clear();


    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
   
    //for (int i = 0; i < listaDeBandas.Count; i++)
    //{
    //  Console.WriteLine($"Banda: {listaDeBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.Write("\nDigite alguma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}







ExibirLogo();
ExibirOpcoesDoMenu();