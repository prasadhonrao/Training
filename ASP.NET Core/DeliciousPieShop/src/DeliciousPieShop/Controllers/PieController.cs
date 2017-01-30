using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeliciousPieShop.Models;
using DeliciousPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliciousPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IPieRepository pieRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository;
            this.categoryRepository = categoryRepository;

        }
        // GET: /<controller>/
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            PiesListViewModel piesVM = new PiesListViewModel();
            piesVM.Pies = this.pieRepository.Pies;
            piesVM.CurrentCategory = "Cheese Cake";
            return View(piesVM);
        }
    }
}
