using Microsoft.AspNetCore.Identity;
using System.Net.NetworkInformation;

namespace FantaxyApp.Models.DB
{
    public partial class GlobalParameters
    {
        public static string UserLogin { get; set; }
        public static string UserRole { get; set; }
    }
}
