namespace GameDb.Client
{
    using System.Linq;

    public interface IRepository <T>
    {
        IQueryable<T> All{ get; }

        void Insert(string name);

        bool Delete(string name);

        void Save();
    }
}