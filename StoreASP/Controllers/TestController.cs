using Store.Entities;
using Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreASP.Controllers
{
    public class TestController : Controller
    {
        ProductServices productServices = new ProductServices();
        // GET: Test
        public ActionResult Index()
        {
            return View(productServices.GetProducts());
        }
        public ActionResult Detail(int? id)
        {
            if(id==null) return HttpNotFound();     //ID olmadan səhifəni açmağa icazə vermir 
            Product selectedProduct = productServices.GetProduct(id);
            if (selectedProduct == null) return HttpNotFound(); //ID olmadan səhifəni açmağa icazə vermir 
            return View(selectedProduct);
        }
    }
}