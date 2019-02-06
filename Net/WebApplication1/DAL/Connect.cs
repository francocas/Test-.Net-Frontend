using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        public static SqlConnection con;

        public Connect()
        {
            Connect.con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
            
            SqlCommand command = new SqlCommand("USE Users SELECT * FROM dbo.Users;",con);
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Users user = new Users(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());
            }
        }
        public class Users
        {
            public Users(int id, string name, string surname, string email, string password)
            {
                this.id = id;
                this.name = name;
                this.surname = surname;
                this.email = email;
                this.password = password;
            }
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string surname { get; set; }
        }
    }
}