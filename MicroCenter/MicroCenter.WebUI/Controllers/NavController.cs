﻿using System.Web.Mvc;
using System.Collections.Generic;
using MicroCenter.Domain.Abstract;
using System.Linq;

namespace MicroCenter.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository;

        public NavController (IProductRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.Products.Select(x => x.Category)
                                                                .Distinct()
                                                                .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}