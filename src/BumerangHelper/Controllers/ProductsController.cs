using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BumerangHelper.Models.DatabaseModels;
using BumerangHelper.Models.ViewModels;

namespace BumerangHelper.Controllers
{
    public class ProductsController : Controller
    {
        private Context db;

        public ProductsController(Context context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            
            var productViewModelList = new List<ProductViewModel>();
            db.Products.ToList().ForEach(p =>
            {
                productViewModelList.Add(new ProductViewModel(p));
            });
            return View(productViewModelList);
        }

        public IActionResult Details(int id)
        {
            var productViewModel = new ProductViewModel(db.Products.Where(p => p.ProductID == id).First());
            return View(productViewModel);
        }

        public IActionResult Edit(int id)
        {
            var productViewModel = new ProductViewModel(db.Products.Where(p => p.ProductID == id).First());
            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProductViewModel editedProduct)
        {
            return null;
        }

        public IActionResult Delete(int id)
        {
            return null;
        }
    }
}
