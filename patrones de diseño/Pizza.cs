using System;

namespace patrones_de_diseño
{
    public abstract class Pizza
    {
        protected string _descripcion;
        protected string _origen;

        public void Imprimir()
        {
            Console.WriteLine(string.Format("Pizza de {0} hecha en {1}", _descripcion, _origen));
        }
    }
}