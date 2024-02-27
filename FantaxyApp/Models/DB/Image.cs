using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FantaxyApp.Models.DB
{
    public partial class Image
    {
        [Required(ErrorMessage = "Нет ID")]
        public string IdImage { get; set; }
        public byte[]? Images { get; set; }
    }
}
