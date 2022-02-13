using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MyTaskCars.Enums;
using MyTaskCars.Services;

namespace MyTaskCars.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        public ViewResult Index()
        {
            return View("Index", _carService.GetAllCars());
        }

        public IActionResult FilterByColor(Rang color)
        {

            return View("ByColor", _carService.GetByColor(color));
        }

        public IActionResult FilterByPrice(int startPrice, int endPrice)
        {
            return View("Index", _carService.GetByPrice(startPrice, endPrice));
        }
    }
}
