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
        public async Task<string> CheckAccount(UserLogin userLogin)
        {
            string result = await new UserDAO().CheckUser(userLogin);
            switch (result)
            {
                case "SUCCESS": return "SUCCESS";
                case "WRONG PASSWORD": return "WRONG PASSWORD";
                default: return "USER IS NOT EXIST";
            }
        }
    }
}
