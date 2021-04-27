using e_shop.Interfaces;
using e_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult List()
        {
            var sweetListViewModel = new SweetListViewModel();

            sweetListViewModel.Sweets = _sweetRepository.GetAllSweets;
            sweetListViewModel.CurrentCategory = "Bestsellers";

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
