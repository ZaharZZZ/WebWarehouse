using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace WebWarehouse.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }

        [Required]
        public int SupportedId { get; set; }

        public Suppliers Supplier { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

    }
}
