using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace AutoAll
{
   class DataBaseClass
    {
        MySqlConnectionStringBuilder connectionstring;

        public DataBaseClass()

        {
            connectionstring = new MySqlConnectionStringBuilder();
            connectionstring.Server = "localhost";
            connectionstring.UserID = "root";
            connectionstring.Password = "i_nAMELESS_wRITER_2004";
            connectionstring.Database = "autoall";



        }




        public int AddUser(string login, string password)
        {
            var check = -1;
            MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString);
            connection.Open();
            string cndText = "INSERT INTO `autoall`.`users`(`login` , `password`)" + $"VALUES('{login}', '{password}');";

            MySqlCommand cmd = new MySqlCommand(cndText, connection);
            check = cmd.ExecuteNonQuery();


            connection.Close();
            return check;
        }
        public int AddClient(string name, string Birthday, string gender, string registation, string email, string phone, string status)
        {
            var check = -1;
            MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString);
            connection.Open();
            string cndText = $"INSERT INTO `autoall`.`clients`(`nameClient`,`Birthday`,`Gender`,`RegistrationDate`,`Email`,`Phone`,`StatusClient`) VALUES ('{name}', '{Birthday}', '{gender}', '{registation}', '{email}', '{phone}', '{status}'); ";

            MySqlCommand cmd = new MySqlCommand(cndText, connection);
            check = cmd.ExecuteNonQuery();


            connection.Close();
            return check;
        }
        public List<string> ReadGender()
        {
            List<string> list = new List<string>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM Gender;", connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(1));
                        }
                    }
                }


            }
            catch (Exception error)
            {
                System.Windows.MessageBox.Show(error.Message);
            }
            return list;
        }
        public List<string> ReadStatus()
        {
            List<string> list = new List<string>();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM statusclient;", connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(1));
                        }
                    }
                }


            }
            catch (Exception error)
            {
                System.Windows.MessageBox.Show(error.Message);
            }
            return list;
        }
    }
}
