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

        public bool UpdateAnswers(string question, string[] answers, char correctAnswer)
        {
            if (context.ClosedQuestions.Any(x => x.Question == question))
            {
                var closedQuestion = context.ClosedQuestions.Find(question);
                closedQuestion.AnswerA = answers[0];
                closedQuestion.AnswerB = answers[1];
                closedQuestion.AnswerC = answers[2];
                closedQuestion.AnswerD = answers[3];
                closedQuestion.CorrectAnswer = correctAnswer;
                Save();
                return true;
            }
            return false;
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