using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy1
{
    public interface UserInterface
    {
        void showFirstScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentsScreen();
        void showStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCourseScreen();


    }
    class Sms :UserInterface
    {
        AppEngine appengine;
        int studentid;
        int courseid;
        public Sms()
        {
            this.appengine = new AppEngine();
            this.studentid = 1;
            this.courseid = 10;
        }
        public void showFirstScreen()
        {
            Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
            Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
            }
        }
        public void showStudentScreen()
        {
            Console.WriteLine("Welcome to studentScreen");
            Console.WriteLine("Enter 1 to students Registration 2 to students courses");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    showAllCourseScreen();
                    break;
                default:
                    Console.WriteLine("please enter valid input");
                    showStudentScreen();
                    break;


            }

        }
        public void showAdminScreen()
        {
            Console.WriteLine("Welcome to AdminScreen");
            Console.WriteLine("Enter 1 to AllStudents 2 to Introduce new course 3 to showAllcourses");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    showAllStudentsScreen();
                    break;
                case 2:
                    introduceNewCourseScreen();
                    break;
                case 3:
                    showAllCourseScreen();
                    break;
                default:
                    Console.WriteLine("please enter vaild input");
                    showAdminScreen();
                    break;
            }
        }
        public void showAllStudentsScreen()
        {
            Console.WriteLine("list of students registered");
            foreach (var v in appengine.listOfStudents())
            {
                Info.display(v);


            }
            showAdminScreen();

        }
        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth(dd/mm/yy)");
            string dob = Console.ReadLine();
            Student student1 = new Student(studentid, name, dob);
            appengine.register(student1);
            studentid++;
            Console.WriteLine("student registerd succesfully");
            showStudentScreen();

        }
        public void showAllCourseScreen()
        {
            Console.WriteLine("list of courses available");
            foreach (var v in appengine.listOfCourses())
            {
                Info.display(v);
            }
            showFirstScreen();
        }
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Enter the course name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the course duration");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the course fee");
            double fee = Convert.ToDouble(Console.ReadLine());
            Course course1 = new Course(courseid, name, duration, fee);
            appengine.introduce(course1);
            courseid++;
            Console.WriteLine("course added succesfully");
            showAdminScreen();

        }
    }
}

