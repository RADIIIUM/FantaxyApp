using FantaxyApp.Models.DB;
using Microsoft.AspNetCore.Identity;
using System.Net.NetworkInformation;

namespace FantaxyApp.Models
{
    public partial class GlobalParameters
    {
        public static User Users { get; set; }
        public static UsersInfo UserInfo { get; set; }
        public static string UserRole { get; set; }
    }
}
