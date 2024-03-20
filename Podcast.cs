class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        this.Host = host;
        this.Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodios(Episodio eps)
    {
        episodios.Add(eps);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Exibindo detalhes do podcast {Nome} apresentado por {Host}");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} de episódios");
    }
}