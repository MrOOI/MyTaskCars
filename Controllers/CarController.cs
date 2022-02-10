using Microsoft.AspNetCore.Mvc;
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
    }
}
