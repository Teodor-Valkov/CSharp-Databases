﻿namespace PhotographyWorkshops.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Validations;

    public class Camera
    {
        public Camera()
        {
            this.PrimaryCamerasPhotographers = new HashSet<Photographer>();
            this.SecondaryCamerasPhotographers = new HashSet<Photographer>();
        }

        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public bool IsFullFrameOrNot { get; set; }

        [Required]
        [MinValue]
        //[Range(100, int.MaxValue)]
        public int MinIso { get; set; }

        public int MaxIso { get; set; }

        [InverseProperty("PrimaryCamera")]
        public virtual ICollection<Photographer> PrimaryCamerasPhotographers { get; set; }

        [InverseProperty("SecondaryCamera")]
        public virtual ICollection<Photographer> SecondaryCamerasPhotographers { get; set; }
    }
}