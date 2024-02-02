class Podcast 
{
    private List<Episodio> episodios = new List<Episodio> ();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;    
    }

    public string Host { get; }
    public string Nome { get; } 
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio ep)
    {
        episodios.Add(ep);
    }

    public void ExibirDetalhes() 
    {
        Console.WriteLine($"Podcast: {Nome} apresentado por {Host}\n");
        foreach (Episodio ep in episodios.OrderBy(e => e.Ordem)) 
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.WriteLine($"Esse podcast possui {TotalEpisodios} episodios.");
    }
}