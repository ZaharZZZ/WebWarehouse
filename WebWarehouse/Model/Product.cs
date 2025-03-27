using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace WebWarehouse.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Указана категория продукта")]
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }

        [Required(ErrorMessage ="Не введён поставщик")]
        public int SupplierId { get; set; }

        public Сounterparty Supplier { get; set; }

        [Required(ErrorMessage = "Укажите название продукта")]
        [StringLength(255)]
        public string Name { get; set; }

        public int Quantity { get; set; }

        [Range (0, 99999.99,ErrorMessage ="Не корректная цена продукта")]
        public int Price { get; set; }

    }
}
