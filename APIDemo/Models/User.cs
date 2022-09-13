using System.ComponentModel.DataAnnotations;

namespace APIDemo.Models
{
        public class User
        {
            public int Id { get; set; }
            [Required]
            public string? Name { get; set; }
            public string Mail { get; set; }
        }
}
