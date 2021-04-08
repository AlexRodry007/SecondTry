using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace SecondTry
{
    public partial class Event
    {
        public Event()
        {
            Choices = new HashSet<Choice>();
        }

        public int Id { get; set; }
        [Display(Name = "ID")]
        public string EventName { get; set; }
        [Display(Name = "Название события")]
        public int? Safeness { get; set; }
        [Display(Name = "Безопасность")]
        public string Tile { get; set; }
        [Display(Name = "Клетка")]

        public virtual Tile TileNavigation { get; set; }
        public virtual ICollection<Choice> Choices { get; set; }
    }
}
