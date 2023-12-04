namespace awanuer.Dto
{
    /// <summary>
    /// Clase que contendra todo lo relacionado con los elementos de la lista, tanto los constructores como los
    /// get y los set
    /// <author>041223 - awb</author>
    /// </summary>
    internal class ElementosDto
    {
        //Campos de la lista
        long idElemento = 0;

        string codigoElemento = "aaaaa";

        string nombreElemento = "aaaaa";

        string descripcioElemento = "aaaaa";

        int cantidadElemento = 0;

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcioElemento { get => descripcioElemento; set => descripcioElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        /// <summary>
        /// Constructor creado para cada elementod de la lista
        /// <author>041223 - awb</author>
        /// </summary>
        /// <param name="idElemento"></param>
        /// <param name="codigoElemento"></param>
        /// <param name="nombreElemento"></param>
        /// <param name="descripcioElemento"></param>
        /// <param name="cantidadElemento"></param>
        public ElementosDto(long idElemento, string codigoElemento, string nombreElemento, string descripcioElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcioElemento = descripcioElemento;
            this.cantidadElemento = cantidadElemento;
        }
        /// <summary>
        /// Constructor vacio de ELementosDto
        /// <author>041223 - awb</author>
        /// </summary>
        public ElementosDto()
        {

        }
        /// <summary>
        /// Metodo ToString para concatenar los elementos de la lista y mostrarlos posteriormente en pantalla
        /// <author>041223 - awb</author>
        /// </summary>
        /// <returns>String</returns>

        override
        public string ToString()
        {
            string elementosString = "idElemento: " + this.idElemento +
                " codigoElemento: " + this.codigoElemento + " nombreElemento: " + this.nombreElemento + " DescripcioElemento: "
                 + this.descripcioElemento + " cantidadElemento: " + this.cantidadElemento + "          ";

            return elementosString;
        }

    }
}
