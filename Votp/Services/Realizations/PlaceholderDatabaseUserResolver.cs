﻿using Votp.Contracts.Services.UserResolver;
using Votp.DS.Database;
using Votp.DS.Database.Entities;

namespace Votp.Services.Realizations
{
    public class PlaceholderDatabaseUserResolver : IResolver<User>
    {
        private IVotpDbContext _db;
        public PlaceholderDatabaseUserResolver(IVotpDbContext db)
        {
            _db = db;
        }

        public IEnumerable<User> GetResolvedList()
        {
            return _db.Users.ToList();
        }
    }
}
