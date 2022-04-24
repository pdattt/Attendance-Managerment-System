using AttendanceManagementSystem;
using DoAnLapTrinhA.DAO;
using DoAnLapTrinhA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLapTrinhA.BUS
{
    public class UserBUS
    {
        public async ValueTask<string> CheckAccount(UserLogin userLogin)
        {
            List<User> listUser = await new UserDAO().GetAll();

            foreach(User user in listUser)
            {
                if (user.Email == userLogin.Email)
                {
                    if (user.Password == userLogin.Password)
                        return "SUCCESS";
                    else
                        return "WRONG PASSWORD";
                }
            }
            return "USER IS NOT EXIST";
        }
    }
}
