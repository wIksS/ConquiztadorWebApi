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
                var users = new List<User>();
                var fileContent = File.ReadAllText(@"..\..\Users.json");
                var currentUsers = JsonConvert.DeserializeObject<IEnumerable<User>>(fileContent);
                usersAdding.InsertAll(currentUsers);

                IOpenQuestionRepository openQuestionsAdding = new OpenQuestionRepository(db);
                var openQuestions = new List<OpenQuestion>();
                var fileContentOpenQuestions = File.ReadAllText(@"..\..\OpenQuestions.json");
                var currentOpenQuestions = JsonConvert.DeserializeObject<IEnumerable<OpenQuestion>>(fileContentOpenQuestions);
                openQuestionsAdding.InsertAll(currentOpenQuestions);

                IClosedQuestionRepository closedQuestionsAdding = new ClosedQuestionRepository(db);
                var closedQuestions = new List<ClosedQuestion>();
                var fileContentClosedQuestions = File.ReadAllText(@"..\..\ClosedQuestions.json");
                var currentClosedQuestions = JsonConvert.DeserializeObject<IEnumerable<ClosedQuestion>>(fileContentClosedQuestions);
                closedQuestionsAdding.InsertAll(currentClosedQuestions);
            }
        }
    }
}