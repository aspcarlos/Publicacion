namespace Publicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLASE PUBLICACION

            // Creamos un objeto tipo Publicacion, y le ponemos de nombre post1, la cual será igual a una nueva (new) Publicación,
            // y como es un constructor, vamos a poner los parametros del constructor parametrizado de la clase (class) Publicación,
            // que son 2 cadenas de texto (string), y una condicion booleana (bool) verdadera o falsa (true or false).
            Publicacion post1 = new Publicacion("Gracias a todos", "Leroy", true);

            // Indicamos que se escriba en la consola, el objeto post1, con el formato del metodo ToString().
            Console.WriteLine(post1.ToString());

            // CLASE PUBLICARIMAGEN

            // Creamos un objeto de tipo PublicacionImagen, y le ponemos de nombre1, la cual sera igual a una nueva (new) PublicacionImagen, y como es un constructor,
            // vamos a poner los parametros, del constructor de la clase PublicarImagen, que son 2 cadena de texto (string),
            // una condicion booleana (bool) true or false y por ultimo otra cadena de texto (string), que indicara la ruta donde se esta alojada la fotografia del autor.
            PublicarImagen imagen1 = new PublicarImagen("https://www.bbva.com/wp-content/uploads/2019/01/4-Portada-Va-caciones_opt.jpg", "Vaciones en Costa Rica", "Luis", true);

            // Indicamos que se escriba en la consola, el objeto imagen1, con el formato del metodo ToString(), perteneciente en este caso a la clase  PublicarImagen
            Console.WriteLine(imagen1.ToString());

            // Mantenemos la consola abierta
            Console.ReadLine();

        }
    }
}