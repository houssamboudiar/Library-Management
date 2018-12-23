using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.ServiceModel;

namespace IRemoteWCF.Control.DataServiceBase
{
    [ServiceContract]
    public class crudMysql
    {
        private string connString;

        //Initializing the database connection . . .
        public crudMysql(string server, string database, string uid, string password)
        {
            //"server=localhost;database=poc;UserId=root";
            connString = string.Format("server={0};database={1};user={2};password={3}",
                server, database, uid, password);
        }

        public void TestConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                Console.WriteLine("Connected to the referenced Database for testing => " + connString);
                connection.Close();
                Console.WriteLine("Closed");
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Please make sure these are the right credentials for your database => " + connString );
                Console.WriteLine("Error: " + e.Message);
            }

        }

        public void CreateData(string query)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                Console.WriteLine("Connected for Creating Data");
                //string query = "insert into product(name,price,created) values(@name,@price,@created)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Console.WriteLine("Done creating data !");
                cmd.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Closed creating data !");
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public Boolean bCreateData(string query)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                Console.WriteLine("Connected for Creating Data");
                //string query = "insert into product(name,price,created) values(@name,@price,@created)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Done creating data !");
                    connection.Close();
                    Console.WriteLine("Closed creating data !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Creating done but no rows were affected !");
                    connection.Close();
                    Console.WriteLine("Closed creating data !");
                    return false;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false; 
            }
        }

        public DataTable ReadData(string query)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                Console.WriteLine("Connected for Reading Data");

                MySqlCommand cmd = new MySqlCommand(query, connection);

                var table = new DataTable();

                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                {
                    dataAdapter.Fill(table);
                }
                connection.Close();
                Console.WriteLine("Closed reading data ");
                return table; 
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }
        }



        public Boolean UpdateData(string query)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                Console.WriteLine("Connected for Updating Data");

                MySqlCommand cmd = new MySqlCommand(query, connection);

                /*string query = "update product set name=@name,price=@price where idproduct=@id";
                cmd.Parameters.Add("@name", MySqlDbType.VarChar, 45);
                cmd.Parameters.Add("@price", MySqlDbType.Float);
                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                
                Console.Write("Updating data....");
                cmd.Parameters[0].Value = "product-update";
                cmd.Parameters[1].Value = 0.75;
                cmd.Parameters[2].Value = id;
                */

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Done updating");
                    connection.Close();
                    Console.WriteLine("Closed updating data !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Updating done but no rows were affected !");
                    connection.Close();
                    Console.WriteLine("Closed updating data");
                    return false;
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
        }

        public Boolean DeleteData(string query)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connString);
                connection.Open();
                Console.WriteLine("Connected");

                MySqlCommand cmd = new MySqlCommand(query, connection);
                /*
                string query = "delete from product where idproduct=@id";
                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                */
                Console.Write("Deleting data....");
                //cmd.Parameters[0].Value = id;

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Done deleting data !");
                    connection.Close();
                    Console.WriteLine("Closed deleting data !");
                    return true;
                }
                else
                {
                    Console.WriteLine("Creating done but no rows were affected !");
                    connection.Close();
                    Console.WriteLine("Closed creating data !");
                    return false;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
        }


    }
}