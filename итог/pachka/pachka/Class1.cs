using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pachka
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




        public int AddPOstavki(string nameClient, string postavshik)
        {
            var check = -1;
            MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString);
            connection.Open();
            string cndText = "INSERT INTO `pachka`.`postavki`(`nameClient`,`postavshik`)" +$"VALUES('{nameClient}', '{postavshik}');";

            MySqlCommand cmd = new MySqlCommand(cndText, connection);
            check = cmd.ExecuteNonQuery();


            connection.Close();
            return check;
        }
        public int AddMat(string name, string type, string image, string price, string sklad, string max, string kolvo, string ed)
        {
            var check = -1;
            MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString);
            connection.Open();
            string cndText = $"INSERT INTO `pachka`.`material` (`name`, `type`, `image`, `price`, `sklad`, `max`, `kolvo`, `ed`) VALUES('{name}', '{ type}','{image}', '{ price}', '{sklad}', '{max}', '{ kolvo}','{ed}'); ";

            MySqlCommand cmd = new MySqlCommand(cndText, connection);
            check = cmd.ExecuteNonQuery();


            connection.Close();
            return check;
        }
    }
}
