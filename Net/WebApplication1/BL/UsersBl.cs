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

        public void DeleteUserById(int id)
        {
            UsersDAL.Delete(id);
        }

        public void AddUser(Users user)
        {
            UsersDAL.Insert(user);
        }

        public void UpdateUser(Users user)
        {
            if (user.id != 0)
            {
                if (!string.IsNullOrEmpty(user.name)
                   && !string.IsNullOrEmpty(user.surname)
                   && !string.IsNullOrEmpty(user.email)
                   && !string.IsNullOrEmpty(user.password))
                {
                    UsersDAL.Update(user);
                }
                if (!string.IsNullOrEmpty(user.name))
                {
                    UsersDAL.Update("name", user.name, user.id);
                }
                if (!string.IsNullOrEmpty(user.surname))
                {
                    UsersDAL.Update("surname", user.surname, user.id);
                }
                if (!string.IsNullOrEmpty(user.email))
                {
                    UsersDAL.Update("email", user.email, user.id);
                }
                if (!string.IsNullOrEmpty(user.password))
                {
                    UsersDAL.Update("password", user.password, user.id);
                }
            }
            
        }
    }
}
