using System;
using System.Collections.Generic;

namespace CoreTraining.Models{
    public class Category{


        public int ID { get; set; }
        public string Name { get; set; }
        
        public string Slug { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public List<Article> Articles { get; set; }

    }
}