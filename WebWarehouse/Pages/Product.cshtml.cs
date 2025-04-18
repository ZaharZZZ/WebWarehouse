using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebWarehouse.Data;
using WebWarehouse.Model;
using System;
using Microsoft.AspNetCore.Authorization;

namespace WebWarehouse.Pages
{
    [Authorize]
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
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Product.Id == 0)
            {
                _context.products.Add(Product);
            }
            else
            {
                _context.products.Update(Product);
            }
            _context.SaveChanges();
            return RedirectToPage("Products");
        }
    }
}
