using araba_kirala.Data;
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
    }
}
