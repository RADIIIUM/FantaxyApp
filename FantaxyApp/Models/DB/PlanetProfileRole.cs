using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class PlanetProfileRole
    {
        public int IdPr { get; set; }
        public int? IdPlanetRole { get; set; }
        public int? IdProfile { get; set; }
        public int? IdPlanet { get; set; }

        public virtual Planet? IdPlanetNavigation { get; set; }
        public virtual PlanetRole? IdPlanetRoleNavigation { get; set; }
        public virtual Profile? IdProfileNavigation { get; set; }
    }
}
