using CRMAX.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRMAX.Web.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetCustomer()
        {

            Customer customer = new Customer();
            customer.direccion = "Decima Sexta 213";
            customer.telefono = "83323452";
            customer.correo = "luis_araizag@hotmail.com";
            customer.nombre = "Juan Alberto Araiza Garcia";


            return Json(customer, JsonRequestBehavior.AllowGet);



        }
    }
}