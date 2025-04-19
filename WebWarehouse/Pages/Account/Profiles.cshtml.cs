using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebWarehouse.Data;
using WebWarehouse.Model.AuthApp;

namespace WebWarehouse.Pages.Account
{
    [Authorize(Roles = "Admin")]
    public class ProfilesModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        public ProfilesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<AuthUser> Users { get; set; } = new();

        public void OnGet()
        {
            Users = _context.AuthUsers.ToList();
        }

    }
}
