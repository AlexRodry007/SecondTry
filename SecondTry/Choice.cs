using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class Choice
    {
        public Choice()
        {
            Conseqences = new HashSet<Conseqence>();
            Fights = new HashSet<Fight>();
        }

        public int Id { get; set; }
        [Display(Name = "ID")]
        public string Description { get; set; }
        [Display(Name = "Описание")]
        public int? Event { get; set; }
        [Display(Name = "Событие")]

        public virtual Event EventNavigation { get; set; }
        public virtual ICollection<Conseqence> Conseqences { get; set; }
        public virtual ICollection<Fight> Fights { get; set; }
    }
}
