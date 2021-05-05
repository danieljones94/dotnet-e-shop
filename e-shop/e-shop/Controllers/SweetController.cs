using e_shop.Interfaces;
using e_shop.Models;
using e_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace e_shop.Controllers
{
    public class SweetController : Controller
    {
        private readonly ICategoryRepository _categoryRespository;
        private readonly ISweetRepository _sweetRepository;

        public SweetController(ISweetRepository sweetRepository, ICategoryRepository categoryRepository)
        {
            _sweetRepository = sweetRepository;
            _categoryRespository = categoryRepository;
        }

        public ViewResult List(string name)
        {

            IEnumerable<Sweet> sweets;
            string category;

            if (string.IsNullOrEmpty(name)) {
                sweets = _sweetRepository.GetAllSweets.OrderBy(o => o.Id);
                category = "All";
            } else {
                sweets = _sweetRepository.GetAllSweets.Where(o => o.Category.Name == name);
                category = _categoryRespository.GetAllCategories.FirstOrDefault(o => o.Name == name)?.Name;
            }

            var sweetListViewModel = new SweetListViewModel();

            sweetListViewModel.Sweets = sweets;
            sweetListViewModel.CurrentCategory = category;

            return View(sweetListViewModel);
        }

        public IActionResult Details(int id)
        {
            var sweet = _sweetRepository.GetSweetById(id);

            if (sweet == null) {
                return NotFound();
            }

            return View(sweet);
        }

    }
}
