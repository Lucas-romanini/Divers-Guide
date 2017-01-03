using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGrepo
{
   public class UsersFac : AutoFac<Users>
    {
        public bool UserExist(string email)
        {
            if (GetBy("Email", email).Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Users Login(string email, string adgangskode)
        {
            Users u = new Users();
            Mapper<Users> mapper = new Mapper<Users>();

            using (var CMD = new SqlCommand("select * from Bruger where Email=@Email and Password=@Password", Conn.CreateConnection()))
            {
                CMD.Parameters.AddWithValue("@Email", email);
                CMD.Parameters.AddWithValue("@Password", adgangskode);

                var r = CMD.ExecuteReader();

                if (r.Read())
                {
                    u = mapper.Map(r);
                }
            }

            return u;
        }
    }
}
