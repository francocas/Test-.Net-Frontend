using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using DAL;
namespace BL
{
    public class UsersBl
    {
        public UsersBl()
        {

        }
        public List<Users> GetAllUsers()
        {
            return UsersDAL.GetAll();
        }

        public Users GetUserById(int id)
        {
            return UsersDAL.Get(id);
        }

        public bool DeleteUserById(int id)
        {
            return UsersDAL.Delete(id);
        }

        public bool AddUser(Users user)
        {
            return UsersDAL.Insert(user);
        }

        public bool UpdateUser(Users user)
        {
            if (user.id != 0)
            {
                if (!string.IsNullOrEmpty(user.name)
                   && !string.IsNullOrEmpty(user.surname)
                   && !string.IsNullOrEmpty(user.email)
                   && !string.IsNullOrEmpty(user.password))
                {
                    return UsersDAL.Update(user);
                }
                if (!string.IsNullOrEmpty(user.name))
                {
                    return UsersDAL.Update("name", user.name, user.id);
                }
                if (!string.IsNullOrEmpty(user.surname))
                {
                    return UsersDAL.Update("surname", user.surname, user.id);
                }
                if (!string.IsNullOrEmpty(user.email))
                {
                    return UsersDAL.Update("email", user.email, user.id);
                }
                if (!string.IsNullOrEmpty(user.password))
                {
                    return UsersDAL.Update("password", user.password, user.id);
                }
            }
            return false;
            
        }
    }
}
