using System;
using System.Collections.Generic;
using System.Linq;

namespace BlibliotecaMusica.Servicios
{
    public class ServicioBiblioteca
    {
        private List<Album> _albumes;

        public ServicioBiblioteca()
        {
            _albumes = new List<Album>();
        }

        public List<Album> ObtenerAlbumes() => _albumes;

        public void IngresarAlbum(Album album)
        {
            _albumes.Add(album);
        }

        public void EditarAlbum(string titulo, Album albumEditado)
        {
            var album = _albumes.FirstOrDefault(a => a.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (album != null)
            {
                album.Titulo = albumEditado.Titulo;
                album.Artista = albumEditado.Artista;
                album.FechaPublicacion = albumEditado.FechaPublicacion;
                album.Canciones = albumEditado.Canciones;
            }
        }

        public List<Album> ObtenerAlbumesPorArtista(string artista)
        {
            return _albumes.Where(a => a.Artista.Equals(artista, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public string ObtenerMensajeDePrueba() => "El servicio de biblioteca está funcionando correctamente.";
    }
}
