using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CaseStudy1
{
    public class Student
    {
        private int studentId;
        private string studentName;
        private string dateOfBirth;
        public Student(int studentId, string studentName, string dateOfBirth)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.dateOfBirth = dateOfBirth;
        }
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }
    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public double fees;



        public Course(int Id, string Name, int duration, double fee)
        {
            this.Id = Id;
            this.Name = Name;
            this.duration = duration;
            this.fees = fee;
        }



    }
    public class Info
    {
        public static void display(Student student)
        {
            Console.WriteLine("Student id is " + student.StudentId + " and student name is " + student.StudentName + " and date of birth is " + student.DateOfBirth);
        }
        public static void display(Course course)
        {
            Console.WriteLine("student id is " + course.Id + " student name is " + course.Name + " couse duration is" + course.duration + " course fee is " + course.fees);
        }
    }
    class App
    {
        public static void Main()
        {
            scenario1();
            scenario2();
            scenario3();
            Course course = new Course(1570, "sanvi", 8, 5200.00);
            Info.display(course);
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
