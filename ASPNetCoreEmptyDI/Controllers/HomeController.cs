using ASPDotNetCEmptyDI.DAL;
using ASPDotNetCEmptyDI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCEmptyDI.Controllers
{
    public class HomeController : Controller
    {
     //--   https://dotnettutorials.net/lesson/asp-net-core-dependency-injection/

        //---Constructor Injection IStudentRepository studentRepo
        //readonly IStudentRepository _studentRepository;
        //public HomeController(IStudentRepository studentRepository) {
        //    _studentRepository = studentRepo;
        //}


        //--Method Injection [FromServices] IStudentRepository studentRepository
        public JsonResult Index([FromServices] IStudentRepository _studentRepository)
        {
            //StudentRepository studentRepository = new StudentRepository();
            var students = _studentRepository.GetAllStudents();
            return Json(students);
        }

        public JsonResult GetStudentDetails([FromServices] IStudentRepository _studentRepository, int id)
        {
            // StudentRepository studentRepository = new StudentRepository();
            var student = _studentRepository.GetStudent(id);
            return Json(student);
        }

        public JsonResult GetDescription()
        {
            string str = "What are the Advantages of using ASP.NET Core Dependency Injection?" +
                "\n\nThe ASP.NET Core Dependency Injection allows us to develop loosely coupled software components. " +
                "Using the ASP.NET Core Dependency Injection, swapping with a different component implementation is very easy. " +
                "Here are some of the advantages of using dependency injection in ASP.NET Core:" +
                "\nLoose Coupling: By using dependency injection, we can separate our classes from their dependencies. This results in code that is simpler to maintain and test." +
                "\nTestability: By using dependency injection, we can increase the testability of our code since we can easily replace dependencies with mock objects during unit testing." +
                "\nExtensibility: Using Dependency injection enhances the extensibility of our code by offering the flexibility to switch out dependencies conveniently." +
                "\nReusability: Using dependency injection makes our code more reusable since we can conveniently share dependencies among various classes.";
            return Json(str);
        }
    }
}
