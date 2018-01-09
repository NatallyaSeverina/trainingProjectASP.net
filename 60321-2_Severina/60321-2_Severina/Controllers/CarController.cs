using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CAR.Interfaces;
using CAR.Entities;
using _60321_2_Severina.Models;
using System.Threading.Tasks;

namespace _60321_2_Severina.Controllers
{
    public class CarController : Controller
    {
        int pageSize = 3;
        IRepository<Car> repository;
        public CarController(IRepository<Car> repo)
        {
            repository = repo;
        }
        
        // GET: Car
        public ActionResult List(string group,int page=1)
        {
            var lst = repository.GetAll().Where(c => group == null || c.CarYear.Equals(int.Parse(group))).OrderBy(c => c.Price);
            var model = PageListViewModel<Car>.CreatePage(lst, page,pageSize);
            if (Request.IsAjaxRequest())
            {
                return PartialView("ListPartial", model);
            }
            return View(model);
        }
        public async Task<FileResult> GetImage(int id)
        {
            Car car= await repository.GetAsync(id);
            if (car != null)
                return File(car.Image, car.MimeType);
            else
                return null;
        }
        public ActionResult Index()
        {
           
            return View();
        }
    }
}