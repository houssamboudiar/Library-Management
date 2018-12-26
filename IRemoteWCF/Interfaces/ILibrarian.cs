using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using IRemoteWCF.Models;

namespace IRemoteWCF
{
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface ILibrarian
    {
        // Manage Works
        [OperationContract]
        Boolean AddWork(List<string> tags, List<string> writers, string title, string theme, string type);

        [OperationContract]
        Boolean EditWork(int idWork, List<string> tags, List<string> writers, string title, string theme, string type);

        [OperationContract]
        Boolean DeleteWork(int idWork);

        [OperationContract]
        Boolean ConfirmWork(int idWork, int idBorrower);

        [OperationContract]
        Boolean returnWork(int idWork, int idBorrower);

        [OperationContract]
        Boolean reserveWork(int idClient, int idWork);

        // Consult Works
        [OperationContract]
        List<Work> getAllWorks();

        [OperationContract]
        Work getById(int idWork);

        [OperationContract]
        List<Work> getByTitle(String titre);

        [OperationContract]
        List<Work> getByWriter(String writer);

        [OperationContract]
        List<Work> getByTags(String mot_cle);

        [OperationContract]
        List<Work> getByTheme(String theme);


        // Manage Users
        [OperationContract]
        bool addUserStudent(string UserName, string passWord, int id, string nom, string prenom, string specialty, string niv);

        [OperationContract]
        bool addUserTeacher(string UserName, string passWord, int id, string nom, string prenom, string grade);

        [OperationContract]
        bool authenticateUser(string userName, string passWord);

        [OperationContract]
        List<Account> getAllUsers();

        [OperationContract]
        Account getUser(string username);

        [OperationContract]
        List<Borrower> getAllBorrowers();

        [OperationContract]
        Borrower getBorrower(int IdCard);

        [OperationContract]
        List<Student> getAllStudents();

        [OperationContract]
        Student getStudent(int IdCard);

        [OperationContract]
        List<Teacher> getAllTeachers();

        [OperationContract]
        Teacher getTeacher(int IdCard);

        [OperationContract]
        Boolean modifyUserStudent(string UserName, string passWord, int CardID, string nom, string prenom, string specialty, string Niveau);

        [OperationContract]
        Boolean modifyUserTeacher(string UserName, string passWord, int CardID, string nom, string prenom, string grade);



    }
}
