using System.Text;

namespace builder.Common.Services
{
    public static class ContextConsole
    {
        public static void WriteSeparator(string title)
        {
            Console.WriteLine();
            Console.WriteLine("===============================================================================");
            Console.WriteLine(title);
            Console.WriteLine("===============================================================================");
            Console.WriteLine();
        }

        public static void WriteTopping(string name, bool value)
        {
            var message = "No";

            if (value) { message = "Yes"; }

            Console.WriteLine($"{ name }: { message }");
        }

        public static void WriteTopping<T>(T topping) where T : struct
        {
            Console.WriteLine($"{typeof(T).Name}: { topping }");
        }

        public static void WriteTopping<T>(T[] toppings) where T : struct
        {
            var message = new StringBuilder($"{ typeof(T).Name }: ");

            foreach (var topping in toppings) 
            {
                message.Append($"{ topping.ToString() }, ");
            }

            message.Remove(message.Length - 2, 2);

            Console.WriteLine(message);
        }
    }
}
