using System;
using Microsoft.AspNetCore.Mvc;
using CoreTraining.Models;
namespace CoreTraining.Controllers
{
    public class ArticlesController : Controller
    {
            public IActionResult articleDetails(string slug)
            {
                if(!string.IsNullOrWhiteSpace(slug))
                {
                    var article = new Article()
                    {
                        
                    };
                    return View("Index");
                }   
                else{
                    return RedirectToAction("Index","Home");
                }
            }
    }
}