using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PlanetInfo
    {
        public int IdPlanet { get; set; }
        public string PlanetName { get; set; } = null!;
        public string? Desciption { get; set; }
        public byte[] Avatar { get; set; } = null!;
        public byte[]? MainBackground { get; set; }
        public byte[]? SecondBackground { get; set; }

        public virtual Planet IdPlanetNavigation { get; set; } = null!;
    }
}
