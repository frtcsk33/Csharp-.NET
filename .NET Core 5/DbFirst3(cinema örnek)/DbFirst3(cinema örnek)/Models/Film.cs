﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DbFirst3_cinema_örnek_.Models
{
    public partial class Film
    {
        public Film()
        {
            MovieActors = new HashSet<MovieActor>();
        }

        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public int DirectorId { get; set; }
        public int CategoryId { get; set; }
        public DateTime? Date { get; set; }
        public string MovieDetails { get; set; }

        public virtual Category Category { get; set; }
        public virtual Director Director { get; set; }
        public virtual ICollection<MovieActor> MovieActors { get; set; }
    }
}
