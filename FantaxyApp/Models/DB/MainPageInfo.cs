using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class MainPageInfo
    {
        public int IdPlanet { get; set; }
        public string? Mptext { get; set; }
        public byte[]? Background { get; set; }

        public virtual Planet IdPlanetNavigation { get; set; } = null!;
    }
}
