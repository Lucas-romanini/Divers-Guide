using System.Data.SqlClient;

namespace REPO_NAMESPACE
{
    public static class Conn
    {
        
        public static SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection("server=SERVER_IP;database=DATABASENAME;uid=USERNAME;pwd=PASSWORD;MultipleActiveResultSets=True");
            return con;
        }

        public static SqlConnection CreateConnection()
        {
            var cn = GetCon();
            cn.Open();
            return cn;
        }
    }
}
