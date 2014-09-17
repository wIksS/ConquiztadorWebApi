namespace GameDb.Client
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    using GameDb.Entities;
    using GameDb.Models;
    using Newtonsoft.Json;

    class ConsoleCilent
    {
        static void Main()
        {            
            var db = new GameContext();
            using (db)
            {
                IUserRepository usersAdding = new UserRepository(db);
                var fileContent = File.ReadAllText(@"..\..\Users.json");
                var currentUsers = JsonConvert.DeserializeObject<IEnumerable<User>>(fileContent);
                usersAdding.InsertAll(currentUsers);

                IOpenQuestionRepository openQuestionsAdding = new OpenQuestionRepository(db);
                var fileContentOpenQuestions = File.ReadAllText(@"..\..\OpenQuestions.json");
                var currentOpenQuestions = JsonConvert.DeserializeObject<IEnumerable<OpenQuestion>>(fileContentOpenQuestions);
                openQuestionsAdding.InsertAll(currentOpenQuestions);

                IClosedQuestionRepository closedQuestionsAdding = new ClosedQuestionRepository(db);
                var fileContentClosedQuestions = File.ReadAllText(@"..\..\ClosedQuestions.json");
                var currentClosedQuestions = JsonConvert.DeserializeObject<IEnumerable<ClosedQuestion>>(fileContentClosedQuestions);
                closedQuestionsAdding.InsertAll(currentClosedQuestions);
            }

            var dbReport = new GameContext();
            using (dbReport)
            {
                IUserRepository getUsers = new UserRepository(dbReport);
                var users = getUsers.All;
                foreach (var item in users)
                {
                    Console.WriteLine(item.Name);
                }
                
                IClosedQuestionRepository getClosedQuestions = new ClosedQuestionRepository(dbReport);
                var closedQuestions = getClosedQuestions.All;
                foreach (var question in closedQuestions)
                {
                    Console.WriteLine(question.Question +" "+question.CorrectAnswer);
                }

                IOpenQuestionRepository getOpenQuestions = new OpenQuestionRepository(dbReport);
                var openQuestions = getOpenQuestions.All;
                foreach (var question in openQuestions)
                {
                    Console.WriteLine(question.Question + " " + question.CorrectAnswer);
                }
            }
        }
    }
}