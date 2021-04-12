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

        [Display(Name = "Y")]
        public int Y { get; set; }

        public virtual ICollection<MapX> MapXes { get; set; }
    }
}
