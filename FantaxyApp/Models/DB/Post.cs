using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Post
    {
        public Post()
        {
            PostCommentaries = new HashSet<PostCommentary>();
        }

        public int IdPost { get; set; }
        public int? IdOwnerProfile { get; set; }

        public virtual Profile? IdOwnerProfileNavigation { get; set; }
        public virtual PostsInfo? PostsInfo { get; set; }
        public virtual ICollection<PostCommentary> PostCommentaries { get; set; }
    }
}
