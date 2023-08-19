using E_Ticaret.BL.Repositories;
using E_Ticaret.DAL.Entities;
using E_Ticaret.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.UI.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Slide> repoSlide;
        IRepository<Product> repoProduct;
        public HomeController(IRepository<Slide> _repoSlide, IRepository<Product> _repoProduct)
        {
            repoSlide = _repoSlide;
            repoProduct = _repoProduct;

        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM()
            {
                Slides = repoSlide.GetAll().OrderBy(x => x.DisplayIndex),
                Products = repoProduct.GetAll().Include(x => x.ProductPictures).OrderByDescending(x => x.ID).Take(8)
            };
            return View(indexVM);
        }


        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
