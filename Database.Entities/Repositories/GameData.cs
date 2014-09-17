namespace GameDb.Entities.Repositories
{
    using GameDb.Models;
    using System;
    using System.Collections.Generic;

    public class GameData : IGameData
    {
        private IGameContext context;
        private IDictionary<Type, object> repositories;

        public GameData()
            : this(new GameContext())
        {
        }

        public GameData(IGameContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }

        public IRepository<OpenQuestion> OpenQuestions
        {
            get
            {
                return this.GetRepository<OpenQuestion>();
            }
        }

        public IRepository<ClosedQuestion> ClosedQuestions
        {
            get
            {
                return this.GetRepository<ClosedQuestion>();
            }
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(Repository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeOfModel];
        }
    }
}
