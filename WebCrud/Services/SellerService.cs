using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrud.Data.Models;
using WebCrud.Models;

namespace WebCrud.Services
{
    public class SellerService
    {
        private readonly WebCrudContext _context;

        public SellerService(WebCrudContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
