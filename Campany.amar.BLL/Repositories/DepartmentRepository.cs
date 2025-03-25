using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campany.amar.BLL.Interfaces;
using Campany.amar.DAL.Data.Context;
using Campany.amar.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace Campany.amar.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CampanyDbContext _Context;//NuLL

        //ASK CLR Create Object From CampanyDbContext
        public DepartmentRepository(CampanyDbContext context)
        {
            _Context = context;

        }
        public IEnumerable<Department> GetAll()
        {

            return _Context.Departments.ToList();
        }
        public Department? Get(int id)
        {

            return _Context.Departments.Find(id);
        }
        public int Add(Department model)
        {

            _Context.Departments.Add(model);
            return _Context.SaveChanges();
        }

        public int Update(Department model)
        {

            _Context.Departments.Update(model);
            return _Context.SaveChanges();
        }
        public int Delete(Department model)
        {

            _Context.Departments.Remove(model);
            return _Context.SaveChanges();
        }

       
    }
}