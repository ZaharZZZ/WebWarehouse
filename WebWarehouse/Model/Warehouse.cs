using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model
{
    public class Warehouse
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
