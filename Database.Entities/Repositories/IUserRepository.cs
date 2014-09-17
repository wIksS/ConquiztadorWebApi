namespace GameDb.Entities.Repositories
{
    using GameDb.Models;
    using System.Collections.Generic;
    using System.Linq;

    public interface IUserRepository : IRepository
    {
        IQueryable All { get; }

        bool UpdateResult(string name, int result);

        bool UpdatePassword(string name, string password);

        void InsertAll(IEnumerable<User> users);

        void Insert(string name);

        bool Delete(string name);

        void Save();
    }
}