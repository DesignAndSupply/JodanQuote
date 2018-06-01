 using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using Connection;



namespace loginclass
{
    public class Login
    {
        public static string globalUserName;
        public static bool globalAdmin;
        public static bool globalSuperUser;
        public static string globalFullName;


        public string UserName { get; set; }
        public string PassWord { get; set; }
        

        public Login(string user, string pass)
        {
            this.UserName = user;
            this.PassWord = pass;
        }

        private void ClearText(string user, string pass)
        {
            user = string.Empty;
            pass = string.Empty;
        }



        public bool IsLoggedIn(string user, string pass)
        {
            if (string.IsNullOrEmpty(user))
            {
                System.Windows.MessageBox.Show("Enter the user name!");
                return false;
            }
            else
            {
               
                SqlConnection sqlConnection = ConnectionClass.GetConnection_userdatabase();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConnection;
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandText = "SELECT forename + ' ' + surname as fullname,username, password , door_order_admin, super_user from dbo.[user] WHERE username = @user and password = @pass";

                sqlCmd.Parameters.AddWithValue("@user", user);
                sqlCmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                
                if (reader.Read())
                {

                    globalUserName = reader["username"].ToString();
                    globalFullName = reader["fullname"].ToString();
                    if (Convert.ToInt16(reader["door_order_admin"]) == 1)
                    {
                        globalAdmin = true;
                    }
                    else
                    {
                        globalAdmin = false;
                    }

                    if (Convert.ToInt16(reader["super_user"]) == 1)
                    {
                        globalSuperUser= true;
                    }
                    else
                    {
                        globalSuperUser = false;
                    }

                    ConnectionClass.Dispose_connection(sqlConnection);
                    return true;

                }
                else
                {
                    ClearText(user, pass);
                    ConnectionClass.Dispose_connection(sqlConnection);
                    return false;
                }

                
               
            }
        }

    }
}
