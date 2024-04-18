using ProjetoBandas.Modelos;

namespace Continuação_projeto_bandas.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.WriteLine("Sayonara ^w^");
    }
}
