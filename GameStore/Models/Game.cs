using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Game
    {
        
        // Properties for the game object
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required]
        [StringLength(20)]
        public decimal Price { get; set; }
        [Range(1,100)]
        public required string Platforms { get; set; }
         public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}