namespace Database.Client
{
    using System.Linq;

    public interface IClosedQuestionRepository : IRepository
    {
        IQueryable All{ get; }

        void Insert(string name);

        bool Delete(string name);

        void Save();
    }
}