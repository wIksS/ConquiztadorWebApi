namespace GameDb.Client
{
    using System.Collections.Generic;
    using System.Linq;

    using GameDb.Models;

    public interface IOpenQuestionRepository : IRepository
    {
        IQueryable All{ get; }

        void Insert(string name);

        void InsertAll(IEnumerable<OpenQuestion> questions);

        bool UpdateAnswers(string question, int answer);

        bool Delete(string name);

        void Save();
    }
}