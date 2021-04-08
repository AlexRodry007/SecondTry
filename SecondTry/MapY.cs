using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class MapY
    {
        public MapY()
        {
            MapXes = new HashSet<MapX>();
        }

        public int Y { get; set; }
        [Display(Name = "Y")]

        public virtual ICollection<MapX> MapXes { get; set; }
    }
}
