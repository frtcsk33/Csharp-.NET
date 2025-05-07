using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirst3_cinema_örnek_.Models
{
    public partial class MovieActor
    {
        public int FilmId { get; set; }
        public int ActorId { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Film Film { get; set; }
    }
}
