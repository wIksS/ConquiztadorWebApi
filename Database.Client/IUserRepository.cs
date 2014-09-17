namespace GameDb.Client
{
    using System.Linq;

    public interface IUserRepository : IRepository
    {
        IQueryable All{ get; }

        bool UpdateResult(string name, int result);

        bool UpdatePassword(string name, string password);

        void Insert(string name);

        bool Delete(string name);

        void Save();
    }
}