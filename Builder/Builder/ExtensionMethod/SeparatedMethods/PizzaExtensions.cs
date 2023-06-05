using builder.Builder.ExtensionMethod.SeparatedMethods;
using builder.Common.Enums;
using builder.Common.Services;

namespace builder.Builder.ExtensionMethod.ExternalMethods
{
    public static class PizzaExtensions
    {
        public static SeparatedMethodsPizzaBuilder AddSauce(this SeparatedMethodsPizzaBuilder builder, Sauce sauce) 
        { 
            builder.Pizza.Sauce = sauce;
            ContextConsole.WriteTopping(builder.Pizza.Sauce);
            return builder;
        }

        public static SeparatedMethodsPizzaBuilder AddHam(this SeparatedMethodsPizzaBuilder builder, Ham[] ham)
        {
            builder.Pizza.Ham = ham;
            ContextConsole.WriteTopping(builder.Pizza.Ham);
            return builder;
        }

        public static SeparatedMethodsPizzaBuilder AddMushroom(this SeparatedMethodsPizzaBuilder builder)
        {
            builder.Pizza.Mushroom = true;
            ContextConsole.WriteTopping(nameof(builder.Pizza.Mushroom), builder.Pizza.Mushroom);
            return builder;
        }

        public static SeparatedMethodsPizzaBuilder AddCheese(this SeparatedMethodsPizzaBuilder builder, Cheese[] cheese)
        {
            builder.Pizza.Cheese = cheese;
            ContextConsole.WriteTopping(builder.Pizza.Cheese);
            return builder;
        }
    }
}
