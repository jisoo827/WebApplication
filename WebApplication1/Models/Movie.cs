using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date), Range(typeof(DateTime), "1/1/1900", "1/1/2040")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z가-힣]+[a-zA-Z가-힣\s]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        [DataType(DataType.Currency), Range(1, 100), Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z가힣]+[a-zA-Z0-9가-힣""'\s-]*$"), StringLength(10)]
        public string Rating { get; set; }
    }
}
