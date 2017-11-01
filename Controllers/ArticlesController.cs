using System;
using Microsoft.AspNetCore.Mvc;
using CoreTraining.Models;
namespace CoreTraining.Controllers
{
    public class ArticlesController : Controller
    {

            [Route("Articles/{slug}")]         
            public IActionResult articleDetails(string slug)
            {
                if(!string.IsNullOrWhiteSpace(slug))
                {
                    var article = new Article()
                    {
                        Title = "Security Inks Industry Research: Types & Applications",
                        Body = "Since the last few decades, the market for security printing has experienced significant changes comprising technological intricacy.<br/> Hence, the various versions of security inks have matured in features which are different as compared to conventional printing inks. Presently, one of the most widely used inks is invisible ultraviolet; it gets revealed when the print is focused on a black lamp or any sort of UV light source.Security Ink Applications What makes security inks so important? The utility and application of security inks are fixated to fields where secrecy is the prime motto of an individual, company or government. Usually, security inks are devoted exclusively towards security applications such as creating banknotes, postage stamps, official identity documents (identity cards, birth certificates, passports etc.), security labels, tax banderoles and product markings. It is essential to know that with the growth of the financial system across different nations, the security ink industry is flourishing at a significant rate. Inks and Printing Processes What is an ideal security ink? As per expert knowledge and analysis, an ideal ink is the one that can transfer, print and dry smoothly in different operational environments. However, considering the real aspect, the structure of each security ink can vary provisional to a number of printing factors. Some of these factors such as rheology, pigment size, drying chemistry and viscosity are framed to match the industrial printing performance of diverse printing processes and machine types along with a combination of substrate variations. At present, the different printing processes used for the production of banknotes as well as security documents are silkscreen, intaglio, offset, gravure, flexography, letterpress as well as inkjet printing. Types Security Inks Security ink variety indeed matters depending on the application involved. Let us check out some of the most preferred security ink types which are needed for high-end preservation purposes. Invisible Ink Invisible ink is the most widely used ink which is also called as ‘invisible ultra violet’.  UV light is the only source which makes the ink glow. Invisible ink is primarily used for cheque printing and document protection. The most advantageous aspect about this ink type is that it is cheap and can be accessed in a wider colour range.",
                        Caption = "../images/pic05.jpg",
                        Created = DateTime.Now,
                        Publisher = new User() { Username = "mehdi zahrane" }
                    };
                    return View("Index",article);
                }   
                else
                {
                    return RedirectToAction("Index","Home");
                }
            }
            [Route("Articles")]
            public IActionResult Articles(){
                return RedirectToAction("Index","Home");
            }
    }
}