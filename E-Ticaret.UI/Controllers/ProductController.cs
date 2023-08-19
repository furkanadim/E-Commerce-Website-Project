﻿using E_Ticaret.BL.Repositories;
using E_Ticaret.DAL.Entities;
using E_Ticaret.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.UI.Controllers
{
    public class ProductController : Controller
    {
        IRepository<Product> repoProduct;
        public ProductController(IRepository<Product> _repoProduct)
        {
            repoProduct = _repoProduct;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Route("urun/{name}-{id}")]
        public IActionResult Detail(string name, int id)
        {
            Product product = repoProduct.GetAll(x => x.ID == id).Include(x => x.Category).Include(x => x.ProductPictures).FirstOrDefault();

            if (product != null)
            {
                ProductVM productVM = new ProductVM()
                {
                    Product = product,
                    RelatedProducts = repoProduct.GetAll(x => x.ID == product.CategoryID && x.ID != product.ID).Include(x => x.ProductPictures)
                };
                return View(productVM);
            }
            else
            {
                return Redirect("/");
            }
        }

        public IActionResult ProductPage(string name, int id)
        {
            IndexVM indexVM = new IndexVM()
            {
                Products = repoProduct.GetAll().Include(x => x.ProductPictures).OrderByDescending(x => x.ID).Take(15)
            };
            return View(indexVM);
        }
    }
}
