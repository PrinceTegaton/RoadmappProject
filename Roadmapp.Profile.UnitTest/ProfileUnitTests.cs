using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Roadmapp.Core.DataAccess;
using Roadmapp.Core.Managers;

namespace RoadmappUnitTest
{
    [TestClass]
    public class ProfileUnitTests
    {
        private ProfileManager _profileManager;

        [TestInitialize]
        public void BuildContext()
        {
            var connection = new SqliteConnection("Filename=D:/ICT LAB/Projects/RoadmappProject/Roadmapp.db");
            connection.Open();

            var opt1 = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("Roadmapp").Options;
            var opt2 = new DbContextOptionsBuilder<AppDbContext>().UseSqlite(connection).Options;

            var context = new AppDbContext(opt2);
            context.Database.EnsureCreated();
            

            _profileManager = new ProfileManager(context);
        }

        [TestMethod]
        public void DeleteAllProfiles()
        {
            var result = _profileManager.DeleteAllProfiles();

            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CreateProfile()
        {
            var profile = _profileManager.CreateProfile(new Roadmapp.Core.Models.Profile
            {
                Name = "Jane Doe",
                EmailAddress = "jane.doe@gmail.com",
                PhoneNumber = "09099999999",
                Country = "US",
                Location = "San Francisco"
            });

            Assert.IsNotNull(profile);
        }
    }
}
