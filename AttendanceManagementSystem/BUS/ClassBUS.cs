using AttendanceManagementSystem.DAO;
using AttendanceManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.BUS
{
    public class ClassBUS
    {
        public string GetRandomID(int lenght)
        {
            string letter = "0123456789";
            Random r = new Random((int)DateTime.Now.Ticks);

            string randomID = "CL";
            for (int i = 0; i < lenght; i++)
            {
                randomID += letter[r.Next(0, letter.Length - 1)];
            }
            return randomID;
        }

        public async ValueTask<Class> GetClassByID(string ID)
        {
            return await new ClassDAO().GetClassByID(ID);
        }

        public async ValueTask<List<Class>> GetAllClass()
        {
            return await new ClassDAO().GetAllClass();
        }

        public bool AddNewClass(Class cls)
        {
            return new ClassDAO().AddNewClass(cls);
        }

        public async Task<bool> DeleteClassByID(string id)
        {
            return await new ClassDAO().DeleteClassByID(id);
        }

        public async ValueTask<bool> UpdateClass(Class newClass)
        {
            bool result = await new ClassDAO().UpdateClass(newClass);
            return result;
        }

        public async ValueTask<List<Class>> SelectByKeyWord(string Name)
        {
            List<Class> listClass = await new ClassDAO().SelectByKeyWord(Name);
            return listClass;
        }
    }
}