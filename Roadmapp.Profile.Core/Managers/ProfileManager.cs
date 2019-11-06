using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roadmapp.Profile.Core.DataAccess;
using Roadmapp.Profile.Core.Models;

namespace Roadmapp.Profile.Core.Managers
{
    public class ProfileManager : IProfileManager
    {
        private readonly AppDbContext _context;

        public ProfileManager(AppDbContext context)
        {
            _context = context;
        }

        public int DeleteAllProfiles()
        {
            var all = _context.Profile.ToList();
            int count = 0;

            foreach (var i in all)
            {
                _context.Profile.Remove(i);
                count++;
            }
            
            return count;
        }

        public UserProfile CreateProfile(UserProfile profile)
        {
            _context.Profile.Add(profile);
            int r = _context.SaveChanges();
            
            return r > 0 ? _context.Profile.Find(profile.Id) : null;
        }
    }
}
