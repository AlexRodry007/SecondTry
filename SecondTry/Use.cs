using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class Use
    {
        public Use()
        {
            Conseqences = new HashSet<Conseqence>();
        }

        public int Id { get; set; }
        [Display(Name = "Id")]
        public string UseName { get; set; }
        [Display(Name = "Название использования")]
        public string Consumable { get; set; }
        [Display(Name = "Расходный материал")]
        public int? Item { get; set; }
        [Display(Name = "Предмет")]

        public virtual Item ItemNavigation { get; set; }
        public virtual ICollection<Conseqence> Conseqences { get; set; }
    }
}
