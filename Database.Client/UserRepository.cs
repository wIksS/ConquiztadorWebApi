namespace Database.Client
{
    using System;
    using System.Linq;

    using Database.Models;
    using Database.Entities;

    public class UserRepository: IUserRepository<User>
    {
        GameContext context = new GameContext();

        public IQueryable All
        {
            get
            {
                return context.Users;
            }
        }

        public void InsertOrUpdate(string name, string password, int result)
        {
            if (context.Users.Any(x => x.Name == name))
            {
                context.Users.Add(new User() { Name = name, Password = password });

            }
            else
            {
                var currentUser = context.Users.Find(name);
                currentUser.Result = currentUser.Result + result;
                currentUser.Password = password;
            }

            Save();
        }

        public bool Delete(string name)
        {
            if (context.Users.Any(x => x.Name == name))
            {
                var user = context.Users.Find(name);
                context.Users.Remove(user);
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
