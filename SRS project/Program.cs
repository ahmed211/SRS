using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_project
{
    class Program
    {
        static void Main(string[] args)
        {
            professor[] P = new professor[100];                // array of objects from  prfessor class
            Student[] S = new Student[100];                    // array of objects from  student class
            Student[] SS = new Student[100];                   // array of objects from  student class
            Cours[] C = new Cours[50];                         // array of objects from  Cours class
            Cours[] CC = new Cours[50];                        // array of objects from  Cours class
            professor[] PP = new professor[50];                // array of objects from  prfessor class
            int n = 0;                                         // counter
            int choise, NCourse, choise_course, choise_prof;
            while (true)
            {
                Console.WriteLine("chose your case");
                Console.WriteLine("1. new student");
                Console.WriteLine("2. old student");
                Console.WriteLine("3. exit");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        S[n] = new Student();
                        C[n] = new Cours();
                        P[n]=new professor();
                        Console.WriteLine("Enter your ( name, phone , E_Mail )");
                        Console.Write("Name  : ");
                        S[n].Name = Console.ReadLine();
                        Console.Write("Phone : ");
                        S[n].Phone = Console.ReadLine();
                        Console.Write("Email : ");
                        S[n].Email = Console.ReadLine();
                        Console.WriteLine("Your ID : {0}", n+1);
                        Console.WriteLine("_________________________________");
                        Console.WriteLine("The Courses :-");
                        C[n].print();
                        Console.WriteLine("_________________________________");
                        Console.WriteLine("All Prpfessors :-");
                        P[n].print();
                        Console.WriteLine("_________________________________");
                        Console.Write("Enter the No of Courses Of The Year : ");
                        NCourse = int.Parse(Console.ReadLine());
                        CC[n]= new Cours(NCourse);                             //make an array of course his length is (NCourse)
                        PP[n] = new professor(NCourse);                        //make an array of professpr his length is (NCourse)
                        Console.WriteLine("Enter the NO Of Course And Professor that You Want :-");
                        for (int i = 0; i < NCourse; i++)
                        {
                            Console.Write("The No Of Course No {0}  :-  ",i+1);
                            choise_course = int.Parse(Console.ReadLine());     // take the course number in the list from user
                            CC[n].cours[i] = CC[n].add(choise_course);         // pass the course number to the method add and return the name of the course  
                            Console.Write("The No Of professor No {0}  :-   ", i+1);
                            choise_prof = int.Parse(Console.ReadLine());
                            PP[n].prof[i] = PP[n].add(choise_prof);            // take the professor number in the list from user
                            CC[n].b[i] = PP[n].prof[i];                        // pass the professor number to the method add and return the name of the course
                        }
                        Console.WriteLine();
                        Console.WriteLine("_________________________________");
                        S[n].print_Data();                                     // print the data of student (name , email, id)
                        Console.WriteLine();
                        CC[n].print_Enter_Courses();                           // print the courses that student take

                        Console.WriteLine();
                        Console.WriteLine("_________________________________");
                        Console.WriteLine();
                        n++;
                        break;
                    case 2:
                        try
                        {
                            Console.Write("Enter Your ID : ");
                            int x = int.Parse(Console.ReadLine());          // take the id number from user
                            Console.WriteLine(".................................");
                            S[x - 1].print_Data();                          // print the data of student of this id(name , email, id)
                            Console.WriteLine(".................................");
                            CC[x - 1].print_Enter_Courses();                // print the courses that student take of this id
                            Console.WriteLine();
                            Console.WriteLine("_________________________________");
                            Console.WriteLine();
                            break;
                        }
                        catch(NullReferenceException)
                        {
                            Console.WriteLine("This ID Is Not Available");
                            Console.WriteLine();
                            Console.WriteLine("_________________________________");
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        return;

                }

            }
        }
    }
}
