using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace casestudy
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
        void updateCourseDetails();
        void viewAllEnrollments();


    }
    class Sms :UserInterface
    {
        AppEngine appengine;
       
        public Sms()
        {
            this.appengine = new AppEngine();
           
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
            Console.WriteLine("Enter \n1 to Registration \n2 to Show all courses  \n3 to Show Students");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    showStudentRegistrationScreen();
                    break;
                case 2:
                    showAllCourseScreen();
                    break;
                case 3:
                    showAllStudentsScreen();
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
            Console.WriteLine("Enter  \n1 to introduce new course \n2 to update course details \n3 to Student Enroll  \n4 to view All Enrollments \n5 to  exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                   introduceNewCourseScreen();
                    break;
                case 2:
                    updateCourseDetails();
                    break;
                case 3:
                    studentEnroll();
                    break;
                case 4:
                    viewAllEnrollments();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" enter vaild input");
                    showAdminScreen();
                    break;
            }
        }
        public void showAllStudentsScreen()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("list of students registered");
            /*foreach (var v in appengine.listOfStudents())
            {
                Info.display(v);


            }*/
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from student", con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine("student name " + dr[0]);
                    Console.WriteLine("studentid " + dr[1]);
                    Console.WriteLine("dateofbirth " + dr[2]);
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            
               
            showAdminScreen();

        }
        public void showStudentRegistrationScreen()
        {
            Console.WriteLine("Enter studentid");
            int studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your date of birth(dd/mm/yy)");
            string dob = Console.ReadLine();
            Student student1 = new Student(studentid, name, dob);
            appengine.register(student1);
            Console.WriteLine("student registerd succesfully");
            showStudentScreen();

        }
        public void showAllCourseScreen()
        {
            Console.WriteLine("list of courses available");
            /*foreach (var v in appengine.listOfCourses())
            {
                Info.display(v);
            }*/
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from course",con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("courseid " + dr[0]);
                    Console.WriteLine("coursename" +dr[1]);
                    Console.WriteLine("courseduration" + dr[2]);
                    Console.WriteLine("coursefees"+dr[3]);
                }

            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

            showFirstScreen();
        }
        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Enter course id");
            int courseid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the course name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the course duration");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the course fee");
            double fee = Convert.ToDouble(Console.ReadLine());
            Course course1 = new Course(courseid, name, duration, fee);
            appengine.introduce(course1);
            Console.WriteLine("course added succesfully");
            showAdminScreen();

        }
        public void viewAllEnrollments()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr;
            Console.WriteLine("All Enrollment Details");
            try
            {
                con = SQLConnection.getcon();
                cmd = new SqlCommand("select * from Enroll", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("student id :" + dr[0]);
                    Console.WriteLine("course id :" + dr[1]);
                    Console.WriteLine("date of enrollment :" + dr[2]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void updateCourseDetails()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            Console.WriteLine("updating course details");
            try
            {
                con = SQLConnection.getcon();
                Console.WriteLine("Enter course id to update course");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter course name:");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter duration");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter fees");
                double fees = Convert.ToDouble(Console.ReadLine());
                cmd = new SqlCommand("update Course set Name =@name where Id=@sid", con);
                cmd.Parameters.AddWithValue("@name", cname);
                cmd.Parameters.AddWithValue("@dur", dur);
                cmd.Parameters.AddWithValue("@fee", fees);
                cmd.Parameters.AddWithValue("@sid", sid);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("record updated");
                }
                else Console.WriteLine("Not updated");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void studentEnroll()
        {
            Console.WriteLine("Enter sid");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter course id");
            int cid = Convert.ToInt32(Console.ReadLine());
            Student student = appengine.GetStudentById(sid);
            Course course = appengine.GetCourseById(cid);
            if (student == null)
            {
                Console.WriteLine("no student available with id");
            }
            else
            {
                if (course == null)
                {
                    Console.WriteLine("no course available with id");
                }
                else
                {
                    appengine.enroll(student, course);
                }
            }
        }
    }
}

