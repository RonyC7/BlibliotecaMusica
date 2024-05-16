using System;
using System.Collections.Generic;

public class Album
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public DateTime FechaPublicacion { get; set; }
    public List<Cancion> Canciones { get; set; }

    public Album()
    {
        Canciones = new List<Cancion>();
    }

    public Album(string titulo, string artista, DateTime fechaPublicacion)
    {
        Titulo = titulo;
        Artista = artista;
        FechaPublicacion = fechaPublicacion;
        Canciones = new List<Cancion>();
    }
}
