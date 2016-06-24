using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_project
{
    class Cours
    {
        public string[] b = new string[50];
        static public int i;
        public string[] cours;
        public Cours(int size)
        {
            
            cours = new string[size];
        }
        public Cours() 
        {
            i = 0;
        }

        // method that contain all courses .
        // take the number of course and return the name of course
        public string Basic_Course(int SNum)
        {
            string[] BCourses = new string[] {"Introduction to Computer & Applications","Discrete Structure","Physics","Mathematics (1)",
                "English (1)","Structured programming","Computer Packages","Electronics","Mathematics (2)","English (2)",
                "Operation research","Mathematics (3)","Data structures","Object oriented programming",
                "Logic design","Humanities ( Elective)","System Analysis","File organization & Processing","Probability & Statistics",
                "Computer Organization & Assembly Language"};   // put all courses in array
            return BCourses[SNum];    // return the name of course
        }

        // method that add new course by take the number of course
        public string add(int num)
        {
            string ss = Basic_Course(num);  // call the method (Basic_Course) and the return course name and put it in array
            Console.WriteLine(ss);   // print the course name
            return ss;
            
        }

        // method print the list of all courses
        public void print()
        {
            for (int i = 0;  i < 20; i++)
            {
                Console.WriteLine("{0}. {1}", i , Basic_Course(i));
            }
        }

        // method print the courses and professor that user choose
       public void print_Enter_Courses()
        {
           Console.WriteLine("Your Courses IS :-");
           for (int a = 0; a < cours.Length; a++)
           {
               Console.Write("{0}           ____         DR. {1}", cours[a], b[a]);       // print the course
               Console.WriteLine();
           }
        }
    }
}
