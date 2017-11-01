using System;

namespace CoreTraining.Models{

    public class Article{
        public int ID { get; set; }

        public string Title { get; set; }
        public string Caption { get; set; }        
        public string Body { get; set; }
        public string Slug { get; set; }
        
        public Category Category { get; set; }

        public User Publisher { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }

}