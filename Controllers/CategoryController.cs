using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CoreTraining.Contexts;
using CoreTraining.Models;
using System.Linq;
using CoreTraining.ViewModels;
namespace CoreTraining.Controllers
{
    public class CategoryController : Controller 
    {
        private readonly CodingClubDbContext _context;
        public CategoryController(CodingClubDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           
           var vm = new CategoryIndexViewModel()
           {
               Categorys = _context.Categories.ToList()
           };
            return View("Index",vm);
        }
    }
}