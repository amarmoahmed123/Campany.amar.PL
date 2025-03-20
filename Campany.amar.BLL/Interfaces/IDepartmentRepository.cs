using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Campany.amar.DAL.Model;

namespace Campany.amar.BLL.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();

        Department? Get(int id);

        int Add(Department model);
        int Update(Department model);
        int Delete(Department model);


    }
}
