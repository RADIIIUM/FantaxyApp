using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class News
    {
        public News()
        {
            NewsComments = new HashSet<NewsComment>();
            NewsStatuses = new HashSet<NewsStatus>();
        }

        public int IdNews { get; set; }
        public int? IdOwnerProfile { get; set; }
        public string? LoginOwner { get; set; }

        public virtual Profile? IdOwnerProfileNavigation { get; set; }
        public virtual User? LoginOwnerNavigation { get; set; }
        public virtual NewsInfo? NewsInfo { get; set; }
        public virtual ICollection<NewsComment> NewsComments { get; set; }
        public virtual ICollection<NewsStatus> NewsStatuses { get; set; }
    }
}
