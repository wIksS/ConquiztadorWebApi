namespace Database.Client
{
    using System;
    using System.Linq;

    using Database.Models;
    using Database.Entities;

    public class UserRepository: IUserRepository
    {
        GameContext context = new GameContext();

        public IQueryable All
        {
            get
            {
                return context.OpenQuestions;
            }
        }

        public void Insert(string name)
        {
            if (!context.OpenQuestions.Any(x => x.Question == name))
            {
                context.OpenQuestions.Add(new OpenQuestion() { Question = name});

            }
            Save();
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