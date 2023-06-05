using builder.Common.Enums;
using builder.Common.Models;
using builder.Common.Services;

namespace builder.Builder.Classic
{
    public class ClassicPizzaBuilder
    {
        private Pizza _pizza = new();

        public ClassicPizzaBuilder Size(Size size)
        {
            _pizza.Size = size;
            ContextConsole.WriteTopping(_pizza.Size);
            return this;
        }

        public ClassicPizzaBuilder Dough(Dough dough)
        {
            _pizza.Dough = dough;
            ContextConsole.WriteTopping(_pizza.Dough);
            return this;
        }

        public ClassicPizzaBuilder AddSauce(Sauce sauce)
        {
            _pizza.Sauce = sauce;
            ContextConsole.WriteTopping(_pizza.Sauce );
            return this;
        }

        public ClassicPizzaBuilder AddHam(Ham[] ham)
        {
            _pizza.Ham = ham;
            ContextConsole.WriteTopping(_pizza.Ham);
            return this;
        }

        public ClassicPizzaBuilder AddMushroom()
        {
            _pizza.Mushroom = true;
            ContextConsole.WriteTopping(nameof(_pizza.Mushroom), _pizza.Mushroom);
            return this;
        }

        public ClassicPizzaBuilder AddCheese(Cheese[] cheese)
        {
            _pizza.Cheese = cheese;
            ContextConsole.WriteTopping(_pizza.Cheese);
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}
