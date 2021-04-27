using e_shop.Interfaces;
using e_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace e_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISweetRepository _sweetRepository;

        public HomeController(ISweetRepository sweetRepository)
        {
            _sweetRepository = sweetRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel {
                SweetsOnSale = _sweetRepository.GetSweetsOnSale()
            };

            return View(homeViewModel);
        }
    }
}
