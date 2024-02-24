using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PlanetProfile
    {
        public int IdPp { get; set; }
        public int? IdPlanet { get; set; }
        public int IdProfile { get; set; }

        public virtual Planet? IdPlanetNavigation { get; set; }
        public virtual Profile IdProfileNavigation { get; set; } = null!;
    }
}
