using Hello.IDAL;
using Hello.Model;
using System;
using System.Collections.Generic;

namespace Hello.BLL
{
    public class UserBll
    {
        //전역변수 사용시에는 변수명에 _를 사용함
        private readonly IUserDal _userDal;

        public UserBll(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetUserList()
        {
            return _userDal.GetUserList();
        }

        public User GetUser(int userNo)
        {
            //유효성 체크
            if (userNo <= 0)
            {
                throw new ArgumentException();
            }

            return _userDal.GetUser(userNo);
        }

        public bool SaveUser(User user)
        {
            //유효성 체크
            if (user == null)
            {
                throw new ArgumentException();
            }

            return _userDal.SaveUser(user);
        }
    }
}
