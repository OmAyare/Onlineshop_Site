using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Purchase.Models;

namespace Purchase.Controllers
{
    public class ProductTypeController : Controller
    {
        // GET: ProductType
        public ActionResult List()
        {
            List<ProductType> productTypeList = new List<ProductType>()
            {
                new ProductType (){pk_prodtypeId=1, Description="Open Product"},
                new ProductType (){pk_prodtypeId=2, Description="CLose Product"},
                new ProductType (){pk_prodtypeId=3, Description="Cloth Product"}
            };
            return View(productTypeList);
        }
    }
}