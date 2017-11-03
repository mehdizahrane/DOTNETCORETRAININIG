using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CoreTraining.Models{
    public class Category{


        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        public string Slug { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public List<Article> Articles { get; set; }

    }
}