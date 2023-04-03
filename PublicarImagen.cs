using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicacion
{
    internal class PublicarImagen : Publicacion
    {
        // Creamos para esta publicacion una propiedad nueva
        public string UrlImagen
        {
            get; set;
        }

        // Creamos un constructor parametrizado, con los siguientes parametros, una cadena de texto (string) titulo, otra llamada autor,
        // una condicion booleana (bool) llamada esPublico, y agregaremos el nuevo parametro que tendra esta publicacion,
        // la cadena de texto (string) llamada url.
        public PublicarImagen(string url, string titulo, string autor, bool esPublico)
        {
            ID = CrearID();
            Titulo = titulo;
            Autor = autor;
            EsPublico = esPublico;
            // Nueva propiedad creada en esta clase PublicarImagen, de nombre UrlImagen, que será igual a la cadena de texto urlImagen,
            // que esta como parametro en el constructor.
            UrlImagen = url;
        }

        // Invocamos el Metodo ToString, lo hacemos de caracter publico (public), y sobreescrimos (override) la cadena de texto (string).
        public override string ToString()
        {
            // Nos regresara (return) el formato (Format) de la clase String (con mayusculas), porque estamos invocando a la clase y no al tipo de dato (string)
            // y entre parentesis escribimos nuestro formato como una cadena de texto.
            return String.Format($"{ID} - {Titulo} - Creado por {Autor} - {UrlImagen}");
        }

        // Ahora, cada vez que hagamos un llamado al metodo ToSting(), estamos haciendo una representación publicable de nuestro objeto PublicacionImagen.
    }
}
