using Continuação_projeto_bandas.Menus;
using Continuação_projeto_bandas.Modelos;
using ProjetoBandas.Modelos;

Banda ateez = new Banda("Ateez");
ateez.AdicionarNota(new Continuação_projeto_bandas.Modelos.Avaliacao(10));
ateez.AdicionarNota(new Continuação_projeto_bandas.Modelos.Avaliacao(8));
ateez.AdicionarNota(new Continuação_projeto_bandas.Modelos.Avaliacao(6));
Banda kard = new Banda("Kard");


//Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen sound";
string digiteOpcao = "\nPor favor, digite uma das opções abaixo para prosseguirmos: ";
//List<string> listaDasBandas = new List<string> { "U2", "Blink182", "MGK" };

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(ateez.Nome, ateez);
bandasRegistradas.Add(kard.Nome, kard);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuBandaRegistrada());
opcoes.Add(3, new MenuAvaliarBanda());
opcoes.Add(4, new MenuExibirDetalhes());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(-1, new MenuSair());


void ExibirLogo()
{
    Console.WriteLine(@"
     Screen Sound!!!
");

    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine(digiteOpcao);
} 

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opçaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opçaoEscolhidaNumerica))
    {
        Menu menuASerExibida = opcoes[opçaoEscolhidaNumerica];
        menuASerExibida.Executar(bandasRegistradas);
        if (opçaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida.");
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();







Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");


Episodio ep2 = new(1, "Técnicas de aprendizagem", 67);
ep2.AdicionarConvidados("Marcio");
ep2.AdicionarConvidados("Odegard");

Podcast podcast = new("Podcast Especial", "Jun");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

Banda bigbang = new Banda("Big Bang");

Album albumDoBigBang = new Album("Made");

Musica musica1 = new Musica(bigbang, "Sober")
{
    Duracao = 317,
    Disponivel = true,
};


Musica musica2 = new Musica(bigbang, "Let's not fall in love")
{
    Duracao = 359,
    Disponivel = false,
};

albumDoBigBang.AdicionarMusica(musica1);
albumDoBigBang.AdicionarMusica(musica2);
bigbang.AdicionarAlbum(albumDoBigBang);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoBigBang.ExibirMusicasDoAlbum();
bigbang.ExibirDiscografia();

//Musica musica1 = new Musica();
//musica1.Nome = "Darkside";
//musica1.Duracao = 245;
//musica1.Disponivel = (true);
//Console.WriteLine(musica1.DescricaoResumida);

    //se atribuir musica1 não da certo aparecendo apenas Musica, assim especificando com ".nome".
    //Console.WriteLine($"Banda:  {musica1.artista}");

//Musica musica2 = new Musica();
//musica2.Nome = "Aurora";
//musica2.Artista = "Ateez";
//musica2.Disponivel = (false);
//Console.WriteLine(musica2.DescricaoResumida);

// Para um app de músicas, fica difícil escrever cada linha de código, para isso 
// queremos exibir a ficha técnica das músicas

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();