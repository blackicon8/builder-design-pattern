

using builder.Common.Enums;

namespace builder.Common.Models
{
    public class Pizza
    {
        public Size Size { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Ham[] Ham { get; set; }
        public bool Mushroom { get; set; }
        public Cheese[] Cheese { get; set; }
    }
}
