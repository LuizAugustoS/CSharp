using ScreenSound_04.Modelos;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
    public static void FiltrarMusicaPorAno(List<Musica> musicas, int anoLancamento)
    {
        var anoDeLancamento = musicas.Where(musica => musica.Ano.Equals(anoLancamento)).ToList();
        Console.WriteLine(anoLancamento);
        foreach (var musica in anoDeLancamento)
        {
            Console.WriteLine($"- {musica.Ano} - {musica.Artista}");
        }
    }
    public static void FiltrarMusicasPorTom(List<Musica> musicas, int tomDaMusica)
    {
        var tomMusica = musicas.Where(musica => musica.Key!.Equals(tomDaMusica)).ToList();
        foreach (var musica in tomMusica)
        {
            Console.WriteLine($"- {musica.Nome} - {musica.Artista}, Tom:{musica.Tonalidade}");
        }

    }
}
