//List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
//numerosPares.ForEach(numero => Console.WriteLine(numero));

Album albumDaBillie = new Album("Happier Than Ever");

Banda billie = new Banda("Billie Eilish");

Musica musica1 = new Musica(billie, "Happier Than Ever")
{
    Duracao = 420,
    Disponivel = true,
};

Musica musica2 = new Musica(billie, "NDA")
{
    Duracao = 340,
    Disponivel = false,
};
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumDaBillie.AdicionarMusica(musica1);
albumDaBillie.AdicionarMusica(musica2);

albumDaBillie.ExibirMusicaDoAlbum();

billie.AdicionarAlbum(albumDaBillie);
billie.ExibirDiscografia();

Episodio ep1 = new("Feliz Natal", 45, 1);
ep1.adicionarConvidados("Fallen");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new("Ratinhoo", 120, 2);
ep2.adicionarConvidados("Xarola");

Episodio ep3 = new("Salamaleico", 100, 3);
ep3.adicionarConvidados("José Rufino");

Podcast podcast = new Podcast("Nicholas Diego", "Valorant");
podcast.AdicionarEpisodios(ep1);
podcast.AdicionarEpisodios(ep2);
podcast.AdicionarEpisodios(ep3);

podcast.ExibirDetalhes();
