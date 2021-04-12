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

        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Событие")]
        public int? Event { get; set; }

        public virtual Event EventNavigation { get; set; }
        public virtual ICollection<Conseqence> Conseqences { get; set; }
        public virtual ICollection<Fight> Fights { get; set; }
    }
}
