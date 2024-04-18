using ProjetoBandas.Modelos;

namespace Continuação_projeto_bandas.Menus;

internal class MenuBandaRegistrada : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }


        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        
    }
}
