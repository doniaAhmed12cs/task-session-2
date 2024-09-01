using Microsoft.AspNetCore.Mvc;

namespace session2_mvc.Controllers
{
    public class MoviesController : Controller
    {
        //public ContentResult GetMovie(int id)
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = $"movie with id : {id}";

        //    //return $"movie with id : {id}";
        //    result.ContentType = "object/pdf";
        //    return result;
        //}


        //public string Index()
        //{
        //    return "hello index";
        //}

        public IActionResult GetMovie(int id)
        {
            if (id < 10)
            {
                return BadRequest();
            }

            if (id == 100)
            {
                return NotFound();
            }

            return Content($"movies with id{id}", "text/html");

        }



        [HttpGet]
public IActionResult Create()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "Create";
            return View(result);
        }

    }
}
