using System;
using FantaxyApp.Models.DB;

namespace FantaxyApp.Models
{
    public class ProfileModel
    {
        public IEnumerable<User> info { get; set; }
        public IEnumerable<UsersInfo> us { get; set; }
    }
}
