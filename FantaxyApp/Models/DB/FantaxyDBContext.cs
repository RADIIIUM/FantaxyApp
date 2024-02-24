using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FantaxyApp.Models.DB
{
    public partial class FantaxyDBContext : DbContext
    {
        public FantaxyDBContext()
        {
        }

        public FantaxyDBContext(DbContextOptions<FantaxyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chat> Chats { get; set; } = null!;
        public virtual DbSet<ChatStatus> ChatStatuses { get; set; } = null!;
        public virtual DbSet<ChatsProfile> ChatsProfiles { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<CommentInfo> CommentInfos { get; set; } = null!;
        public virtual DbSet<Friend> Friends { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<MainPageInfo> MainPageInfos { get; set; } = null!;
        public virtual DbSet<MainReport> MainReports { get; set; } = null!;
        public virtual DbSet<News> News { get; set; } = null!;
        public virtual DbSet<NewsComment> NewsComments { get; set; } = null!;
        public virtual DbSet<NewsInfo> NewsInfos { get; set; } = null!;
        public virtual DbSet<NewsStatus> NewsStatuses { get; set; } = null!;
        public virtual DbSet<Planet> Planets { get; set; } = null!;
        public virtual DbSet<PlanetChat> PlanetChats { get; set; } = null!;
        public virtual DbSet<PlanetInfo> PlanetInfos { get; set; } = null!;
        public virtual DbSet<PlanetProfile> PlanetProfiles { get; set; } = null!;
        public virtual DbSet<PlanetProfileRole> PlanetProfileRoles { get; set; } = null!;
        public virtual DbSet<PlanetReport> PlanetReports { get; set; } = null!;
        public virtual DbSet<PlanetRole> PlanetRoles { get; set; } = null!;
        public virtual DbSet<PlanetStatus> PlanetStatuses { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<PostCommentary> PostCommentaries { get; set; } = null!;
        public virtual DbSet<PostsInfo> PostsInfos { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<ProfilesInfo> ProfilesInfos { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RolesUser> RolesUsers { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserChatBlocked> UserChatBlockeds { get; set; } = null!;
        public virtual DbSet<UserMessage> UserMessages { get; set; } = null!;
        public virtual DbSet<UserProfile> UserProfiles { get; set; } = null!;
        public virtual DbSet<UsersInfo> UsersInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NNBEJC9;Database=FantaxyDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chat>(entity =>
            {
                entity.HasKey(e => e.IdChat)
                    .HasName("PK__Chats__3817F38C036DB3E1");

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithMany(p => p.Chats)
                    .HasForeignKey(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Chats__IdProfile__6E01572D");
            });

            modelBuilder.Entity<ChatStatus>(entity =>
            {
                entity.HasKey(e => e.IdCs)
                    .HasName("PK__Chat_Sta__16EC97F6C9F99802");

                entity.ToTable("Chat_Statuses");

                entity.Property(e => e.IdCs).HasColumnName("Id_CS");

                entity.HasOne(d => d.IdChatNavigation)
                    .WithMany(p => p.ChatStatuses)
                    .HasForeignKey(d => d.IdChat)
                    .HasConstraintName("FK__Chat_Stat__IdCha__114A936A");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.ChatStatuses)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Chat_Stat__IdSta__10566F31");
            });

            modelBuilder.Entity<ChatsProfile>(entity =>
            {
                entity.HasKey(e => e.IdCp)
                    .HasName("PK__Chats_Pr__16EC97F1BA03BE68");

                entity.ToTable("Chats_Profiles");

                entity.Property(e => e.IdCp).HasColumnName("Id_CP");

                entity.HasOne(d => d.IdChatNavigation)
                    .WithMany(p => p.ChatsProfiles)
                    .HasForeignKey(d => d.IdChat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Chats_Pro__IdCha__70DDC3D8");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasKey(e => e.IdComment)
                    .HasName("PK__Comments__57C9AD58E68C1219");

                entity.HasOne(d => d.IdOwnerProfileNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdOwnerProfile)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Comments__IdOwne__5165187F");
            });

            modelBuilder.Entity<CommentInfo>(entity =>
            {
                entity.HasKey(e => e.IdComment)
                    .HasName("PK__CommentI__57C9AD581261F84D");

                entity.ToTable("CommentInfo");

                entity.Property(e => e.IdComment).ValueGeneratedNever();

                entity.Property(e => e.CommentText).HasMaxLength(2000);

                entity.HasOne(d => d.IdCommentNavigation)
                    .WithOne(p => p.CommentInfo)
                    .HasForeignKey<CommentInfo>(d => d.IdComment)
                    .HasConstraintName("FK__CommentIn__IdCom__5441852A");
            });

            modelBuilder.Entity<Friend>(entity =>
            {
                entity.HasKey(e => e.IdFriendship)
                    .HasName("PK__Friends__69F2FAA09CF65590");

                entity.HasOne(d => d.IdProfile1Navigation)
                    .WithMany(p => p.FriendIdProfile1Navigations)
                    .HasForeignKey(d => d.IdProfile1)
                    .HasConstraintName("FK__Friends__IdProfi__628FA481");

                entity.HasOne(d => d.IdProfile2Navigation)
                    .WithMany(p => p.FriendIdProfile2Navigations)
                    .HasForeignKey(d => d.IdProfile2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Friends__IdProfi__6383C8BA");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.IdImage)
                    .HasName("PK__Images__C8C63E4AA7C03B80");

                entity.Property(e => e.IdImage).ValueGeneratedNever();
            });

            modelBuilder.Entity<MainPageInfo>(entity =>
            {
                entity.HasKey(e => e.IdPlanet)
                    .HasName("PK__MainPage__12FD4B3557EBCD1B");

                entity.ToTable("MainPageInfo");

                entity.Property(e => e.IdPlanet).ValueGeneratedNever();

                entity.Property(e => e.Mptext).HasColumnName("MPText");

                entity.HasOne(d => d.IdPlanetNavigation)
                    .WithOne(p => p.MainPageInfo)
                    .HasForeignKey<MainPageInfo>(d => d.IdPlanet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MainPageI__IdPla__0D7A0286");
            });

            modelBuilder.Entity<MainReport>(entity =>
            {
                entity.HasKey(e => e.IdReport)
                    .HasName("PK__MainRepo__46F9D6CE533141DB");

                entity.ToTable("MainReport");

                entity.Property(e => e.LoginUser).HasMaxLength(50);

                entity.Property(e => e.TextReport).HasMaxLength(2000);

                entity.HasOne(d => d.LoginUserNavigation)
                    .WithMany(p => p.MainReports)
                    .HasForeignKey(d => d.LoginUser)
                    .HasConstraintName("FK__MainRepor__Login__236943A5");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasKey(e => e.IdNews)
                    .HasName("PK__News__4559C72D6E9B7808");

                entity.Property(e => e.LoginOwner).HasMaxLength(50);

                entity.HasOne(d => d.IdOwnerProfileNavigation)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.IdOwnerProfile)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__News__IdOwnerPro__4AB81AF0");

                entity.HasOne(d => d.LoginOwnerNavigation)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.LoginOwner)
                    .HasConstraintName("FK__News__LoginOwner__4BAC3F29");
            });

            modelBuilder.Entity<NewsComment>(entity =>
            {
                entity.HasKey(e => e.IdComment)
                    .HasName("PK__News_Com__57C9AD5800FD346E");

                entity.ToTable("News_Comments");

                entity.Property(e => e.IdComment).ValueGeneratedNever();

                entity.HasOne(d => d.IdCommentNavigation)
                    .WithOne(p => p.NewsComment)
                    .HasForeignKey<NewsComment>(d => d.IdComment)
                    .HasConstraintName("FK__News_Comm__IdCom__66603565");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__News_Comm__IdNew__6754599E");
            });

            modelBuilder.Entity<NewsInfo>(entity =>
            {
                entity.HasKey(e => e.IdNews)
                    .HasName("PK__NewsInfo__4559C72D965D87CD");

                entity.ToTable("NewsInfo");

                entity.Property(e => e.IdNews).ValueGeneratedNever();

                entity.Property(e => e.DateNews).HasColumnType("date");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithOne(p => p.NewsInfo)
                    .HasForeignKey<NewsInfo>(d => d.IdNews)
                    .HasConstraintName("FK__NewsInfo__IdNews__4E88ABD4");
            });

            modelBuilder.Entity<NewsStatus>(entity =>
            {
                entity.HasKey(e => e.IdNs)
                    .HasName("PK__News_Sta__16ECEE8FC2E5C94E");

                entity.ToTable("News_Statuses");

                entity.Property(e => e.IdNs).HasColumnName("Id_NS");

                entity.HasOne(d => d.IdNewsNavigation)
                    .WithMany(p => p.NewsStatuses)
                    .HasForeignKey(d => d.IdNews)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__News_Stat__IdNew__02FC7413");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.NewsStatuses)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__News_Stat__IdSta__02084FDA");
            });

            modelBuilder.Entity<Planet>(entity =>
            {
                entity.HasKey(e => e.IdPlanet)
                    .HasName("PK__Planets__12FD4B3505403AFA");

                entity.Property(e => e.Curator).HasMaxLength(50);

                entity.Property(e => e.LoginOwner).HasMaxLength(50);

                entity.HasOne(d => d.CuratorNavigation)
                    .WithMany(p => p.PlanetCuratorNavigations)
                    .HasForeignKey(d => d.Curator)
                    .HasConstraintName("FK__Planets__Curator__74AE54BC");

                entity.HasOne(d => d.LoginOwnerNavigation)
                    .WithMany(p => p.PlanetLoginOwnerNavigations)
                    .HasForeignKey(d => d.LoginOwner)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Planets__LoginOw__73BA3083");
            });

            modelBuilder.Entity<PlanetChat>(entity =>
            {
                entity.HasKey(e => e.IdChat)
                    .HasName("PK__Planet_C__A99B11797BD72211");

                entity.ToTable("Planet_Chats");

                entity.Property(e => e.IdChat)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_Chat");

                entity.HasOne(d => d.IdChatNavigation)
                    .WithOne(p => p.PlanetChat)
                    .HasForeignKey<PlanetChat>(d => d.IdChat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Planet_Ch__Id_Ch__05D8E0BE");

                entity.HasOne(d => d.IdPlanetNavigation)
                    .WithMany(p => p.PlanetChats)
                    .HasForeignKey(d => d.IdPlanet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Planet_Ch__IdPla__06CD04F7");
            });

            modelBuilder.Entity<PlanetInfo>(entity =>
            {
                entity.HasKey(e => e.IdPlanet)
                    .HasName("PK__PlanetIn__12FD4B35B96E7259");

                entity.ToTable("PlanetInfo");

                entity.Property(e => e.IdPlanet).ValueGeneratedNever();

                entity.Property(e => e.PlanetName).HasMaxLength(50);

                entity.HasOne(d => d.IdPlanetNavigation)
                    .WithOne(p => p.PlanetInfo)
                    .HasForeignKey<PlanetInfo>(d => d.IdPlanet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlanetInf__IdPla__778AC167");
            });

            modelBuilder.Entity<PlanetProfile>(entity =>
            {
                entity.HasKey(e => e.IdPp)
                    .HasName("PK__Planet_P__16EC7841D51F9D19");

                entity.ToTable("Planet_Profiles");

                entity.Property(e => e.IdPp).HasColumnName("Id_PP");

                entity.HasOne(d => d.IdPlanetNavigation)
                    .WithMany(p => p.PlanetProfiles)
                    .HasForeignKey(d => d.IdPlanet)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Planet_Pr__IdPla__14270015");

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithMany(p => p.PlanetProfiles)
                    .HasForeignKey(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Planet_Pr__IdPro__151B244E");
            });

            modelBuilder.Entity<PlanetProfileRole>(entity =>
            {
                entity.HasKey(e => e.IdPr);

                entity.ToTable("Planet_Profile_Role");

                entity.Property(e => e.IdPr)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_PR");

                entity.HasOne(d => d.IdPlanetNavigation)
                    .WithMany(p => p.PlanetProfileRoles)
                    .HasForeignKey(d => d.IdPlanet)
                    .HasConstraintName("FK_Planet_Profile_Role_Planets");

                entity.HasOne(d => d.IdPlanetRoleNavigation)
                    .WithMany(p => p.PlanetProfileRoles)
                    .HasForeignKey(d => d.IdPlanetRole)
                    .HasConstraintName("FK_Planet_Profile_Role_PlanetRole");

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithMany(p => p.PlanetProfileRoles)
                    .HasForeignKey(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Planet_Profile_Role_Profiles");
            });

            modelBuilder.Entity<PlanetReport>(entity =>
            {
                entity.HasKey(e => e.IdReport)
                    .HasName("PK__PlanetRe__46F9D6CEF9E93560");

                entity.ToTable("PlanetReport");

                entity.Property(e => e.TextReport).HasMaxLength(2000);

                entity.HasOne(d => d.IdPlanetNavigation)
                    .WithMany(p => p.PlanetReports)
                    .HasForeignKey(d => d.IdPlanet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlanetRep__IdPla__2739D489");

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithMany(p => p.PlanetReports)
                    .HasForeignKey(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlanetRep__IdPro__2645B050");
            });

            modelBuilder.Entity<PlanetRole>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.ToTable("PlanetRole");

                entity.Property(e => e.IdRole).ValueGeneratedNever();

                entity.Property(e => e.Role).HasMaxLength(50);
            });

            modelBuilder.Entity<PlanetStatus>(entity =>
            {
                entity.HasKey(e => e.IdPs)
                    .HasName("PK__Planet_S__16EC78BCF55AA328");

                entity.ToTable("Planet_Statuses");

                entity.Property(e => e.IdPs).HasColumnName("Id_PS");

                entity.HasOne(d => d.IdPlanetNavigation)
                    .WithMany(p => p.PlanetStatuses)
                    .HasForeignKey(d => d.IdPlanet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Planet_St__IdPla__7B5B524B");

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.PlanetStatuses)
                    .HasForeignKey(d => d.IdStatus)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Planet_St__IdSta__7A672E12");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.IdPost)
                    .HasName("PK__Posts__F8DCBD4DADD5A14D");

                entity.HasOne(d => d.IdOwnerProfileNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.IdOwnerProfile)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Posts__IdOwnerPr__571DF1D5");
            });

            modelBuilder.Entity<PostCommentary>(entity =>
            {
                entity.HasKey(e => e.IdComment)
                    .HasName("PK__Post_Com__57C9AD5868A42E51");

                entity.ToTable("Post_Commentaries");

                entity.Property(e => e.IdComment).ValueGeneratedNever();

                entity.HasOne(d => d.IdCommentNavigation)
                    .WithOne(p => p.PostCommentary)
                    .HasForeignKey<PostCommentary>(d => d.IdComment)
                    .HasConstraintName("FK__Post_Comm__IdCom__5EBF139D");

                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany(p => p.PostCommentaries)
                    .HasForeignKey(d => d.IdPost)
                    .HasConstraintName("FK__Post_Comm__IdPos__5FB337D6");
            });

            modelBuilder.Entity<PostsInfo>(entity =>
            {
                entity.HasKey(e => e.IdPost)
                    .HasName("PK__PostsInf__F8DCBD4D0F1717C6");

                entity.ToTable("PostsInfo");

                entity.Property(e => e.IdPost).ValueGeneratedNever();

                entity.Property(e => e.PostDate).HasColumnType("date");

                entity.Property(e => e.PostText).HasMaxLength(2000);

                entity.HasOne(d => d.IdPostNavigation)
                    .WithOne(p => p.PostsInfo)
                    .HasForeignKey<PostsInfo>(d => d.IdPost)
                    .HasConstraintName("FK__PostsInfo__IdPos__59FA5E80");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.IdProfile)
                    .HasName("PK__Profiles__120435C1ED4F9C5E");

                entity.Property(e => e.UserLogin).HasMaxLength(50);

                entity.HasOne(d => d.UserLoginNavigation)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.UserLogin)
                    .HasConstraintName("FK__Profiles__UserLo__403A8C7D");
            });

            modelBuilder.Entity<ProfilesInfo>(entity =>
            {
                entity.HasKey(e => e.IdProfile)
                    .HasName("PK__Profiles__120435C1768A50A3");

                entity.ToTable("ProfilesInfo");

                entity.Property(e => e.IdProfile).ValueGeneratedNever();

                entity.Property(e => e.ProfileName).HasMaxLength(40);

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithOne(p => p.ProfilesInfo)
                    .HasForeignKey<ProfilesInfo>(d => d.IdProfile)
                    .HasConstraintName("FK__ProfilesI__IdPro__4316F928");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__Roles__B4369054AC5E6462");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<RolesUser>(entity =>
            {
                entity.HasKey(e => e.IdRp)
                    .HasName("PK__Roles_Us__16EC080348AA881E");

                entity.ToTable("Roles_Users");

                entity.Property(e => e.IdRp).HasColumnName("Id_RP");

                entity.Property(e => e.UserLogin).HasMaxLength(50);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.RolesUsers)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK__Roles_Use__IdRol__0A9D95DB");

                entity.HasOne(d => d.UserLoginNavigation)
                    .WithMany(p => p.RolesUsers)
                    .HasForeignKey(d => d.UserLogin)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Roles_Use__UserL__09A971A2");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus)
                    .HasName("PK__Statuses__B450643A2E980C89");

                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserLogin)
                    .HasName("PK__Users__7F8E8D5F4B68B7AF");

                entity.Property(e => e.UserLogin).HasMaxLength(50);

                entity.Property(e => e.UserEmail).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(50);
            });

            modelBuilder.Entity<UserChatBlocked>(entity =>
            {
                entity.HasKey(e => e.ProfileBlocked)
                    .HasName("PK__UserChat__3773DE3B9EA9DE40");

                entity.ToTable("UserChatBlocked");

                entity.Property(e => e.ProfileBlocked).ValueGeneratedNever();

                entity.HasOne(d => d.IdChatNavigation)
                    .WithMany(p => p.UserChatBlockeds)
                    .HasForeignKey(d => d.IdChat)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__UserChatB__IdCha__208CD6FA");

                entity.HasOne(d => d.ProfileBlockedNavigation)
                    .WithOne(p => p.UserChatBlocked)
                    .HasForeignKey<UserChatBlocked>(d => d.ProfileBlocked)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserChatB__Profi__1F98B2C1");
            });

            modelBuilder.Entity<UserMessage>(entity =>
            {
                entity.HasKey(e => e.IdMessage)
                    .HasName("PK__UserMess__47AAF304F578F482");

                entity.Property(e => e.MessageText).HasMaxLength(2000);

                entity.HasOne(d => d.IdChatNavigation)
                    .WithMany(p => p.UserMessages)
                    .HasForeignKey(d => d.IdChat)
                    .HasConstraintName("FK__UserMessa__IdCha__18EBB532");

                entity.HasOne(d => d.ProfileSenderNavigation)
                    .WithMany(p => p.UserMessages)
                    .HasForeignKey(d => d.ProfileSender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserMessa__Profi__17F790F9");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.IdProfile)
                    .HasName("PK__User_Pro__120435C1D19EEF13");

                entity.ToTable("User_Profiles");

                entity.Property(e => e.IdProfile).ValueGeneratedNever();

                entity.Property(e => e.LoginUser).HasMaxLength(50);

                entity.HasOne(d => d.IdProfileNavigation)
                    .WithOne(p => p.UserProfile)
                    .HasForeignKey<UserProfile>(d => d.IdProfile)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Prof__IdPro__6A30C649");

                entity.HasOne(d => d.LoginUserNavigation)
                    .WithMany(p => p.UserProfiles)
                    .HasForeignKey(d => d.LoginUser)
                    .HasConstraintName("FK__User_Prof__Login__6B24EA82");
            });

            modelBuilder.Entity<UsersInfo>(entity =>
            {
                entity.HasKey(e => e.UserLogin)
                    .HasName("PK__UsersInf__7F8E8D5F6B763AA2");

                entity.ToTable("UsersInfo");

                entity.Property(e => e.UserLogin).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(40);

                entity.HasOne(d => d.UserLoginNavigation)
                    .WithOne(p => p.UsersInfo)
                    .HasForeignKey<UsersInfo>(d => d.UserLogin)
                    .HasConstraintName("FK__UsersInfo__UserL__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
