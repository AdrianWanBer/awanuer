namespace awanuer.Servicios
{
    /// <summary>
    /// Clase implementacion que contiene el metodo de menu 
    /// <author>041223 - awb</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuYSeleccion()
        {
            int seleccion;
            Console.WriteLine("Que quiere hacer");
            Console.WriteLine("1. Cerrar Aplicación");
            Console.WriteLine("2. Dar de alta un elemento");
            Console.WriteLine("3. Modificar un elemento");
            seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }
    }
}
