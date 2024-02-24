using System;
using System.Collections.Generic;

namespace FantaxyApp.Models.DB
{
    public partial class Comment
    {
        public int IdComment { get; set; }
        public int? IdOwnerProfile { get; set; }

        public virtual Profile? IdOwnerProfileNavigation { get; set; }
        public virtual CommentInfo? CommentInfo { get; set; }
        public virtual NewsComment? NewsComment { get; set; }
        public virtual PostCommentary? PostCommentary { get; set; }
    }
}
