using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class PassiveUse
    {
        public int Id { get; set; }
        [Display(Name = "Id")]
        public string UseName { get; set; }
        [Display(Name = "Название использования")]
        public int? Level { get; set; }
        [Display(Name = "Уровень")]
        public int? Item { get; set; }
        [Display(Name = "Предмет")]

        public virtual Item ItemNavigation { get; set; }
    }
}
