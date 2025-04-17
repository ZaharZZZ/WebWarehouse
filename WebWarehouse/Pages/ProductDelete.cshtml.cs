using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebWarehouse.Data;

namespace WebWarehouse.Pages
{
    public class ProductDeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public ProductDeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet(int id)
        {
            var product = _context.products.FirstOrDefault(b => b.Id == id);
            if (product != null)
            {
                _context.products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToPage("Products");
        }
    }
}
