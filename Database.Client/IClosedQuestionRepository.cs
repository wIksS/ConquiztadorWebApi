namespace GameDb.Client
{
    using System.Linq;
    using System.Collections.Generic;
    
    using Database.Models;

    public interface IClosedQuestionRepository : IRepository
    {
        IQueryable All{ get; }

        bool UpdateAnswers(string question, string answersA, string answersB,string answersC,string answersD,string correctAnswer);

        void Insert(string name);

        void InsertAll(IEnumerable<ClosedQuestion> questions);

        bool Delete(string name);

        void Save();
    }
}