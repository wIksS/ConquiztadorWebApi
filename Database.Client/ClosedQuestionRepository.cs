namespace GameDb.Client
{
    using System;
    using System.Linq;

    using GameDb.Models;
    using GameDb.Entities;
    using System.Collections.Generic;

    public class ClosedQuestionRepository: IClosedQuestionRepository
    {
        GameContext context = new GameContext();

        public ClosedQuestionRepository(GameContext context)
        {
            this.context = context;
        }

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

        public void InsertAll(IEnumerable<ClosedQuestion> questions)
        {
            foreach(var question in questions)
            {
                if (!context.ClosedQuestions.Any(x => x.Question == question.Question))
                {
                    context.ClosedQuestions.Add(question);
                }
            }
            Save();
        }

        public bool UpdateAnswers(string question, string answersA,string answersB,string answersC,string answersD, string correctAnswer)
        {
            if (context.ClosedQuestions.Any(x => x.Question == question))
            {
                var closedQuestion = context.ClosedQuestions.Find(question);
                closedQuestion.Question = question;
                closedQuestion.AnswerA = answersA;
                closedQuestion.AnswerB = answersB;
                closedQuestion.AnswerC = answersC;
                closedQuestion.AnswerD = answersD;
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