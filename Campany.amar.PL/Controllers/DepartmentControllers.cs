using Campany.amar.BLL.Interfaces;
using Campany.amar.DAL.Model;
using Campany.amar.PL.Dtos;
using Microsoft.AspNetCore.Mvc;



namespace Campany.amar.PL.Controllers
{
    public class DepartmentController : Controller
    {
        //MVC Controller
        private readonly IDepartmentRepository _departmentRepository;
        // ASK CLR Create Object From DepartmentRepository
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet] // GET:/Department/Index
        public IActionResult Index()
        {

            var departments = _departmentRepository.GetAll();
            return View(departments);
        }
        [HttpPost]
        

        public IActionResult Create(DepartmentDto model)
        {
            if (ModelState.IsValid) //Server side Valdation 
            {

                var department = new Department()
                {
                    Code = model.Code,
                    Name = model.Name,
                    CreateAt = model.CreateAt

                };

                var Count = _departmentRepository.Add(department);
                if (Count >0) 
                {

                    return RedirectToAction(nameof(Index));
                
                }
            }

            return View(model);

        }
    }
}
