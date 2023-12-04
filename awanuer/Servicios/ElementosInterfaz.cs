namespace awanuer.Servicios
{
    /// <summary>
    /// Clase interfaz que contendra todos los metodos de ElementosImplementacion y se encargara de lo relacionado con la creacion
    /// de elementos y todo su manejo
    /// <author>041223 - awb</author>
    /// </summary>
    internal interface ElementosInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de dar de alta un nuevo objeto para ingresarlo luego a la lista
        /// <author>041223 - awb</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darDeAltaNuevoElemento(List<Dto.ElementosDto> listaAntigua);


        /// <summary>
        /// Metodo que se encarga de restar los elementos a la lista
        /// <author>041223 - awb</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void borrarElemento(List<Dto.ElementosDto> listaAntigua);
    }
}
