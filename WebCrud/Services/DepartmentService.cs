using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrud.Data.Models;
using WebCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace WebCrud.Services
{
    public class DepartmentService
    {
        private readonly WebCrudContext _context;

        public DepartmentService(WebCrudContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> findAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
