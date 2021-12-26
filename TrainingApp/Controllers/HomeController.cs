using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrainingApp.Models;

namespace TrainingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
 
        [HttpGet]
        public ViewResult SingUpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SingUpForm(StudentResponse studentResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(studentResponse);
                return View("Thanks", studentResponse);
            }
            else
            {
                return View();
            }


        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.Training == "Recruiting"));
        }



    }


}
