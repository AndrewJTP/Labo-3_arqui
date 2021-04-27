using System;

namespace patrones_de_diseño
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizzeria pizzeria;
            Pizza pizza;

            pizzeria = new PizzeriaArgentina();

            pizza = pizzeria.CrearPizza("napo");
            pizza.Imprimir();
            pizza = pizzeria.CrearPizza("hawai");
            pizza.Imprimir();

            pizzeria = new PizzeriaItaliana();
            pizza = pizzeria.CrearPizza("napo");
            pizza.Imprimir();
            pizza = pizzeria.CrearPizza("hawai");
            pizza.Imprimir();
            Console.ReadKey();
        }
    }
}


