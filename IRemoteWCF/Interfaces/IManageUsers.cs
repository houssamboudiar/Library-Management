using System;
using System.Collections.Generic;
using System.ServiceModel;
using IRemoteWCF.Models;

namespace IRemoteWCF
{
    [ServiceContract]
    public interface IManageUsers
     {

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
