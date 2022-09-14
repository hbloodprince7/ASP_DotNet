using System.ComponentModel.DataAnnotations;

namespace PizzaClass_Lib.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public PizzaSize Size { get; set; }
        public bool IsGlutenFree { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }
    }

    public class Topping
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsVeg { get; set; }
    }

    public class Sauce
    {
        public int ID { get; set; }
        public string Name { get; set; } 
    }

    public enum PizzaSize
    {
        Small, Medium, Large
    }
}
