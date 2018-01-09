using _60321_2_Severina.Models;
using CAR.Entities;
using CAR.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _60321_2_Severina.Controllers
{
    public class CartController : Controller
    {
        IRepository<Car> repository;
        public CartController(IRepository<Car> repo)
        {
            repository = repo;
        }
        // GET: Cart
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        [Authorize]
        public ActionResult Index(string returnUrl)
        {
            Cart cart = GetCart();
            TempData["returnUrl"] = returnUrl;
            return View(cart);
           // return View(GetCart());
        }
        public RedirectResult AddToCart(int id,string returnUrl)
        {
            var item = repository.Get(id);
            if (item != null)
                GetCart().AddItem(item);
            return Redirect(returnUrl);
        }
        public PartialViewResult CartSummary(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return PartialView(GetCart());
        }
    }
}