using Godisbutiken12.Models;
using Godisbutiken12.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGodisRepository _godisRepository;

        public HomeController(IGodisRepository godisRepository)
        {
            _godisRepository = godisRepository;
        }
      
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                CandyOnSale = _godisRepository.GetGodisOnSale
            };

            return View(homeViewModel);
        }
    }
}
