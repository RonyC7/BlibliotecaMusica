public class Album
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public List<Cancion> Canciones { get; set; }
    public DateTime FechaPublicacion { get; set; }

    public Album(string titulo, string artista, DateTime fechaPublicacion)
    {
        Titulo = titulo;
        Artista = artista;
        FechaPublicacion = fechaPublicacion;
        Canciones = new List<Cancion>();
    }

    public void AgregarCancion(Cancion cancion)
    {
        Canciones.Add(cancion);
    }

    public override string ToString()
    {
        return $"{Titulo} - {Artista} ({FechaPublicacion.ToShortDateString()})";
    }
}
