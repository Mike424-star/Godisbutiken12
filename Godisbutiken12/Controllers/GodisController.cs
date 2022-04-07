using Godisbutiken12.Models;
using Godisbutiken12.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.Controllers
{
    public class GodisController : Controller
    {
        private readonly IGodisRepository _godisRepository;
        private readonly ICategoryRepository _categoryRepository;


        public GodisController(IGodisRepository godisRepository, ICategoryRepository categoryRepository)
        {
            _godisRepository = godisRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List(string category)
        {
            IEnumerable<Godis> godisar;
            string currentCategory;
           
            if (string.IsNullOrEmpty(category))
            {
                godisar = _godisRepository.GetAllGodis.OrderBy(c => c.GodisID);
                currentCategory = "Alla Godisar";
            }
            else
            {
                godisar = _godisRepository.GetAllGodis.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new GodisListViewModel
            {
                Godisar = godisar,
                CurrentCategory = currentCategory,
            });
        }
        public IActionResult Details(int id)
        {
            var godis = _godisRepository.GetGodisById(id);
            if (godis == null) return NotFound();

            return View(godis); 
        }
    }
}
