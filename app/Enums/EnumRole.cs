using System.ComponentModel.DataAnnotations;

namespace app.Enums
{
    public enum EnumRole
    {
        [Display(Name = "Администратор")]
        Admin,
        [Display(Name = "Кассир")]
        Cashier,
        [Display(Name = "Повар")]
        Chef
    }
}
