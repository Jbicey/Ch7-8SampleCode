using System.Web.Mvc;
using System.Collections.Generic;
using SportsStore.Domain.Abstract;
using System.Linq;

namespace SportsStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductsRepository repository;

        public NavController(IProductsRepository repo)
        {
            repository = repo;
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
        {
            IEnumerable<string> categories = repository.Products
                            .Select(x => x.Categorty)
                            .Distinct()
                            .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}