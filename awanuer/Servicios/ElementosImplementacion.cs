using awanuer.Dto;

namespace awanuer.Servicios
{
    /// <summary>
    /// Clase implementacion que se encarga de la operativa relacionada con los elementos de la lista (creacion y modificacion)
    /// <author>041223 - awb</author>
    /// </summary>
    internal class ElementosImplementacion : ElementosInterfaz
    {
        public void darDeAltaNuevoElemento(List<Dto.ElementosDto> listaAntigua)
        {
            ElementosDto elemento = crearElemento();
            listaAntigua.Add(elemento);

        }
        /// <summary>
        /// Metodo privado que se encargara de la creaccion del elemento para luego añadirlo a la lista
        /// </summary>
        /// <returns>ElementosDto</returns>
        private ElementosDto crearElemento()
        {
            ElementosDto nuevoElemento = new ElementosDto();
            Console.WriteLine("Escribe el id del elemento: ");
            nuevoElemento.IdElemento = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Escribe el nombre del elemento: ");
            nuevoElemento.NombreElemento = Console.ReadLine();

            Console.WriteLine("Escribe la descripcion del elemento: ");
            nuevoElemento.DescripcioElemento = Console.ReadLine();

            Console.WriteLine("Escribe la cantidad del elemento: ");
            nuevoElemento.CantidadElemento = Convert.ToInt32(Console.ReadLine());

            nuevoElemento.CodigoElemento = nuevoElemento.IdElemento + nuevoElemento.NombreElemento;

            return nuevoElemento;
        }


        /// <summary>
        /// Metodo que se encarga de pedir el codigoElemento para poder identificar el elemento en la lista
        /// <author>041223 - awb</author>
        /// </summary>
        /// <returns>string</returns>
        private string busquedaDeCodigo()
        {
            Console.WriteLine("Cual es el codigo de tu elemento: ");
            string codigoBuscar = Console.ReadLine();

            return codigoBuscar;
        }
        public void borrarElemento(List<Dto.ElementosDto> listaAntigua)
        {
            for (int contador = 0; contador <= listaAntigua.Count; contador++)
            {
                string codigoABuscar = busquedaDeCodigo();
                foreach (ElementosDto elementos in listaAntigua)
                {
                    if (elementos.CodigoElemento.Equals(codigoABuscar))
                    {
                        Console.WriteLine("Cuantos quieres eliminar: ");
                        int aRestar = Convert.ToInt32(Console.ReadLine());
                        int despuesDeLaResta = elementos.CantidadElemento - aRestar;
                        elementos.CantidadElemento = despuesDeLaResta;
                        contador ++;
                    }
                }
            }
        }

    }
}
