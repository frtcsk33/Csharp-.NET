using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirst3_cinema_örnek_.Models
{
    public partial class Actor
    {
        public Actor()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public int Id { get; set; }
        public string ActorName { get; set; }

        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
