
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FantaxyApp.Models.DB
{
    public partial class User
    {
        public User()
        {
            MainReports = new HashSet<MainReport>();
            News = new HashSet<News>();
            PlanetCuratorNavigations = new HashSet<Planet>();
            PlanetLoginOwnerNavigations = new HashSet<Planet>();
            Profiles = new HashSet<Profile>();
            RolesUsers = new HashSet<RolesUser>();
            UserProfiles = new HashSet<UserProfile>();
        }

        [Required(ErrorMessage = "Логин не должен быть пустым")]
        [StringLength(32,ErrorMessage = "Макс. размер логина 32")]
        [Display(Name = "Логин")]
        public string UserLogin { get; set; } = null!;

        [Required(ErrorMessage = "Пароль не должен быть пустым")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Мин. размер пароля: 6")]
        [Display(Name = "Пароль")]
        public string UserPassword { get; set; } = null!;

        [Required(ErrorMessage = "Email не должен быть пустым")]
        [EmailAddress(ErrorMessage = "Неверный формат Email")]
        [Display(Name = "Email")]
        public string UserEmail { get; set; } = null!;

        public virtual UsersInfo? UsersInfo { get; set; }
        public virtual ICollection<MainReport> MainReports { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Planet> PlanetCuratorNavigations { get; set; }
        public virtual ICollection<Planet> PlanetLoginOwnerNavigations { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<RolesUser> RolesUsers { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
