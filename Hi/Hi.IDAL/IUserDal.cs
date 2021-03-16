using Hi.Model;
using System.Collections.Generic;

namespace Hi.IDAL
{
    public interface IUserDal
    {
        List<User> GetUserList();
        User GetUser(int userNo);
        bool SaveUser(User user);
    }
}
