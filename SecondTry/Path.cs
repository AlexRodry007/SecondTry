using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class Path
    {
        public Path()
        {
            Hikes = new HashSet<Hike>();
        }

        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Координаты")]
        public string Coords { get; set; }

        public virtual MapX CoordsNavigation { get; set; }
        public virtual Hike IdNavigation { get; set; }
        public virtual ICollection<Hike> Hikes { get; set; }
    }
}
