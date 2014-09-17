namespace GameDb.Client
{
    using System.Linq;

    public interface IClosedQuestionRepository : IRepository
    {
        IQueryable All{ get; }

        bool UpdateAnswers(string question, string[] answers, char correctAnswer);

        void Insert(string name);

        bool Delete(string name);

        void Save();
    }
}