using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model
{
    public class Warehouse
    {
        public int Id { get; set; }
        
        public string Name_Warehouse { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("CategoryId")]
        public Product product { get; set; }
    }
}
