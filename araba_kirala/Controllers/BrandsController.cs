using araba_kirala.Data;
using araba_kirala.Models;
using Microsoft.AspNetCore.Mvc;

namespace araba_kirala.Controllers
{
    public class BrandsController : Controller
    {
        private readonly Context _context;
        //DATABASE BAĞLANTISI OLUŞTUR
        public BrandsController(Context context)
        {
            //SİSTEM AÇILIR AÇILMAZ DATABASE BAĞLAN
            _context = context;
        }

        public IActionResult Index()
        {
            var listem = _context.Brands.ToList();
            //tüm markaları listesini al lambda linq
            //select * from Brands 
            return View(listem);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Brands gelen)
        {
            _context.Brands.Add(gelen);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int? id) 
        {
            var bul = _context.Brands.Where(x => x.BrandID == id).FirstOrDefault();
            return View(bul);
        }
        [HttpPost]
        public IActionResult Delete(Brands gelen)
        {
            var bul = _context.Brands.Find(gelen.BrandID);
            _context.Brands.Remove(bul);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
