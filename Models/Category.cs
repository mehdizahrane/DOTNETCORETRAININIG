using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CoreTraining.Models{
    public class Category{


        public int ID { get; set; }
        [Required(ErrorMessage = "Name of the category is required.")]
        [StringLength(50, ErrorMessage = "Name must be less than 50 characters.")]
        public string Name { get; set; }
        
        public string Slug { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public List<Article> Articles { get; set; }

    }
}