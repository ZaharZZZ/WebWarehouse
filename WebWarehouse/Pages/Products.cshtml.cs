using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebWarehouse.Data;
using WebWarehouse.Model;
using static System.Reflection.Metadata.BlobBuilder;

namespace WebWarehouse.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ProductsModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Product> Products { get; set; }
        public void OnGet()
        {

        }
    }
}
