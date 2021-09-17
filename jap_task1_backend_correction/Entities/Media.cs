using JapTask1BackendCorrection.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JapTask1BackendCorrection.Entities
{
    public class Media
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100, ErrorMessage = "Title cannot be longer than 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [MaxLength(400, ErrorMessage = "Description cannot be longer than 200 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "ImageUrl is required")]
        [MaxLength(200, ErrorMessage = "Image url cannot be longer than 200 characters")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Media type is required")]
        public MediaEnum Type { get; set; }

        [Required(ErrorMessage = "ReleaseDate is required")]
        public DateTime ReleaseDate { get; set; }

        public List<Actor> Actors { get; set; } = new List<Actor>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Screening> Screenings { get; set; } = new List<Screening>();
    }
}
