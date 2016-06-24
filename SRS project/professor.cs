using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_project
{
    class professor : Student
    {
        public int i;
        public string[] prof;
        public professor(int size)
        {

            prof = new string[size];
        }
        public professor() { i = 0; }


        // method that contain all professors .
        // take the number of professor and return the name of course
        public string All_Prof(int SNum)
        {
            string[] ALL_PROF = new string[] {"Farouk Shaban","Magdy EL Henawy","Hussin Rady","Mohammed EL Zwidy",
            "Emad EL Dine Osman","Khaled EL Menshawy","Mohameed Mostafa","Fahima Abd EL Twab"};
            return ALL_PROF[SNum];
        }

        // method that add new professor by take the number of professor
        public string add(int num)
        {
            string prof = All_Prof(num);
            Console.WriteLine(prof);
            return prof;
            
        }


        // method print the list of all professors
        public void print()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("{0}. {1}", i, All_Prof(i));
            }
        }
    }
}
