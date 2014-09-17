namespace GameDb.Entities
{
    using GameDb.Models;
    using System;
    using System.Data.Entity;

    public interface IGameContext
    {
        DbSet<ClosedQuestion> ClosedQuestions { get; set; }

        DbSet<OpenQuestion> OpenQuestions { get; set; }

        void SaveChanges();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
