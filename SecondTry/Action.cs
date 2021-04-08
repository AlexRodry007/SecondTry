using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class Action
    {
        public int ActionValue { get; set; }
        [Display(Name = "Значение действия")]
        public string ActionName { get; set; }
        [Display(Name = "Название действия")]
        public int? Tactic { get; set; }
        [Display(Name = "Тактика")]

        public virtual Tactic TacticNavigation { get; set; }
    }
}
