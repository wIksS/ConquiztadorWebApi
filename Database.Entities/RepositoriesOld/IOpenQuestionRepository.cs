namespace GameDb.Entities.RepositoriesOld
{
    using GameDb.Models;
    using System.Collections.Generic;
    using System.Linq;

    public interface IOpenQuestionRepository
    {
        IQueryable All { get; }

        void Insert(string name);

        void InsertAll(IEnumerable<OpenQuestion> questions);

        bool UpdateAnswers(string question, int answer);

        bool Delete(string name);

        void Save();
    }
}
