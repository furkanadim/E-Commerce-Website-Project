﻿using E_Ticaret.BL.Repositories;
using E_Ticaret.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.UI.Areas.admin.Controllers
{
    [Area("admin"), Authorize]
    public class BrandController : Controller
    {
        IRepository<Brand> repoBrand;
        public BrandController(IRepository<Brand> _repoBrand)
        {
            repoBrand = _repoBrand;
        }
        public IActionResult Index()
        {
            return View(repoBrand.GetAll().OrderByDescending(x => x.ID));
        }

        public IActionResult New()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(Brand model)
        {
            if (ModelState.IsValid)
            {
                repoBrand.Add(model);
                return RedirectToAction("Index");
            }

            else return RedirectToAction("New");
        }

        public IActionResult Edit(int id)
        {
            Brand slide = repoBrand.GetBy(x => x.ID == id);
            if (slide != null) return View(slide);
            else return RedirectToAction("Index");

        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Brand model)
        {
            if (ModelState.IsValid)
            {
                repoBrand.Update(model);
                return RedirectToAction("Index");
            }

            else return RedirectToAction("New");
        }

        public IActionResult Delete(int id)
        {
            Brand slide = repoBrand.GetBy(x => x.ID == id);
            if (slide != null) repoBrand.Delete(slide);
            return RedirectToAction("Index");
        }

    }
}
