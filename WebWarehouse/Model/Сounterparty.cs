using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebWarehouse.Model
{
    public class Сounterparty
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите логин пользователя")]
        [StringLength(255)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Введите пароль пользователя")]
        [StringLength(255)]
        public string Password { get; set; }

        [Required(ErrorMessage ="Укажите название организации")]
        [StringLength(255)]
        public string NameOrg { get; set; }    
        

        enum Сounterparties
        {
            Поставщик,
            Покупатель,
            Поставщик_Покупатель
        }
    }
}
