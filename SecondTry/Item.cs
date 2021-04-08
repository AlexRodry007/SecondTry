using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace SecondTry
{
    public partial class Item
    {
        public Item()
        {
            Characters = new HashSet<Character>();
            PassiveUses = new HashSet<PassiveUse>();
            Uses = new HashSet<Use>();
        }

        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Название предмета")]
        public string ItemName { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Масса")]
        public int? Mass { get; set; }
        [Display(Name = "Объём")]
        public int? Volume { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<PassiveUse> PassiveUses { get; set; }
        public virtual ICollection<Use> Uses { get; set; }
    }
}
