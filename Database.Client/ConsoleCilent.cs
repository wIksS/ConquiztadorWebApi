namespace Database.Client
{
    using System;
    using System.Linq;

    using Database.Entities;
    using Database.Models;

    class ConsoleCilent
    {
        static void Main()
        {
            var db = new GameContext();

            using (db)
            {
                var question = new OpenQuestion();
                question.Question = "FirstQuestion";
                question.CorrectAnswer = 1;
                db.OpenQuestions.Add(question);
                db.SaveChanges();
            }
        }
    }
}
