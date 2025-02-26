using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model
{
    public class Suppliers
    {
        public int Id { get; set; }

        public int name_Supplier { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("CategoryId")]
        public Product product { get; set; }

        public int Quantity { get; set; }

    }
}
