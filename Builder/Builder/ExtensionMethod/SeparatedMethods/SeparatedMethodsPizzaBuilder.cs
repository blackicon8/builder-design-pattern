using builder.Common.Enums;
using builder.Common.Models;
using builder.Common.Services;

namespace builder.Builder.ExtensionMethod.SeparatedMethods
{
    public class SeparatedMethodsPizzaBuilder
    {
        internal Pizza Pizza { get; set; } = new Pizza();

        public static SeparatedMethodsPizzaBuilder CreatePizza(Size size, Dough dough)
        {
            var builder = new SeparatedMethodsPizzaBuilder();

            builder.Pizza.Size = size;
            builder.Pizza.Dough = dough;

            ContextConsole.WriteTopping(builder.Pizza.Size);
            ContextConsole.WriteTopping(builder.Pizza.Dough);

            return builder;
        }

        public Pizza Build()
        { 
            return Pizza; 
        }
    }
}
