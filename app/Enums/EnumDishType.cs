using System.ComponentModel.DataAnnotations;

namespace app.Enums
{
    public enum EnumDishType
    {
        [Display(Name = "Первое")]
        FirstDish,
        [Display(Name = "Второе")]
        SecondDish,
        [Display(Name = "Десерт")]
        Desert,
        [Display(Name = "Напиток")]
        Drink,
        [Display(Name = "Другое")]
        Other
    }
}
