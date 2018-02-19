using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string Name { get; set; }

        //[Required]
        //public Genre Genre { get; set; }

        [Required]
        //[Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        //[Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        //[Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}