﻿namespace GameDb.Client
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using GameDb.Models;
    using GameDb.Entities;

    public class UserRepository: IUserRepository
    {
        readonly GameContext context = new GameContext();
        
        public UserRepository(GameContext context)
        {
            this.context = context;
        }

        public IQueryable<User> All
        {
            get
            {
                return context.Users;
            }
        }

        public void InsertAll(IEnumerable<User> users)
        {
            foreach(var user in users)
            {
                if (!context.Users.Any(x => x.Name == user.Name))
                {
                    context.Users.Add(user);
                }
            }
            Save();
        }

        public void Insert(string name)
        {
            if (!context.Users.Any(x => x.Name == name))
            {
                context.Users.Add(new User() { Name = name, Password = String.Empty});

            }
            Save();
        }

        public bool UpdateResult(string name, int result)
        {
            if (context.Users.Any(x => x.Name == name))
            {
                var user = context.Users.Find(name);
                user.Result = result;
                Save();
                return true;
            }
            return false;
        }

        public bool UpdatePassword(string name, string password)
        {
            if (context.Users.Any(x => x.Name == name))
            {
                var user = context.Users.Find(name);
                user.Password = password;
                Save();
                return true;
            }
            return false;
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
