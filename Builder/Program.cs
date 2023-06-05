using builder.Builder.Classic;
using builder.Builder.ExtensionMethod.ExternalMethods;
using builder.Builder.ExtensionMethod.InternalMethods;
using builder.Builder.ExtensionMethod.SeparatedMethods;
using builder.Common.Enums;
using builder.Common.Services;

ContextConsole.WriteSeparator("Classic builder");

var margherita = 
    new ClassicPizzaBuilder()
        .Size(Size.Medium)
        .Dough(Dough.GlutenFree)
        .AddSauce(Sauce.Tomato)
        .AddCheese(new Cheese[] { 
            Cheese.Mozzarella })
        .Build();

ContextConsole.WriteSeparator("Extension method builder with self-contained methods");

var prosciuttoEFunghi = 
    SelfContainedMethodsPizzaBuilder
        .CreatePizza(Size.Small, Dough.Neapolitan)
        .AddSauce(Sauce.Tomato)
        .AddHam(new Ham[] {
            Ham.ProsciuttoCrudo })
        .AddMushroom()
        .AddCheese(new Cheese[] { 
            Cheese.Mozzarella });

ContextConsole.WriteSeparator("Extension method builder with separated methods");

var quattroFormaggi =
    SeparatedMethodsPizzaBuilder
        .CreatePizza(Size.Large, Dough.Fermented)
        .AddSauce(Sauce.Tomato)
        .AddCheese(new Cheese[] { 
            Cheese.Mozzarella, Cheese.Gorgonzola, Cheese.Parmesan, Cheese.Robiola })
        .Build();
