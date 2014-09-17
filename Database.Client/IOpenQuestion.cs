namespace Database.Client
{
    using System.Linq;

    public interface IOpenQuestionRepository
    {
        IQueryable All{ get; }

        void InsertOrUpdate(string name, string text);

        bool Delete(string Id);

        void Save();
    }
}