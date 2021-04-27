
namespace patrones_de_diseño
{
    public class PizzeriaItaliana : Pizzeria
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "hawai")
            {
                return new PizzaHawaiana("Italia");
            }
            else if (tipo == "napo")
            {
                return new PizzaNapolitana("Italia");
            }
            else
            {
                return null;
            }
        }
    }
}