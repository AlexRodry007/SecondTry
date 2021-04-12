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

        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Название использования")]
        public string UseName { get; set; }
        [Display(Name = "Расходный материал")]
        public string Consumable { get; set; }
        [Display(Name = "Предмет")]
        public int? Item { get; set; }

        public virtual Item ItemNavigation { get; set; }
        public virtual ICollection<Conseqence> Conseqences { get; set; }
    }
}
