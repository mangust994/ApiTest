﻿using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Genre : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<CompositionGenre> CompositionGenres { get; set; }
        public Genre()
        {
            CompositionGenres = new List<CompositionGenre>();
        }
    }
}
