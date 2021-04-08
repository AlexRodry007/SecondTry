using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class Action
    {
        [Display(Name = "Значение действия")]
        public int ActionValue { get; set; }
        [Display(Name = "Название действия")]
        public string ActionName { get; set; }
        [Display(Name = "Тактика")]
        public int? Tactic { get; set; }

        public virtual Tactic TacticNavigation { get; set; }
    }
}
