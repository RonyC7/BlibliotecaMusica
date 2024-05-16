public class Cancion
{
    public string Nombre { get; set; }
    public string Artista { get; set; }
    public TimeSpan Duracion { get; set; }
    public string Archivo { get; set; }

    public Cancion(string nombre, string artista, TimeSpan duracion, string archivo)
    {
        Nombre = nombre;
        Artista = artista;
        Duracion = duracion;
        Archivo = archivo;
    }

    public override string ToString()
    {
        return $"{Nombre} - {Artista} ({Duracion})";
    }
}
