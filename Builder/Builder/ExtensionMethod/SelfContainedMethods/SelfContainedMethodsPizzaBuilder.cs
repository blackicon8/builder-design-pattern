using builder.Common.Enums;
using builder.Common.Models;
using builder.Common.Services;

namespace builder.Builder.ExtensionMethod.InternalMethods
{
    public static class SelfContainedMethodsPizzaBuilder
    {
        public static Pizza CreatePizza(Size size, Dough dough)
        {
            var pizza = new Pizza();

            pizza.Size = size;
            pizza.Dough = dough;

            ContextConsole.WriteTopping(pizza.Size);
            ContextConsole.WriteTopping(pizza.Dough);

            return pizza;
        }

        public static Pizza AddSauce(this Pizza pizza, Sauce sauce)
        {
            pizza.Sauce = sauce;
            ContextConsole.WriteTopping(pizza.Sauce);
            return pizza;
        }

        public static Pizza AddHam(this Pizza pizza, Ham[] ham)
        {
            pizza.Ham = ham;
            ContextConsole.WriteTopping(pizza.Ham);
            return pizza;
        }

        public static Pizza AddMushroom(this Pizza pizza)
        {
            pizza.Mushroom = true;
            ContextConsole.WriteTopping(nameof(pizza.Mushroom), pizza.Mushroom);
            return pizza;
        }

        public static Pizza AddCheese(this Pizza pizza, Cheese[] cheese)
        {
            pizza.Cheese = cheese;
            ContextConsole.WriteTopping(pizza.Cheese);
            return pizza;
        }
    }
}
