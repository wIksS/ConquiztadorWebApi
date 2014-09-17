namespace GameDb.Entities.Repositories
{
    using GameDb.Models;
    using System.Collections.Generic;
    using System.Linq;

    public interface IClosedQuestionRepository : IRepository
    {
        IQueryable All{ get; }

        void InsertAll(IEnumerable<ClosedQuestion> questions);

        bool UpdateAnswers(string question, string answersA, string answersB, string answersC, string answersD, string correctAnswer);

        void Insert(string name);

        bool Delete(string name);

        void Save();
    }
}