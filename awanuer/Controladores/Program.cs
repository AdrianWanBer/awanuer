using awanuer.Dto;
using awanuer.Servicios;

namespace awanuer.Controladores
{
    /// <summary>
    /// Clase program que se encarga del flujo de la aplicación
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main es el principal de la aplicación
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Creacion de objetos y declaracion de variables
            MenuInterfaz mi = new MenuImplementacion();
            List<ElementosDto> listaElementos = new List<ElementosDto>();
            ElementosInterfaz ei = new ElementosImplementacion();


            bool cerrarMenu = false; //Cerrado de la aplicación

            //Switch que controlara las opciones que seleccione el usuario
            while (!cerrarMenu)
            {
                int seleccion = mi.menuYSeleccion();
                switch (seleccion)
                {
                    case 1: //Cerrar menu
                        cerrarMenu = true;
                        break;
                    case 2: //Modificar un elemento (se debe mostrar lo añadido)
                        ei.darDeAltaNuevoElemento(listaElementos);
                        foreach (ElementosDto elemento in listaElementos)
                        {
                            Console.WriteLine(elemento);
                        }
                        break;
                    case 3: //Modificar un elemento
                        ei.borrarElemento(listaElementos);

                        foreach (ElementosDto elemento in listaElementos)
                        {
                            Console.WriteLine(elemento);
                        }
                        break;
                    default: //Case default por si la seleccion del usuario no es valida
                        Console.WriteLine("No ha seleccionado una opcion valida");
                        break;
                }
            }
        }

    }
}
