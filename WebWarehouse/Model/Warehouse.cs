using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model
{
    public class Warehouse
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Укажите имя склада")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите название продукта")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Укажите название продукта")]
        [StringLength(255)]
        public Product Product { get; set; }
    }
}
