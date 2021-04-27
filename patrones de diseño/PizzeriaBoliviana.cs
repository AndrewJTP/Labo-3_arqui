
namespace patrones_de_diseño
{
    public class PizzeriaArgentina : Pizzeria
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "hawai")
            {
                return new PizzaHawaiana("Argentina");
            }
            else if (tipo == "napo")
            {
                return new PizzaNapolitana("Argentina");
            }
            else
            {
                return null;
            }
        }
    }
}