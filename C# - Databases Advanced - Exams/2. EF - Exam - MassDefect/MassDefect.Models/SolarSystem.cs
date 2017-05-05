﻿namespace MassDefect.Models
{
    using Microsoft.Build.Framework;
    using System.Collections.Generic;

    public class SolarSystem
    {
        public SolarSystem()
        {
            this.Stars = new HashSet<Star>();
            this.Planets = new HashSet<Planet>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Star> Stars { get; set; }

        public virtual ICollection<Planet> Planets { get; set; }
    }
}
