using Bussines;
using Entity;
using lab09.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab09.Controllers
{
    public class ProductController1 : Controller
    {
        // GET: ProductoController1
        public ActionResult Index()
        {
            List<ProductModel> list = new List<ProductModel>();

            BProducto BProduct = new BProducto();

            List<Product> productos = BProduct.GetAllProduct();

            List<ProductModel> models = new List<ProductModel>();

            models = productos.Select(x => new ProductModel
            {
                ProductId = x.ProductId,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock

            }).ToList();

            return View(models);
            
        }

        // GET: ProductoController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductoController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductoController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
