using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class MapX
    {
        public MapX()
        {
            Paths = new HashSet<Path>();
        }

        [Display(Name = "YX")]
        public string YX { get; set; }
        [Display(Name = "Y")]
        public int? Y { get; set; }
        [Display(Name = "X")]
        public int? X { get; set; }

        public virtual MapY YNavigation { get; set; }
        public virtual Tile Tile { get; set; }
        public virtual ICollection<Path> Paths { get; set; }
    }
}
