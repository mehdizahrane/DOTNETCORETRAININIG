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

        [Route("Category/Add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Name)
        {
            if(!String.IsNullOrWhiteSpace(Name))
            {
                var cat = new Category()
                {
                    Name = Name,
                    Slug = Name.Replace(" ", "-"),
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                };
                _context.Add(cat);
                _context.SaveChangesAsync();
                return RedirectToAction("Index","Category");
            }
            else
            {
                ViewData["msg"] = "The name is required.";
                return View("Add");
            }
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id.HasValue)
            {
                var category =  _context.Categories.SingleOrDefault(x => x.ID == id);
                return View("Edit",category);
            }
            else
            {
                ViewData["msg"] = "";
                return View("Index");
            }
        }
        //[HttpPost]
        public IActionResult Update(int? ID,string Name)
        {
            if(!String.IsNullOrWhiteSpace(Name))
            {
                    if(_context.Categories.Any(x => x.ID == ID))
                        {
                            if(_context.Categories.Any(x => x.Name.Equals(Name)))
                            {
                                ViewData["msg"] = "Category name already exists.";
                                return View("Edit",_context.Categories.SingleOrDefault(x => x.ID == ID));
                            }
                            else
                            {
                                var category = _context.Categories.SingleOrDefault(x => x.ID == ID);
                                category.Name = Name;
                                category.Updated = DateTime.Now;
                                category.Slug = Name.Replace(" ", "-");
                                _context.SaveChanges();
                                return RedirectToAction("Index");
                            }
                    }
                    else
                    {
                        return View("Edit",_context.Categories.SingleOrDefault(x => x.ID == ID));
                    }
            }
            else
            {
                ViewData["msg"] = "Category name is required.";
                return View("Edit",_context.Categories.SingleOrDefault(x => x.ID == ID));
            }
        }
        public IActionResult Delete(int? id)
        {
            if(id.HasValue)
            {
                    var cat = _context.Categories.SingleOrDefault(x => x.ID == id);
                    if(cat.Articles != null)
                    {
                        foreach(var article in cat.Articles)
                        {
                            _context.Articles.Remove(article);
                        } 
                        _context.SaveChanges();
                    }
                    _context.Categories.Remove(cat);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }
    }
}