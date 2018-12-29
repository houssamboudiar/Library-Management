using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using IRemoteWCF.Models;


namespace IRemoteWCF
{
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IClient
    {

        // Devloppement mode
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

        [OperationContract]
        Boolean isBorrowed(int idWork);

        [OperationContract]
        Boolean isReserved(int idWork);

        [OperationContract]
        Boolean isBanned(int idCard);

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

        [OperationContract]
        bool addList(int CardID, int idWork, string email);

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
        Teacher getTeacherByUser(string user);

        [OperationContract]
        Student getStudentbyUser(string user);

        [OperationContract]
        List<Teacher> getAllTeachers();

        [OperationContract]
        Teacher getTeacher(int IdCard);

        [OperationContract]
        Boolean modifyUserStudent(string UserName, string passWord, int CardID, string nom, string prenom, string specialty, string Niveau);

        [OperationContract]
        Boolean modifyUserTeacher(string UserName, string passWord, int CardID, string nom, string prenom, string grade);

        [OperationContract]
        bool signout();

        /* Deploy mode
        // Consult Works
        [OperationContract(IsInitiating = false)]
        List<Work> getAllWorks();

        [OperationContract(IsInitiating = false)]
        Work getById(int idWork);

        [OperationContract(IsInitiating = false)]
        List<Work> getByTitle(String titre);

        [OperationContract(IsInitiating = false)]
        List<Work> getByWriter(String writer);

        [OperationContract(IsInitiating = false)]
        List<Work> getByTags(String mot_cle);

        [OperationContract(IsInitiating = false)]
        List<Work> getByTheme(String theme);


        // Manage Works
        [OperationContract(IsInitiating = false)]
        Boolean reserveWork(int idClient, int idWork);


        // Manage Users
        [OperationContract(IsInitiating = false)]
        bool addUserStudent(string UserName, string passWord, int id, string nom, string prenom, string specialty, string niv);

        [OperationContract(IsInitiating = false)]
        bool addUserTeacher(string UserName, string passWord, int id, string nom, string prenom, string grade);

        [OperationContract(IsInitiating = true)]
        bool authenticateUser(string userName, string passWord);

        [OperationContract(IsInitiating = false)]
        List<Account> getAllUsers();

        [OperationContract(IsInitiating = false)]
        Account getUser(string username);

        [OperationContract(IsInitiating = false)]
        List<Borrower> getAllBorrowers();

        [OperationContract(IsInitiating = false)]
        Borrower getBorrower(int IdCard);

        [OperationContract(IsInitiating = false)]
        List<Student> getAllStudents();

        [OperationContract(IsInitiating = false)]
        Student getStudent(int IdCard);

        [OperationContract(IsInitiating = false)]
        List<Teacher> getAllTeachers();

        [OperationContract(IsInitiating = false)]
        Teacher getTeacher(int IdCard);

        [OperationContract(IsInitiating = false)]
        Boolean modifyUserStudent(string UserName, string passWord, int CardID, string nom, string prenom, string specialty, string Niveau);

        [OperationContract(IsInitiating = false)]
        Boolean modifyUserTeacher(string UserName, string passWord, int CardID, string nom, string prenom, string grade);

        [OperationContract(IsInitiating = false, IsTerminating = true)]
        bool signout();*/

    }
}


