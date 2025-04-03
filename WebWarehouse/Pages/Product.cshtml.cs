using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebWarehouse.Data;
using WebWarehouse.Model;
using System;

namespace WebWarehouse.Pages
{
    public class Product1Model : PageModel
    {
        private readonly ApplicationDbContext _context;

        public Product1Model(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Product Product { get; set; }

        public void OnGet(int id)
        {
            if (id > 0)
            {
                Product = _context.products.FirstOrDefault(b => b.Id == id);
            }
            else
            {
                Product = new Product() { Id = 0 , Name = "", Price = 0, Quantity = 0};
            }
        }
    }
}
