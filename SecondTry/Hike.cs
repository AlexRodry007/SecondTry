using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace SecondTry
{
    public partial class Hike
    {
        public Hike()
        {
            Characters = new HashSet<Character>();
        }
        //Test change
       // [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Название похода")]
        public string HikeName { get; set; }
        [Display(Name = "Путь")]
        public int? Path { get; set; }

        public virtual Path PathNavigation { get; set; }
        public virtual Path Path1 { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}
