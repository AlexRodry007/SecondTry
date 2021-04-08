﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#nullable disable

namespace SecondTry
{
    public partial class Tactic
    {
        public Tactic()
        {
            Actions = new HashSet<Action>();
            Characters = new HashSet<Character>();
        }

        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Название тактики")]
        public string TacticName { get; set; }
        [Display(Name = "Значение тактики")]
        public string TacticValue { get; set; }
        [Display(Name = "Бой")]
        public int? Fight { get; set; }

        public virtual Fight FightNavigation { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}
