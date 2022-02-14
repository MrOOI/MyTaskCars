using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MyTaskCars.Enums;
using MyTaskCars.Services;
using MyTaskCars.ViewModels;

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
            CarsViewModel viewModel = new CarsViewModel()
            {
                List = _carService.GetAllCars(),
                rang = Rang.black
            };
            return View("Index", viewModel);
        }

        public IActionResult FilterByColor(CarsViewModel viewModel)
        {
            CarsViewModel carsViewModel = new CarsViewModel()
            {
                List = _carService.GetByColor(viewModel.rang),
                rang = Rang.black
            };
            return View("ByColor", carsViewModel);
        }

        public IActionResult FilterByPrice(PriceViewModel priceModel)
        {
            PriceViewModel priceViewModel = new PriceViewModel()
            {
                list = _carService.GetByPrice(priceModel.startPrice, priceModel.endPrice),
                startPrice = priceModel.startPrice,
                endPrice = priceModel.endPrice
            };
            return View("ByPrice", priceViewModel);
        }
    }
}
