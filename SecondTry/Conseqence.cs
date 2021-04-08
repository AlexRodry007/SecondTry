using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace SecondTry
{
    public partial class Conseqence
    {
        public string ConsName { get; set; }
        [Display(Name = "Название последствия")]
        public int? ConsValue { get; set; }
        [Display(Name = "Значение последствия")]
        public int? ItemUse { get; set; }
        [Display(Name = "Использование предмета")]
        public int? UseName { get; set; }
        [Display(Name = "Название использование")]
        public int? Choise { get; set; }
        [Display(Name = "Выбор")]

        public virtual Choice ChoiseNavigation { get; set; }
        public virtual Use UseNameNavigation { get; set; }
    }
}
