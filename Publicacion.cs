using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicacion
{
    // Cambiamos el modificador de acceso de nuestra clase de internal a public, para que la clase base se puede relacionar con las clases herederas
    internal class Publicacion
    {
        // Miembros Privados

        // Crearemos nustra primera variable de carcater privado (private)
        private static int publicacionID;

        // Propiedades

        // Creamos la propiedad de caracter protegido (protected), de tipo entero (int), con el nombre ID
        protected int ID
        {
            get; set;
        }

        // Creamos la propiedad de caracter protegido (protected), de tipo texto (string), con el nombre Titulo
        protected string Titulo
        {
            get; set;
        }

        // Creamos la propiedad de caracter protegido (protected), de tipo texto (string)
        protected string Autor
        {
            get; set;
        }

        // Creamos la propiedad de caracter protegido (protected), de tipo booleano (bool), con el nombre EsPublico
        protected bool EsPublico
        {
            get; set;
        }

        // Constructores

        // Creamos un constructor por defecto (sin parametros) para asignarle valores por defecto a las propiedades (en caso de que en el program no se introduzca ningun parametro)
        public Publicacion()
        {
            ID = 0;
            Titulo = "Mi primera publicación";
            Autor = "Juanito el de los Palotes";
            EsPublico = true;
        }

        // Creamos un constructor parametrizado, de caracter publico (public), con 3 parametros:
        // -> Una cadena de texto (string), llamada titulo.
        // -> Una cadena de texto (string), llamada autor.
        // -> Una condicion booleana (bool), llamada esPublico.

        // Cada vez, que se genere una publicacion, se va generar con los datos que le proporcionemos a las propiedades.
        public Publicacion(string titulo, string autor, bool esPublico)
        {
            ID = CrearID();
            Titulo = titulo;
            Autor = autor;
            EsPublico = esPublico;
        }

        // Ahora, crearemos el metodo que nos permitira asignarle una ID, es decir, el número que le corresponda a cada publicación.
        // Metodo para crear ID
        protected int CrearID()
        {
            // El metodo nos regresara (return), la suma de 1 número entero (int), sumado (++) al actual valor que tenga la variable 
            return ++publicacionID;
        }

        // Ahora, crearemos un metodo, que transforme a toda la clase, es decir, a todo el objeto que creamos en una cadena de texto (string), para que podamos mostrarla en la consola.
        // ToString: Convierte un objeto en su representación de cadena para que sea adecuado para su visualización.
        // Lo que hace este metodo es darle formato al objeto, en un formato de tipo texto (string), lo que vamos a hacer con este método, es reescribirlo (override) para poder utilizarlo como
        // queramos, de manera, que nos permita publicar el contenido del objeto Publicacion
        public override string ToString()
        {
            // String.Format: Se utiliza insertar el valor de un objeto, variable o expresión en otra cadena.
            // Nos regresara (return) el formato (Format) de la clase String (con mayusculas), porque estamos invocando a la clase y no al tipo de dato (string)
            // y entre parentesis escribimos nuestro formato como una cadena de texto
            return String.Format($"{ID} - {Titulo} - Creado por {Autor}");
        }

    }
}
