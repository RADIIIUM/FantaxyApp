using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PlanetReport
    {
        public int IdReport { get; set; }
        public string TextReport { get; set; } = null!;
        public int IdProfile { get; set; }
        public int IdPlanet { get; set; }

        public virtual Planet IdPlanetNavigation { get; set; } = null!;
        public virtual Profile IdProfileNavigation { get; set; } = null!;
    }
}
