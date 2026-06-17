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

Dictionary<int, Menu> opcoesDoMenu = new();
opcoesDoMenu.Add(1, new MenuRegistrarBanda());
opcoesDoMenu.Add(2, new MenuRegistrarAlbum());
opcoesDoMenu.Add(3, new MenuMostrarBandasRegistradas());
opcoesDoMenu.Add(4, new MenuAvaliarBanda());
opcoesDoMenu.Add(5, new MenuExibirDetalhes());
opcoesDoMenu.Add(-1, new MenuSair());

void ExibirOpcoesDoMenu()
{
    MenuExibirLogo logo = new();
    logo.Executar(bandasRegistradas);
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoesDoMenu.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoesDoMenu[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0)
        {
            ExibirOpcoesDoMenu();
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}
ExibirOpcoesDoMenu();