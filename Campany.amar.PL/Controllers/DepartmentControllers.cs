using Campany.amar.BLL.Interfaces;
using Campany.amar.BLL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Campany.amar.PL.Controllers
{
    public class DepartmentController : Controller
    {
        //MVC Controller
        private readonly IDepartmentRepository _departmentRepository;
        // ASK CLR Create Object From DepartmentRepository
        public DepartmentController( IDepartmentRepository departmentRepository) 
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet] // GET:/Department/Index
        public  IActionResult Index()
        {
           
           var departments = _departmentRepository.GetAll();
            return View(departments);
        }
    }
}
