

class Podcast
{
    private List<Episodio> episodios = new();
    
    public Podcast(string nome, string topico) 
    {
        Name = nome;
        Host = topico;
    }

    public string Host { get; }
    public string Name { get; }

    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
       episodios.Add(episodio);
        
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Name} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);

        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} de episódios.");
    }
}