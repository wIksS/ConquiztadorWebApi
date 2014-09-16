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

            //I will make the repository tomorrow and will enter some data

            //using (db)
            //{
            //    var question = new OpenQuestion();
            //    question.Question = "FirstQuestion";
            //    question.CorrectAnswer = 1;
            //    db.OpenQuestions.Add(question);
            //    db.SaveChanges();
            //}
        }
    }
}
