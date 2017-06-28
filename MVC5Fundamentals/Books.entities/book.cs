using System.ComponentModel.DataAnnotations;


namespace Books.entities
{
    public class book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public Genre Category { get; set; }
    }
}
