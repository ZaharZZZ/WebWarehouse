using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model
{
    public class Suppliers
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Укажите название поставщика")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Укажите название продукта")]
        [StringLength(255)]
        public Product Product { get; set; }

        public int Quantity { get; set; }

    }
}
