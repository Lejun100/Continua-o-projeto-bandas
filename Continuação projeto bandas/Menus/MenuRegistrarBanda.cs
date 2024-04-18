using OpenAI_API;
using ProjetoBandas.Modelos;

namespace Continuação_projeto_bandas.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.WriteLine("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.WriteLine("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            Banda banda = bandasRegistradas[nomeDaBanda];
            banda.AdicionarAlbum(new Album(tituloAlbum));
            bandasRegistradas.Add(nomeDaBanda, banda);

            var client = new OpenAIAPI("");
            /// inserir api key para integrar o chatgpt com o C#
            var chat = client.Chat.CreateConversation();

            chat.AppendSystemMessage($"resuma a banda {nomeDaBanda} em 1 parágrafo.");

            string resposta = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            banda.Resumo = resposta;
            Console.WriteLine(resposta);



            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.WriteLine("Digite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            
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
