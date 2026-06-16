using ScreenSound.Models;
using ScreenSound.Menus;

Banda SystemOfADown = new("System of a Down");
SystemOfADown.AdicionarNota(new Avaliacao(10));
SystemOfADown.AdicionarNota(new Avaliacao(8));
SystemOfADown.AdicionarNota(new Avaliacao(9));

Banda LinkinPark = new("Linkin Park");
LinkinPark.AdicionarNota(new Avaliacao(10));
LinkinPark.AdicionarNota(new Avaliacao(9));
LinkinPark.AdicionarNota(new Avaliacao(8));

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(SystemOfADown.Nome, SystemOfADown);
bandasRegistradas.Add(LinkinPark.Nome, LinkinPark);

void ExibirOpcoesDoMenu()
{
    MenuExibirLogo logo = new();
    logo.Executar();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            MenuRegistrarBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 2:
            MenuRegistrarAlbum menu2 = new();
            menu2.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 3:
            MenuMostrarBandasRegistradas menu3 = new();
            menu3.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 4:
            MenuAvaliarBanda menu4 = new();
            menu4.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case 5:
            MenuExibirDetalhes menu5 = new();
            menu5.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case -1:
            MenuSair MenuSair = new();
            MenuSair.Executar();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirOpcoesDoMenu();