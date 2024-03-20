﻿class Musica 
{

    public Musica(Banda artista, string nome)
    {
        Artista = artista;  
        Nome = nome;    
    }

    public string Nome { get; set; }
    public Banda Artista { get; } 
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence ao artista {Artista}\n"; //lambda

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Artista da música: {Artista.Nome}");
        Console.WriteLine($"Duração da músca: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Díspónível no plano\n");
        } else
        {
            Console.WriteLine("Adquira o plano plus+\n");
        }
    }

}