using Microsoft.AspNetCore.Mvc;
using MyAwardsCollection.Models;
using MyAwardsCollection.Structure;

namespace MyCollection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAwards _awardcollection;

        public HomeController(IAwards awards)
        {
            _awardcollection = awards;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var awards = _awardcollection.GetAll();
            return View(awards);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MyAwards myawards)
        {
            _awardcollection.Insert(myawards);
            _awardcollection.Save();
            //return View();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var myawards = _awardcollection.GetById(Id);
            return View(myawards);
        }
        [HttpPost]
        public IActionResult Delete(MyAwards myAwards)
        {
            _awardcollection.Delete(myAwards);
            _awardcollection.Save();
            //return View();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var myawards = _awardcollection.GetById(Id);
            return View(myawards);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var myawards = _awardcollection.GetById(Id);
            return View(myawards);
        }
        [HttpPost]
        public IActionResult Edit(MyAwards myAwards)
        {
            _awardcollection.Update(myAwards);
            _awardcollection.Save();
            return RedirectToAction("Index");
        }

    }
}
