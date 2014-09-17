﻿namespace GameDb.Client
{
    using System.Collections.Generic;
    using System.Linq;

    using Database.Models;

    public interface IUserRepository : IRepository
    {
        IQueryable All{ get; }

        bool UpdateResult(string name, int result);

        bool UpdatePassword(string name, string password);

        void InsertAll(IEnumerable<User> users);

        void Insert(string name);

        bool Delete(string name);

        void Save();
    }
}