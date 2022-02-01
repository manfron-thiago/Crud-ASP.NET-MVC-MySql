using System.Collections.Generic;
using System.Linq;
using WebCrud.Data.Models;
using WebCrud.Models;

namespace WebCrud.Services
{
    public class DepartmentService
    {
        private readonly WebCrudContext _context;

        public DepartmentService(WebCrudContext context)
        {
            _context = context;
        }
        public List<Department> findAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
