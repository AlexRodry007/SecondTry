using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace SecondTry
{
    public partial class Fight
    {
        public Fight()
        {
            Tactics = new HashSet<Tactic>();
        }

        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Выборы")]
        public int? Choises { get; set; }
        [Display(Name = "Очки действий")]
        public int? ActionPoints { get; set; }
        [Display(Name = "Раунд")]
        public int? Round { get; set; }
        [Display(Name = "Критическое состояние")]
        public int? CritStatus { get; set; }

        public virtual Choice ChoisesNavigation { get; set; }
        public virtual ICollection<Tactic> Tactics { get; set; }
    }
}
