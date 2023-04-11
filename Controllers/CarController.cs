using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TPN1_GonzalezSmithTomas.Models;
using TPN1_GonzalezSmithTomas.Services;

namespace TPN1_GonzalezSmithTomas.Controllers;

public class CarController : Controller
{
    public CarController()
    {
    }

    public IActionResult Index()
    {   
        var model = new List<Car>();
        model = CarService.GetAll();

        return View(model);
    }

    public IActionResult Detail(string id)
    {
        var model = CarService.Get(id);

        return View(model);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Car car){
        if(!ModelState.IsValid){
            return RedirectToAction("Create");
        }

        CarService.Add(car);

        return RedirectToAction("Index");
    }

    public IActionResult Delete(string code){
        
            if(code != null){
                CarService.Delete(code);
            }

            return RedirectToAction("Index");
        }
}