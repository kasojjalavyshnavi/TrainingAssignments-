using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casestudy1
{
    public class App
    {
        public static void Main()
        {
            // scenario1();
            //scenario2();
            // scenario3();
            //Course course = new Course(1570, "sanvi", 8, 5200.00);
            //Info.display(course);
            /*Case Study-2 */
            //Course course1 = new Course(01, "sap", 6, 30000.00);
            //Student student = new Student(20, "sahasra", "02/11/1998");
            //AppEngine appengine = new AppEngine();
            //appengine.introduce(course1);
            //appengine.register(student);
            //appengine.enroll(student, course1);
            //Student[] students = appengine.listOfStudents();
            //for (int i = 0; i < appengine.studentlistsize; i++)
            //{
            //    Info.display(students[i]);
            //}
            //Course[] courses = appengine.listOfCourses();
            //for (int i = 0; i < appengine.courselistsize; i++)
            //{
            //    Info.display(courses[i]);
            //}
            //Enroll[] enrolls = appengine.listOfEnrollments();
            //for (int i = 0; i < appengine.enrollistsize; i++)
            //{
            //    Info.display(enrolls[i]);
            //}

            //Course course2 = new Course(01, "sap", 6, 30000.00);
            //Student student1 = new Student(20, "mouni", "19/8/2000");
            //AppEngine appengine1 = new AppEngine();
            //appengine.introduce(course2);
            //appengine.register(student1);
            //appengine.enroll(student1, course2);
            //Student[] students1 = appengine.listOfStudents();
            //for (int i = 0; i < appengine.studentlistsize; i++)
            //{
            //    Info.display(students[i]);
            //}
            //Course[] courses1 = appengine.listOfCourses();
            //for (int i = 0; i < appengine.courselistsize; i++)
            //{
            //    Info.display(courses[i]);
            //}
            //Enroll[] enrolls1 = appengine.listOfEnrollments();
            //for (int i = 0; i < appengine.enrollistsize; i++)
            //{
            //    Info.display(enrolls[i]);
            //}
            UserInterface userinterface = new Sms();
            userinterface.showFirstScreen();
            Console.ReadLine();
        }
        public static void scenario1()
        {
            Student student = new Student(1570, "sanvi", "02-05-1997");
            Student student2 = new Student(6582, "sri", "30-6-1998");
            Info.display(student);
            Info.display(student2);
        }
        public static void scenario2()
        {
            Student[] students = new Student[2];
            students[0] = new Student(1570, "sanvi", "02-05-1997");
            students[1] = new Student(6582, "sri", "30-6-1998");
            Info.display(students[0]);
            Info.display(students[1]);
        }
        public static void scenario3()
        {
            Student[] student = new Student[2];

            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter Student Id,Name and Date of Birth");
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                Info.display(student[i]);
            }
        }
    }
}
