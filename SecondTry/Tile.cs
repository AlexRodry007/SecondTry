using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SecondTry
{
    public partial class Tile
    {
        public Tile()
        {
            Events = new HashSet<Event>();
        }

        public string Coords { get; set; }
        [Display(Name = "Координаты")]
        public int? Id { get; set; }
        [Display(Name = "Id")]
        public string TileName { get; set; }
        [Display(Name = "Название клетки")]
        public int? Length { get; set; }
        [Display(Name = "Длина")]

        public virtual MapX CoordsNavigation { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
