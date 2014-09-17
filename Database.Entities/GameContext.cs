namespace GameDb.Entities
{
    using GameDb.Entities.Migrations;
    using GameDb.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class GameContext : IdentityDbContext<User>
    {
        public GameContext()
            : base("GameContext", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GameContext, Configuration>());
        }

        public static GameContext Create()
        {
            return new GameContext();
        }



        public DbSet<ClosedQuestion> ClosedQuestions { get; set; }

        public DbSet<OpenQuestion> OpenQuestions { get; set; }

    }
}
