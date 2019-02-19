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
            return View();
        }

        public ViewResult Details(int id)
        {
            Dictionary<int,Pet> PetDict = new Dictionary<int,Pet>();
            PetDict.Add(1, new Pet("Fido"));
            PetDict.Add(2, new Pet("Fluffy"));
            

                return View(PetDict[id]);
        }
    }
}