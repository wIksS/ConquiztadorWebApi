namespace Database.Entities
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Database.Models;
    using Database.Entities.Migrations;

    public class GameContext : DbContext
    {
        public GameContext()
            : base("name=GameContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GameContext, Configuration>());
        }

        public DbSet<User> Users { get; set; }

        public DbSet<ClosedQuestion> ClosedQuestions { get; set; }

        public DbSet<OpenQuestion> OpenQuestions { get; set; }
    }
}