namespace Database.Client
{
    using System;
    using System.Linq;

    using Database.Models;
    using Database.Entities;

    public class OpenQuestionRepository: IOpenQuestionRepository
    {
        GameContext context = new GameContext();

        public IQueryable All
        {
            get
            {
                return context.OpenQuestions;
            }
        }

        public void Insert(string question)
        {
            if (!context.OpenQuestions.Any(x => x.Question == question))
            {
                context.OpenQuestions.Add(new OpenQuestion() { Question = question});

            }
            Save();
        }

        public bool UpdateAnswers(string question, int answer)
        {
            if (context.OpenQuestions.Any(x => x.Question == question))
            {
                var openQuestion = context.OpenQuestions.Find(question);
                openQuestion.CorrectAnswer = answer;
                Save();
                return true;
            }
            return false;
        }

        public bool Delete(string name)
        {
            if (context.OpenQuestions.Any(x => x.Question == name))
            {
                var openQuestion = context.OpenQuestions.Find(name);
                context.OpenQuestions.Remove(openQuestion);
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