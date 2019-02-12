using System.Data;
using System.Data.SqlClient;

namespace Project.DBL
{
    static class DbLayer    // static class, because it is a utility class, i don't want to inherit from it nor create an object
    {

        // if i want to change the user or pass of my DB, i will just edit this connection string
        private static string conStr = "Data Source=.;Initial Catalog=Education;Integrated Security=True";

        public static DataTable ExecuteQuery(string selectCommand)
        {
            var adpt = new SqlDataAdapter(selectCommand, conStr);

            var result = new DataTable();
            adpt.Fill(result);
            return result;
        }  // disconnected model only for SELECT Command

        public static bool ExecuteNonQuery(string DmlCommand)     // connected model for Delete, Insert,Update (DML Commands )
        {
            bool result;

            var con = new SqlConnection(conStr);

            var command = new SqlCommand(DmlCommand, con);
            con.Open();
            result = command.ExecuteNonQuery() > 0;
            con.Close();
            return result;
         
        }

        public static object ExecuteScalar(string command)
        {
            var con = new SqlConnection(conStr);

            var cmd = new SqlCommand(command, con);
            con.Open();
            var result = cmd.ExecuteScalar();
            con.Close();
            return result;
        }
    }
}
