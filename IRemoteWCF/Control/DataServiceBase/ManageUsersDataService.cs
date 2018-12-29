using IRemoteWCF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRemoteWCF.Control.DataServiceBase
{
    public class ManageUsersDataService
    {
        crudMysql crudmysql = new crudMysql("localhost", "poc", "houssamboudiar", "stormspirit99");

        public bool addUserStudentDataService(Account account, Borrower borrower , Student student)
        {
            string queryAccount = String.Format("INSERT INTO `compte` (`user`, `passe`, `type`) VALUES('{0}', '{1}','Etudiant')", account.UserName,account.PassWord);

            string queryBorrower = String.Format("INSERT INTO `emprunteur` (`id_emprunteur`, `user`, `nom`, `prenom`) VALUES('{0}', '{1}','{2}', '{3}')"
            , borrower.CardID1 , borrower.Account.UserName, borrower.LastName , borrower.FirstName );

            
            string querystudent = String.Format("INSERT INTO `etudiant` (`num_carte`, `specialite`, `niveau`) VALUES('{0}', '{1}', '{2}')"
            , student.Borrower.CardID1 , student.Specialty , student.Level );

            if(crudmysql.bCreateData(queryAccount)&& crudmysql.bCreateData(queryBorrower) && crudmysql.bCreateData(querystudent))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool addUserTeacherDataService(Account account, Borrower borrower, Teacher teacher)
        {
            string queryAccount = String.Format("INSERT INTO `compte` (`user`, `passe`, `type`) VALUES('{0}', '{1}','Enseignant')", account.UserName, account.PassWord);

            string queryBorrower = String.Format("INSERT INTO `emprunteur` (`id_emprunteur`, `user`, `nom`, `prenom`) VALUES('{0}', '{1}','{2}', '{3}')"
            , borrower.CardID1, borrower.Account.UserName, borrower.LastName, borrower.FirstName);

            
            string queryTeacher = String.Format("INSERT INTO `enseignant` (`matricule`, `grade`) VALUES('{0}', '{1}')"
            , teacher.Borrower.CardID1, teacher.Grade);

            if (crudmysql.bCreateData(queryAccount) && crudmysql.bCreateData(queryBorrower) && crudmysql.bCreateData(queryTeacher))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool authenticateUser(Account account)
        {
            string queryAccount = String.Format("select* from `compte` where `user`= '{0}' AND `passe`= '{1}'", account.UserName, account.PassWord);
            int rowsCount = crudmysql.ReadData(queryAccount).Rows.Count;
            if (rowsCount == 0)
            {
                Console.WriteLine("Invalid Username or Password!");
                return false; 
            }
            else
            {
                Console.WriteLine("You are successfully authenticated!");
                return true;
            }
        }

        public DataTable getAllUsers()
        {
            string query = "SELECT* FROM `compte`";
            return crudmysql.ReadData(query);
        }

        public DataTable getAllBorrowers()
        {
            string query = "SELECT * FROM `emprunteur`";
            return crudmysql.ReadData(query);
        }

        public DataTable getAllStudents()
        {
            string query = "SELECT * FROM `etudiant`";
            return crudmysql.ReadData(query);
        }

        public DataTable getAllTeachers()
        {
            string query = "SELECT * FROM `enseignant`";
            return crudmysql.ReadData(query);
        }

        public bool modifyUserStudent(Student student)
        {
            
            string queryemp = String.Format("UPDATE `emprunteur` SET `nom` = '{0}', `prenom` = '{1}' WHERE `emprunteur`.`id_emprunteur` = {2}", student.Borrower.LastName, student.Borrower.FirstName , student.Borrower.CardID1);
            string queryetu = String.Format("UPDATE `etudiant` SET `specialite` = '{0}', `niveau` = '{1}' WHERE `etudiant`.`num_carte` = '{2}'", student.Specialty, student.Level, student.Borrower.CardID1);

            if(crudmysql.UpdateData(queryemp) && crudmysql.UpdateData(queryetu))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool modifyUserTeacher(Teacher teacher)
        {

            string queryemp = String.Format("UPDATE `emprunteur` SET `nom` = '{0}', `prenom` = '{1}' WHERE `emprunteur`.`id_emprunteur` = {2}", teacher.Borrower.LastName, teacher.Borrower.FirstName, teacher.Borrower.CardID1);
            string queryetu = String.Format("UPDATE `enseignant` SET `grade` = '{0}' WHERE `enseignant`.`matricule` = '{1}'", teacher.Grade, teacher.Borrower.CardID1);
            if (crudmysql.UpdateData(queryemp) && crudmysql.UpdateData(queryetu))
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
