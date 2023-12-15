using CodeCollabra.Domain;
using Microsoft.EntityFrameworkCore;

namespace CodeCollabra.Infrastructure.DatabaseContext
{
    public class CodeCollabraDBContext : DbContext
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
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CodeCollabraDBContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
