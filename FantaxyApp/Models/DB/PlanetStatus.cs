using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PlanetStatus
    {
        public int IdPs { get; set; }
        public int? IdStatus { get; set; }
        public int IdPlanet { get; set; }

        public virtual Planet IdPlanetNavigation { get; set; } = null!;
        public virtual Status? IdStatusNavigation { get; set; }
    }
}
