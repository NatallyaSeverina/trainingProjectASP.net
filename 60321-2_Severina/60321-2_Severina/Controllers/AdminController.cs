using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CAR.Entities;
using CAR.Repositories;
using CAR.Interfaces;

namespace _60321_2_Severina.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
       
        IRepository<Car> repository;
        public AdminController(IRepository<Car> repo)
        {
             repository = repo;
           
        }
        // GET: Admin
        public ActionResult Index(string message="")
        {
            //ViewBag.Message = Message ?? "";
            ViewBag.Message= message;
            return View(repository.GetAll());
        }

       

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View(new Car());
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Car car, HttpPostedFileBase imageUpload=null)
        {
            if (ModelState.IsValid)
            {
                if (imageUpload != null)
                {
                    var count = imageUpload.ContentLength;
                    car.Image = new byte[count];
                    imageUpload.InputStream.Read(car.Image, 0, (int)count);
                    car.MimeType = imageUpload.ContentType;
                }
                try
                {
                    // TODO: Add insert logic here
                    repository.Create(car);
                   
                    return RedirectToAction("Index",new { message= "Добавлено новое авто" });
                   
                }
                catch
                {
                    return View(car);
                }
            }
            else return View(car);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(repository.Get(id));
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(Car car, HttpPostedFileBase imageUpload)
        {
            if (imageUpload != null)
            {
                var count = imageUpload.ContentLength;
                car.Image = new byte[count];
                imageUpload.InputStream.Read(car.Image, 0, (int)count);
                car.MimeType = imageUpload.ContentType;
            }
            try
            {
                // TODO: Add update logic here
                repository.Update(car);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(car);
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                repository.Delete(id);
                return RedirectToAction("Index", new { message = "Авто удалено" });
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                repository.Delete(id);
                return RedirectToAction("Index", new { message = "Авто удалено" });
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
