using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasPorTom(musicas, 1);
        /*musicas.ForEach(item => item.ExibirDetalhesDaMusica());
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        LinqFilter.FiltrarMusicaPorAno(musicas, 2014);

        var musicaspreferidasdodaniel = new musicaspreferidas("daniel");

        musicaspreferidasdodaniel.adicionarmusicasfavoritas(musicas[1]);
        musicaspreferidasdodaniel.adicionarmusicasfavoritas(musicas[377]);
        musicaspreferidasdodaniel.adicionarmusicasfavoritas(musicas[4]);
        musicaspreferidasdodaniel.adicionarmusicasfavoritas(musicas[6]);
        musicaspreferidasdodaniel.adicionarmusicasfavoritas(musicas[1467]);
        musicaspreferidasdodaniel.exibirmusicasfavoritas();

        var musicasPreferidasDaEmilly = new MusicasPreferidas("Emy");
        musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[500]);
        musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[637]);
        musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[428]);
        musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidasDaEmilly.AdicionarMusicasFavoritas(musicas[71]);
        musicasPreferidasDaEmilly.ExibirMusicasFavoritas();

       musicasPreferidasDaEmilly.GerarDocumentoTXTComAsMusicasFavoritas();
         */
    }


    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}

