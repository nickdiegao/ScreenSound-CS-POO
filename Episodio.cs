class Episodio
{
    private List<string> listaDeConvidados = new List<string>();   

    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }
    public string Titulo {  get; }   
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", listaDeConvidados)}";

    public void adicionarConvidados(string convidados)
    {
        listaDeConvidados.Add(convidados);
    }
}