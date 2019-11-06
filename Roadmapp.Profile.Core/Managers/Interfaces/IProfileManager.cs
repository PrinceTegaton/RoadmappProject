using Roadmapp.Profile.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roadmapp.Profile.Core.Managers
{
    public interface IProfileManager
    {
        UserProfile CreateProfile(UserProfile profile);
    }
}
