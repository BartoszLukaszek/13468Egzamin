using System.ComponentModel.DataAnnotations;

namespace _13468Egzamin.Models
{
    public class Class
    {
        public int Id { get; set; }

        [Required]
        public string title { get; set; }   
        [Required]
        public string author { get; set; }
        [Required]
        public string price { get; set; }

    }
}
