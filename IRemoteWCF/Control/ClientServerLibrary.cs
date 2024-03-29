﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRemoteWCF.Models;
using IRemoteWCF;
using IRemoteWCF.Control.DataServiceBase;
using System.Data;
using System.ServiceModel;

namespace IRemoteWCF
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class ClientServerLibrary : IClient
    {
        //Consult Works
        ConsultWorksDataService consultWorksDataService = new ConsultWorksDataService();

        public List<Work> getAllWorks()
        {
            DataTable workTable = consultWorksDataService.getAllWorks();

            List<Work> workList = new List<Work>();

            foreach (DataRow dr in workTable.Rows)
            {
                List<string> tags = null, writers = null;
                String title, theme, type;
                int idWork;

                idWork = Convert.ToInt32(dr["code"]);
                title = dr["titre"].ToString().ToLower();
                theme = dr["theme"].ToString().ToLower();
                type = dr["type"].ToString().ToLower();
                String Strtags = dr["mots_cle"].ToString().ToLower();
                String Strwriters = dr["auteurs"].ToString().ToLower();

                string[] separatingChars = { ", ", "," , " ," };

                tags = Strtags.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries).ToList();
                writers = Strwriters.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries).ToList();

                workList.Add(new Work(tags, writers, title, theme, type, idWork));
            }
            return workList;
        }

        public Work getById(int idWork)
        {
            List<Work> listWorks = getAllWorks();
            foreach (Work work in listWorks)
            {
                Console.WriteLine("Work ID : " + work.IdWork);
                Console.WriteLine("Searched Work ID : " + idWork);
                if (work.IdWork == idWork)
                {
                    return work;
                }
            }
            Console.WriteLine("Work with ID : " + idWork + " not found !");
            return null;
        }

        public List<Work> getByTags(string mot_cle)
        {
            List<Work> listWorks = getAllWorks();
            List<Work> searchResult = new List<Work>();
            foreach (Work work in listWorks)
            {
                if (work.Tags.Contains(mot_cle))
                {
                    searchResult.Add(work);
                }
            }
            return searchResult;
        }

        public List<Work> getByTheme(string theme)
        {
            List<Work> listWorks = getAllWorks();
            List<Work> searchResult = new List<Work>();

            foreach (Work work in listWorks)
            {
                if (work.Theme.Equals(theme))
                {
                    searchResult.Add(work);
                }
            }

            return searchResult;

        }

        public List<Work> getByTitle(string titre)
        {
            List<Work> listWorks = getAllWorks();
            List<Work> searchResult = new List<Work>();

            foreach (Work work in listWorks)
            {
                if (work.Title.Equals(titre))
                {
                    searchResult.Add(work);
                }
            }

            return searchResult;
        }

        public List<Work> getByWriter(string writer)
        {
            List<Work> listWorks = getAllWorks();
            List<Work> searchResult = new List<Work>();

            foreach (var work in listWorks)
            {
                if (work.Writers.Contains(writer))
                {
                    searchResult.Add(work);
                }
            }
            return searchResult;
        }

        //ManageWorks

        ManageWorksDataService manageWorksDataService = new ManageWorksDataService();

        public bool AddWork(List<string> tags, List<string> writers, string title, string theme, string type)
        {
            if (type != "Thèses" || type != "Livre" || type != "Mémoires")
            {
                Console.WriteLine("Sorry cannot insert such type " + type);
                return false;
            }
            Work work = new Work(tags, writers, title, theme, type, 0);
            return manageWorksDataService.addWorkDataService(work);
        }

        public bool ConfirmWork(int idWork, int idBorrower)
        {
            return manageWorksDataService.confirmReservationDataService(idWork, idBorrower);
        }

        public bool DeleteWork(int idWork)
        {
            return manageWorksDataService.deleteWorkDataService(idWork);
        }

        public bool EditWork(int idWork, List<string> tags, List<string> writers, string title, string theme, string type)
        {
            if (type != "Thèses" || type != "Livre" || type != "Mémoires")
            {
                Console.WriteLine("Sorry cannot insert such type " + type);
                return false;
            }

            Work work = new Work(tags, writers, title, theme, type, 0);

            return manageWorksDataService.EditWork(idWork, work);
        }

        public bool reserveWork(int idClient, int idWork)
        {
            return manageWorksDataService.reservation(idWork, idClient);
        }

        public bool isBorrowed(int idWork)
        {
            return manageWorksDataService.isBorrowed(idWork);
        }

        public bool isReserved(int idWork)
        {
            return manageWorksDataService.isReserved(idWork);
        }

        public bool isBanned(int CardID)
        {
            return manageWorksDataService.isBanned(CardID);
        }

        public bool returnWork(int idWork, int idBorrower)
        {
            return manageWorksDataService.rendreOuvrage(idWork, idBorrower);
        }
        public bool addList(int CardID, int idWork, string email)
        {
            return manageWorksDataService.addQueue(CardID, idWork , email);
        }

        //ManageUsers

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
                String userName, passWord, type;

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

                borrowersList.Add(new Borrower(idCard, name, lastName, account));
            }
            return borrowersList;
        }

        public Borrower getBorrower(int id)
        {
            List<Borrower> borrowersList = getAllBorrowers();

            foreach (var dr in borrowersList)
            {
                if (dr.CardID1.Equals(id))
                {
                    Borrower ac = new Borrower(dr.CardID1, dr.FirstName, dr.LastName, dr.Account);
                    return ac;
                }
            }
            Console.WriteLine("Borrower not found");
            return null;
        }

        public Borrower getBorrowerByUser(string user)
        {
            List<Borrower> borrowersList = getAllBorrowers();

            foreach (var dr in borrowersList)
            {
                if (dr.Account.UserName.Equals(user))
                {
                    Borrower ac = new Borrower(dr.CardID1, dr.FirstName, dr.LastName, dr.Account);
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

                studentList.Add(new Student(borrower, specialty, level));
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

        public Student getStudentbyUser(string user)
        {
            List<Student> studentsList = getAllStudents();

            foreach (var dr in studentsList)
            {
                if (dr.Borrower.Account.UserName.Equals(user))
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
                String grade;

                int idCard = Convert.ToInt32(dr["matricule"]);
                Borrower borrower = getBorrower(idCard);
                Account account = getUser(borrower.Account.UserName);
                grade = dr["grade"].ToString();

                teachersList.Add(new Teacher(grade, borrower));
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
                    Teacher ac = new Teacher(dr.Grade, dr.Borrower);
                    return ac;
                }
            }
            Console.WriteLine("Teacher not found");
            return null;
        }

        public Teacher getTeacherByUser(string user)
        {
            List<Teacher> teachersList = getAllTeachers();

            foreach (var dr in teachersList)
            {
                if (dr.Borrower.Account.UserName.Equals(user))
                {
                    Teacher ac = new Teacher(dr.Grade, dr.Borrower);
                    return ac;
                }
            }
            Console.WriteLine("Teacher not found");
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
            Teacher teacher = new Teacher(grade, borrower);
            return manageUsers.modifyUserTeacher(teacher);
        }

        public bool signout()
        {
            return true;
        }

    }
}
