using Microsoft.AspNetCore.Mvc;
using SimpleInMemoryCRUD.Data;
using SimpleInMemoryCRUD.Models;

namespace SimpleInMemoryCRUD.Controllers
{
    public class ProductController : Controller
    {
        //Ürünlerin listelendiği ana sayfayı döndürür
        public IActionResult Index()
        {
            return View(InMemoryDatabase.Products);
        }

        //Yeni ürün eklemek için kullanılan sayfayı döndürür
        public IActionResult Create()
        {
            return View();
        }

        //Yeni ürün ekleme işlemi
        [HttpPost]
        public IActionResult Create(Product product)
        {
            //Yeni ürün için unique bir ID oluşturuluyor
            product.Id = InMemoryDatabase.Products.Any()
                ? InMemoryDatabase.Products.Max(p => p.Id) + 1
                : 1;
            InMemoryDatabase.Products.Add(product);//Ürün listeye ekleniyor
            return RedirectToAction("Index");
        }

        //Ürün düzenleme sayfasını döndürür
        public IActionResult Edit(int id)
        {
            var product = InMemoryDatabase.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }

        //Ürün düzenleme işlemi
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var existingProduct = InMemoryDatabase.Products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null) return NotFound();

            //Bilgileri güncelleme
            existingProduct.Name = product.Name;
            existingProduct.Quantity = product.Quantity;
            return RedirectToAction("Index");
        }

        //Ürün silme işlemi
        public IActionResult Delete(int id)
        {
            var product = InMemoryDatabase.Products.FirstOrDefault(p => p.Id == id);
            if (product != null) InMemoryDatabase.Products.Remove(product);
            return RedirectToAction("Index");
        }
    }
}
