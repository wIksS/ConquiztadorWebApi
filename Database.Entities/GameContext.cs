namespace GameDb.Entities
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using GameDb.Models;
    using GameDb.Entities.Migrations;

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