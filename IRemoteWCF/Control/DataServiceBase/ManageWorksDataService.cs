using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using IRemoteWCF;
using IRemoteWCF.Models;

namespace IRemoteWCF.Control.DataServiceBase
{
    [ServiceContract]
    public class ManageWorksDataService
    {
        crudMysql crudmysql = new crudMysql("localhost", "poc", "houssamboudiar", "stormspirit99");

        public Boolean sendEmail(int idWork)
        {
            try
            {
                string r = crudmysql.testSend(idWork);
                if (r == null)
                {
                    return false;
                }
                string[] m = r.Split(',');
                DataTable dataTable = crudmysql.ReadData("select titre from ouvrage where code = " + idWork);
                string message = " ";
                foreach (DataRow d in dataTable.Rows)
                {
                    message = "Hello dear " + m[0] + " " + m[1] + " , \n We would like to inform you that the work " + d["titre"].ToString() + " is available for reservation";
                }
                MailMessage mailMessage = new MailMessage("projetpoc4@gmail.com", m[2], "Library of NTIC Faculty", message);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("projetpoc4@gmail.com", "projetpoc1234");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                Console.WriteLine("message envoyer");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void test()
        {
            crudmysql.TestConnection();
        }

        public Boolean addWorkDataService(Work work)
        {

            var tagsString = String.Join(", ", work.Tags.ToArray());
            var writersString = String.Join(", ", work.Writers.ToArray());

            string query = String.Format("INSERT INTO `ouvrage` (`code`, `titre`, `auteurs`, `theme`, `type`, `mots_cle`) VALUES( 0 , '{0}' , '{1}' , '{2}' , '{3}' , '{4}')"
            , work.Title , writersString, work.Theme , work.Type , tagsString);

            return crudmysql.bCreateData(query);
        }

        public Boolean deleteWorkDataService(int idWork)
        {

            string query = String.Format("DELETE FROM `ouvrage` WHERE `ouvrage`.`code` = {0} "
                , idWork);

            return crudmysql.DeleteData(query);
        }

        public Boolean EditWork(int idWork, Work work)
        {

            var tagsString = String.Join(", ", work.Tags.ToArray());
            var writersString = String.Join(", ", work.Writers.ToArray());

            string query = String.Format("UPDATE `ouvrage` SET `titre` = '{0}', `auteurs` = '{1}', `theme` = '{2}', `type` = '{3}', `mots_cle` = '{4}' WHERE `ouvrage`.`code` = {5}"
            , work.Title, writersString, work.Theme, work.Type, tagsString,idWork);

            return crudmysql.UpdateData(query);
            
        }

        public Boolean confirmReservationDataService(int idWork , int idBorrower)
        {
            string INSERTquery = String.Format("INSERT INTO `emprunt` (`code_emprunteur`, `code_ouvrage`, `date`) VALUES('{0}', '{1}', CURRENT_TIME())", idBorrower,idWork);
            string DELETEquery = String.Format("DELETE FROM `reservation` WHERE `reservation`.`id_emprunteur` = '{0}' AND `reservation`.`code_ouvrage` = {1}", idBorrower, idWork);
            Boolean isInserted = crudmysql.bCreateData(INSERTquery);
            Boolean isDeleted = crudmysql.DeleteData(DELETEquery);

            if (isInserted && isDeleted)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool reservation(int idWork, int CardID)
        {
            if (isBorrowed(idWork))
            {
                Console.WriteLine("This Work is already borrowed !!");
                return false;
            }

            if (isReserved(idWork))
            {
                Console.WriteLine("This Work is already reserved !!");
                return false;
            }

            if (isBanned(CardID))
            {
                Console.WriteLine("This Work is already reserved !!");
                return false;
            }

            if (isBanned(CardID))
            {
                Console.WriteLine("Banned User !! ");
                return false;
            }
            Console.WriteLine(DateTime.Now);



            bool n = crudmysql.bCreateData("insert into reservation values (CURRENT_TIME() , " + CardID + " , " + idWork + ")");
            if (n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isBorrowed(int idWork)
        {
            DataTable emp = crudmysql.ReadData("select code_ouvrage from emprunt where code_ouvrage = " + idWork);
            foreach (DataRow dr in emp.Rows)
            {
                return true;
            }
            return false;
        }

        public bool isReserved(int idWork)
        {
            DataTable dataTable = crudmysql.ReadData("select code_ouvrage,date_reservation from reservation where code_ouvrage = " + idWork);
            foreach (DataRow d in dataTable.Rows)
            {
                var dnow = (DateTime.Now - Convert.ToDateTime(d["date_reservation"].ToString())).TotalHours;

                if (dnow < 24)
                {
                    return true;
                }
            }
            return false;
        }

        
        public bool isBanned(int CardID)
        {
            DataTable able = crudmysql.ReadData("select id_emprunteur,date_reservation from reservation where id_emprunteur = " + CardID);
            int i = 0;
            List<DateTime> dateTimes = new List<DateTime>();
            DateTime dateTime;
            foreach (DataRow v in able.Rows)
            {
                dateTimes.Add(Convert.ToDateTime(v["date_reservation"].ToString()));
                i++;
                var dnow = (DateTime.Now - Convert.ToDateTime(v["date_reservation"].ToString())).TotalHours;
                if (i >= 3 && dnow > 24)
                {
                    if (i == 3)
                    {
                        dateTime = dateTimes.Max();
                        Console.WriteLine(dateTime);
                        if ((DateTime.Now - dateTime).TotalDays > 30)
                        {
                            crudmysql.DeleteData("delete from reservation where id_emprunteur = " + CardID);
                        }
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }



        public Boolean rendreOuvrage(int idWork, int idBorrower)
        {
            string DELETEquery = String.Format("DELETE FROM `emprunt` WHERE `emprunt`.`code_emprunteur` = '{0}' AND `emprunt`.`code_ouvrage` = {1}", idBorrower, idWork);
            return crudmysql.DeleteData(DELETEquery);
        }


        public bool addQueue(int CardID, int idWork, string email)
        {
            string query = String.Format("INSERT INTO `liste_attente` (`code_emprunteur`, `code_ouvrage`, `date`, `email`) VALUES('{0}', '{1}',CURRENT_DATE(), '{2}')", CardID, idWork, email);


            return crudmysql.bCreateData(query);
        }

    }

}