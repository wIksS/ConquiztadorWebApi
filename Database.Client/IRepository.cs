namespace Database.Client
{
    using System.Linq;

    public interface IRepository
    {
        IQueryable All{ get; }

        void Insert(string name);

        bool Delete(string name);

        void Save();
    }
}