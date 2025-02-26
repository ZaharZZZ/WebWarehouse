using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
