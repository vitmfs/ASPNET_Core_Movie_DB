using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        // ID
        public int      Id { get; set; }

        // TITLE
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string   Title { get; set; }

        // RELEASE DATE
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        // GENRE
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string   Genre { get; set; }

        // PRICE
        //[Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal  Price { get; set; }

        // RATING
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}