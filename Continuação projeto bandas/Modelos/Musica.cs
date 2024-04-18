namespace ProjetoBandas.Modelos;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome {  get;  }    // usando o ctrl + R podemos renomear um item no C# para todos os codigos  
    public Banda Artista { get;  }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }      // usando o get e set nao existe a necessidade do void escreve e le disponivel

    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";   




    // public void EscreveDisponivel(bool value)
    // {
    //   disponivel = value;
    //  }
    // public bool LeDisponivel()
    // {
    //    return disponivel;  
    // }






    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

}
