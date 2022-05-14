using AttendanceManagementSystem;
using DoAnLapTrinhA.DAO;
using DoAnLapTrinhA.DTO;
using DoAnLapTrinhA.Encryption;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoAnLapTrinhA.BUS
{
    public class UserBUS
    {
        public async ValueTask<string> CheckAccount(UserLogin userLogin)
        {
            List<User> listUser = await new UserDAO().GetAll();

            foreach (User user in listUser)
            {
                if (user.Email == EncryptorMD5.MD5Hash(userLogin.Email))
                {
                    if (user.Password == EncryptorMD5.MD5Hash(userLogin.Password))
                        return "SUCCESS";
                    else
                        return "WRONG PASSWORD";
                }
            }
            return "USER IS NOT EXIST";
        }

        public async ValueTask<bool> AddNewUser(UserRegister newUser)
        {
            List<User> listUser = await new UserDAO().GetAll();

            foreach (User user in listUser)
            {
                if (EncryptorMD5.MD5Hash(user.Email) == newUser.Email)
                    return false;
            }

            // Encryption to MD5
            newUser.Email = EncryptorMD5.MD5Hash(newUser.Email);
            newUser.Password = EncryptorMD5.MD5Hash(newUser.Password);
            new UserDAO().AddNew(newUser);

            return true;
        }
    }
}