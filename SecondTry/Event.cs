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

        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Название события")]
        public string EventName { get; set; }
        [Display(Name = "Безопасность")]
        public int? Safeness { get; set; }
        [Display(Name = "Клетка")]
        public string Tile { get; set; }

        public virtual Tile TileNavigation { get; set; }
        public virtual ICollection<Choice> Choices { get; set; }
    }
}
