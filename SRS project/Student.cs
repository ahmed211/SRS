using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_project
{
    //class student inhrit from class person
    class Student : Person
    {
        public static int Id=0;
        // method that print the data of student (name , email, id)
        public void print_Data()
        {
            Console.WriteLine("Your Name Is   : {0}", Name);
            Console.WriteLine("Your Phone Is  : {0}", Phone);
            Console.WriteLine("Your E_Mail Is : {0}", Email);
            Console.WriteLine("Your ID Is     : {0}", ++Id);
        }
    }
}
