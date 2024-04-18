using ProjetoBandas.Modelos;

namespace Continuação_projeto_bandas.Menus;

internal class MenuExibirDetalhes : Menu
{
   
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir média da banda");
        Console.WriteLine("Digite o nome da banda para exibir a nota média da banda");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            foreach(Album album in banda.Albums)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
