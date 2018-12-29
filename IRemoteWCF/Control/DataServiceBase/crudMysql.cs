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

                Console.Write("Deleting data....");

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

        public string testSend(int idWork)
        {
            try
            {
                DataTable dataTable = ReadData("select * from liste_attente where code_ouvrage = " + idWork);
                DateTime dateTime;
                List<DateTime> dateTimes = new List<DateTime>();
                foreach (DataRow d in dataTable.Rows)
                {
                    dateTimes.Add(Convert.ToDateTime(d["date"].ToString()));

                }
                dateTime = dateTimes.Min();
                int idborrower = 0;
                string email = null;
                foreach (DataRow d in dataTable.Rows)
                {
                    if (Convert.ToDateTime(d["date"].ToString()) == dateTime)
                    {
                        idborrower = Convert.ToInt32(d["code_emprunteur"].ToString());
                        email = d["email"].ToString();
                    }

                }
                if (idborrower == 0)
                {
                    return null;
                }
                dataTable = ReadData("select * from emprunteur where id_emprunteur = " + idborrower);
                string m = null;
                foreach (DataRow d in dataTable.Rows)
                {
                    m = d["nom"].ToString() + "," + d["prenom"].ToString() + "," + email;
                    DeleteData("delete from liste_attente where code_emprunteur = " + idborrower + " and code_ouvrage =" + idWork + " and date ='" + dateTime + "'");
                }
                return m;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}