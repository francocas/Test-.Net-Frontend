using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Configuration;
namespace DAL
{
    public class UsersDAL
    {
        public static List<Users> GetAll()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            List<Users> retorno = new List<Users>();
            SqlCommand command = new SqlCommand("USE Users SELECT * FROM dbo.Users;", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               retorno.Add(new Users(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()));
            }
            return retorno;
        }

        public static Users Get(int id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            Users retorno = new Users();
            SqlCommand command = new SqlCommand("USE Users SELECT * FROM dbo.Users WHERE id ="+id+";", con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                retorno = new Users(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
            }
            return retorno;
        }


        public static bool Delete(int id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("USE Users DELETE FROM dbo.Users WHERE id =" + id + ";", con);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public static bool Insert(Users userToInsert)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("USE Users INSERT INTO dbo.Users(name, surname, email, password) values('"
                +userToInsert.name
                +"','"+userToInsert.surname
                +"','"+userToInsert.email
                +"','"+userToInsert.password
                +"');", con);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public static bool Update(string column, string data, int id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("USE Users UPDATE dbo.Users SET " +column+" = '" + data+"' WHERE id = "+id.ToString()+";", con);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        public static bool Update(Users userUpdate)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            SqlCommand command = new SqlCommand("USE Users UPDATE dbo.Users SET name = '" + userUpdate.name+
                "', surname = '"+ userUpdate.surname
                + "', email = '" + userUpdate.email
                + "', password = '" + userUpdate.password + "' WHERE id = "+userUpdate.id+" ;", con);
            con.Open();
            if (command.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
    }
}
