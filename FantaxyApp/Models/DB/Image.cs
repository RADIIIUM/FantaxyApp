using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Image
    {
        public int IdImage { get; set; }
        public byte[]? Images { get; set; }
    }
}
