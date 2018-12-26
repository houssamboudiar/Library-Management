using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using IRemoteWCF.Control.DataServiceBase;
using IRemoteWCF.Models;

namespace IRemoteWCF.Control
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ManageUsers : IManageUsers
    {

        ManageUsersDataService manageUsers = new ManageUsersDataService();

        public bool addUserStudent(string UserName, string passWord, int id, string nom, string prenom, string specialty, string niv)
        {
            Account ac = new Account(UserName, passWord, "Etudiant");
            Borrower br = new Borrower(id, prenom, nom, ac);
            Student sr = new Student(br, niv, specialty);
            return manageUsers.addUserStudentDataService(ac, br, sr);
        }

        public bool addUserTeacher(string UserName, string passWord, int id, string nom, string prenom, string grade)
        {
            Account account = new Account(UserName, passWord, "Enseignant");
            Borrower borrower = new Borrower(id, prenom, nom, account);
            Teacher teacher = new Teacher(grade, borrower);
            return manageUsers.addUserTeacherDataService(borrower.Account, borrower, teacher);
        }

        public bool authenticateUser(string userName, string passWord)
        {
            Account account = new Account(userName, passWord, " Doesn't matter ");
            if (manageUsers.authenticateUser(account))
            {
                Console.WriteLine("Logged in !");
                return true;
            }
            else
            {
                Console.WriteLine("Can't wrong credentials");
                return false;
            }
        }

        public List<Account> getAllUsers()
        {
            DataTable accounts = manageUsers.getAllUsers();
            List<Account> accountsList = new List<Account>();

            foreach (DataRow dr in accounts.Rows)
            {
                String userName, passWord,type;

                userName = dr["user"].ToString();
                passWord = dr["passe"].ToString();
                type = dr["type"].ToString();
                accountsList.Add(new Account(userName, passWord, type));
            }
            return accountsList;
        }

        public Account getUser(string username)
        {
            List<Account> accountsList = getAllUsers();

            foreach (var dr in accountsList)
            {
                if (dr.UserName.Equals(username))
                {
                    Account ac = new Account(dr.UserName, dr.PassWord, dr.Type);
                    return ac;
                }
            }
            Console.WriteLine("User not found");
            return null;
        }

        public List<Borrower> getAllBorrowers()
        {
            DataTable borrowers = manageUsers.getAllBorrowers();
            List<Borrower> borrowersList = new List<Borrower>();

            foreach (DataRow dr in borrowers.Rows)
            {
                String user, name, lastName;
                int idCard;

                idCard = Convert.ToInt32(dr["id_emprunteur"]);
                user = dr["user"].ToString();
                name = dr["nom"].ToString();
                lastName = dr["prenom"].ToString();

                Account account = getUser(user);

                borrowersList.Add(new Borrower(idCard, name , lastName, account));
            }
            return borrowersList;
        }

        public Borrower getBorrower(int IdCard)
        {
            List<Borrower> borrowersList = getAllBorrowers();

            foreach (var dr in borrowersList)
            {
                if (dr.CardID1.Equals(IdCard))
                {
                    Borrower ac = new Borrower( dr.CardID1 , dr.FirstName , dr.LastName , dr.Account);
                    return ac;
                }
            }
            Console.WriteLine("Borrower not found");
            return null;
        }


        public List<Student> getAllStudents()
        {
            DataTable students = manageUsers.getAllStudents();
            List<Student> studentList = new List<Student>();

            foreach (DataRow dr in students.Rows)
            {
                String specialty, level;

                int idCard = Convert.ToInt32(dr["num_carte"]);
                Borrower borrower = getBorrower(idCard);
                Account account = getUser(borrower.Account.UserName);
                specialty = dr["specialite"].ToString();
                level = dr["niveau"].ToString();

                studentList.Add(new Student(borrower , specialty, level));
            }
            return studentList;
        }

        public Student getStudent(int IdCard)
        {
            List<Student> studentsList = getAllStudents();

            foreach (var dr in studentsList)
            {
                if (dr.Borrower.CardID1.Equals(IdCard))
                {
                    Student ac = new Student(dr.Borrower, dr.Specialty, dr.Level);
                    return ac;
                }
            }
            Console.WriteLine("Student not found");
            return null;
        }

        public List<Teacher> getAllTeachers()
        {
            DataTable teachers = manageUsers.getAllTeachers();
            List<Teacher> teachersList = new List<Teacher>();

            foreach (DataRow dr in teachers.Rows)
            {
                String grade ;

                int idCard = Convert.ToInt32(dr["num_carte"]);
                Borrower borrower = getBorrower(idCard);
                Account account = getUser(borrower.Account.UserName);
                grade = dr["grade"].ToString();

                teachersList.Add(new Teacher(grade ,borrower));
            }
            return teachersList;
        }

        public Teacher getTeacher(int IdCard)
        {
            List<Teacher> teachersList = getAllTeachers();

            foreach (var dr in teachersList)
            {
                if (dr.Borrower.CardID1.Equals(IdCard))
                {
                    Teacher ac = new Teacher(dr.Grade,dr.Borrower);
                    return ac;
                }
            }
            Console.WriteLine("Student not found");
            return null;
        }

        public Boolean modifyUserStudent(string UserName, string passWord, int CardID, string nom, string prenom, string specialty, string Niveau)
        {
            Account account = new Account(UserName, passWord, "Etudiant");
            Borrower borrower = new Borrower(CardID, prenom, nom, account);
            Student student = new Student(borrower, specialty, Niveau);
            return manageUsers.modifyUserStudent(student);
        }

        public Boolean modifyUserTeacher(string UserName, string passWord, int CardID, string nom, string prenom, string grade)
        {
            Account account = new Account(UserName, passWord, "Etudiant");
            Borrower borrower = new Borrower(CardID, prenom, nom, account);
            Teacher teacher = new Teacher(grade , borrower);
            return manageUsers.modifyUserTeacher(teacher);
        }
    }
}
