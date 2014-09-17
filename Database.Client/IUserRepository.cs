namespace Database.Client
{
    using System.Linq;

    public interface IUserRepository
    {
        IQueryable All{ get; }

        void InsertOrUpdate(string name, string password, int result);

        bool Delete(string name);

        void Save();
    }
}