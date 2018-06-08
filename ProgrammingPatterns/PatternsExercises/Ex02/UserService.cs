using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex02
{
    public abstract class UserService
    {
        public UserInfo GetUserInfo (string userId, string userName, UserInfo[] friends)
        {
            var result = new UserInfo
            {
                UserId = userId,
                Name = userName,
                Friends = friends
            };

            return result;
        }

    }
}
