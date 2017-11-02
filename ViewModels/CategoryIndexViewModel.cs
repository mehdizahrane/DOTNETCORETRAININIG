using System;
using CoreTraining.Models;
using System.Linq;
namespace CoreTraining.ViewModels{
    public class CategoryIndexViewModel{
        public IQueryable<Category> Categorys { get; set; }
    }
}