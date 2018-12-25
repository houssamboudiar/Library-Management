using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemote;
using IRemote.Models;

namespace LibraryServer.DataServiceBase
{
    public class ManageWorksDataService : MarshalByRefObject
    {
        crudMysql crudmysql = new crudMysql("localhost", "poc", "root", "");
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
            string INSERTquery = String.Format("INSERT INTO `emprunt` (`code_emprunteur`, `code_ouvrage`, `date`) VALUES('{0}', '{1}', CURRENT_TIME())", idWork, idBorrower);
            string DELETEquery = String.Format("DELETE FROM `reservation` WHERE `reservation`.`id_emprunteur` = '{0}' AND `reservation`.`code_ouvrage` = {1}", idWork, idBorrower);
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




    }
}