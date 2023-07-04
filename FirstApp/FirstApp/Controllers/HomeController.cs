using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class HomeController:Controller
    {
        public ContentResult Index()
        {
            return Content("Home Page!");
        }

        public ContentResult About()
        {
            return new ContentResult { Content = "About page!" };
        }

        public ViewResult Contact()
        {
            return View();
        }

        public JsonResult ShowGroup()
        {
            //return new JsonResult(new { no = "P137", type = "programming", startDate = DateTime.UtcNow.ToString("dd.MM.yyyy") });
            return Json(new { no = "P137", type = "programming", startDate = DateTime.UtcNow.ToString("dd.MM.yyyy") });
        }
    }
}
