using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCVirtualPets.Models;

namespace MVCVirtualPets.Controllers
{
    public class PetController : Controller
    {
        public ViewResult Index()
        {
            var myShelter = new Shelter();

            return View(myShelter);
        }

        public ViewResult Details(int id)
        {
            var myShelter = new Shelter();

            var model = myShelter.PetDict[id];

            return View(model);
        }
    }
}