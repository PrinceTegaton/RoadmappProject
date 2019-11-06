using Microsoft.EntityFrameworkCore;
using Roadmapp.Profile.Core.DataAccess;
using Roadmapp.Profile.Core.Models;

namespace Roadmapp.Profile.Core.Managers.Mocks
{
    public class ProfileManagerMock : IProfileManager
    {
        private readonly AppDbContext _context;

        public ProfileManagerMock()
        {
            var opt = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("Roadmapp").Options;
            _context = new AppDbContext(opt);
        }

        public UserProfile CreateProfile(UserProfile profile)
        {
            _context.Profile.Add(profile);
            return profile;
        }
    }
}
