using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboAzTask.Models;
using TurboAzTask.ViewModels;

namespace TurboAzTask.Controllers
{
    public class HomeController:Controller
    {
        private List<Car> _cars;

        private List<Brand> _brands;

        private List<Model> _models;

        private List<CarImages> _carImages;
        public HomeController()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, Year=2015, Price=50000, BrandName="Audi",ModelName="Q7"},
                new Car {Id=2, Year=2018, Price=51000, BrandName="BMW",ModelName="530"},
                new Car {Id=3, Year=2018, Price=37000, BrandName="Mercedes-Benz",ModelName="C180"},
                new Car {Id=4, Year=2019, Price=49000, BrandName="Dodge",ModelName="Challanger"},
                new Car {Id=5, Year=2016, Price=32000, BrandName="Ford",ModelName="Mustang"},
                new Car {Id=6, Year=2015, Price=104000, BrandName="Porsche",ModelName="911"}
            };



            _brands = new List<Brand>
            {
                new Brand {Id=1, Name = "Audi"},
                new Brand {Id=2, Name = "BMW"},
                new Brand {Id=3, Name = "Mercedes-Benz"},
                new Brand {Id=4, Name = "Dodge"},
                new Brand {Id=6, Name = "Ford"},
                new Brand {Id=7, Name = "Porsche"}

            };1



            _models = new List<Model>
            {
                new Model {Id=1, Name="Q7"},
                new Model {Id=2, Name="530"},
                new Model {Id=3, Name="C180"},
                new Model {Id=3, Name="Challanger"},
                new Model {Id=3, Name="Mustang"},
                new Model {Id=3, Name="911"}
            };

            _carImages = new List<CarImages>
            {
                new CarImages {Id=1, ImageUrl="https://i.gaw.to/vehicles/photos/40/23/402350-2021-audi-q7.jpg?1024x640"},
                new CarImages {Id=2, ImageUrl="https://www.tuningblog.eu/wp-content/uploads/2018/02/HAMANN-Motorsport-BMW-G30-Tuning-2018-4.jpg"},
                new CarImages {Id=3, ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4NyeYqNzwa4TM24dFrCUAikUnOCY08NPuNg&usqp=CAU"},
                new CarImages {Id=4, ImageUrl="https://cdn.jdpower.com/jdpa_2022%20dodge%20challenger%20gt%20rwd%20with%20hemi%20orange%20appearance%20package%20front%20quarter%20view.jpg"},
                new CarImages {Id=5, ImageUrl="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2022-ford-mustang-shelby-gt500-02-1636734552.jpg"},
                new CarImages {Id=6, ImageUrl="https://cdn.motor1.com/images/mgl/x66XP/s1/2022-porsche-911-gt3-tail.jpg"},
            };
        }
        public ActionResult Index()
        {

            HomeViewModel homeVm = new HomeViewModel
            {
                Cars = _cars,
                Brands = _brands,
                Models = _models,
                Images = _carImages
            };
            return View(homeVm);
        }

        public ActionResult Details(int id)
        {
           
             if(id<0|| id>_cars.Count)
            {
                TempData["Error"] = "Error has been occured";
                return RedirectToAction("Error");
            }
            else
            {
                Car car = _cars.Find(x => x.Id == id);
            return View(car);
            }
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}
