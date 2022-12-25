using InnovationStuff.Core.ViewModel;
using InnovationStuff.Persistance;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;

namespace InnovationStuff.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationContext _context;
        public HomeController()
        {
            _context = new ApplicationContext();
        }
        public ActionResult Index()
        {
            StudentsCourses sc = new StudentsCourses
            {
                Courses = _context.Courses.ToList(),

                Students = _context.Students
                                    .Include(s => s.Courses)
                                    .ToList()
            };

            return View(sc);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}