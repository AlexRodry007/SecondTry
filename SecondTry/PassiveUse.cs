using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class PassiveUse
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Название использования")]
        public string UseName { get; set; }
        [Display(Name = "Уровень")]
        public int? Level { get; set; }
        [Display(Name = "Предмет")]
        public int? Item { get; set; }

        public virtual Item ItemNavigation { get; set; }
    }
}
