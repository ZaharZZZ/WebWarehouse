using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model
{
    public class Suppliers
    {
        public int Id { get; set; }

        public int Name { get; set; }

        [Required]
        public int ProductId { get; set; }
        
        public Product Product { get; set; }

        public int Quantity { get; set; }

    }
}
