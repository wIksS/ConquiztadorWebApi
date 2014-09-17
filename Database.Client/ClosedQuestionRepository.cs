namespace Database.Client
{
    using System;
    using System.Linq;

    using Database.Models;
    using Database.Entities;

    public class ClosedQuestionRepository: IClosedQuestionRepository
    {
        GameContext context = new GameContext();

        public IQueryable All
        {
            get
            {
                return context.ClosedQuestions;
            }
        }

        public void Insert(string name)
        {
            if (!context.ClosedQuestions.Any(x => x.Question == name))
            {
                context.ClosedQuestions.Add(new ClosedQuestion() { Question = name});

            }
            Save();
        }

        public bool Delete(string name)
        {
            if (context.ClosedQuestions.Any(x => x.Question == name))
            {
                var closedQuestion = context.ClosedQuestions.Find(name);
                context.ClosedQuestions.Remove(closedQuestion);
                Save();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}