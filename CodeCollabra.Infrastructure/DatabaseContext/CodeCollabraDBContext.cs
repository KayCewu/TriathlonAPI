﻿using CodeCollabra.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeCollabra.Infrastructure.DatabaseContext
{
    public class CodeCollabraDBContext : IdentityDbContext<ApplicationUser>
    {
        public CodeCollabraDBContext(DbContextOptions<CodeCollabraDBContext> options) : base(options)
        {

        }

        public DbSet<Achievements> Achievements { get; set; }
        public DbSet<ActivityHistory> ActivityHistory { get; set; }
        public DbSet<Badges> Badges { get; set; }
        public DbSet<Chat> chats { get; set; }
        public DbSet<ChatGptResponse> ChatGptResponses { get; set; }
        public DbSet<ChatGptSessions> ChatGptSessions { get; set; }
        public DbSet<ChatParticipantBadges> ChatParticipantBadges { get; set; }
        public DbSet<ChatParticipants> ChatParticipants { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Points> Points { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public new DbSet<User> Users { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CodeCollabraDBContext).Assembly);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
            .HasOne(u => u.ApplicationUser)
            .WithMany()
            .HasForeignKey(u => u.ApplicationUserId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
