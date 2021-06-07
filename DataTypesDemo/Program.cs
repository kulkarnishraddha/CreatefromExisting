using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //data type keyword
            
            //string
            //Console.WriteLine("Enter your City");
            //tring city = Console.ReadLine();

            //int
            //Console.WriteLine("Enter you pincode:");
            //int pin = Convert.ToInt32(Console.ReadLine());

            //Collecting min integer
            //Console.WriteLine("Enter Country Code:");
            //short ccode = Convert.ToInt16(Console.ReadLine());

            //collecting max integer
            //Console.WriteLine("Enter your Phone Number");
            //long phone = Convert.ToInt64(Console.ReadLine());

            //collecting true or false
            //Console.WriteLine("Are you a citizen of India?");
            //bool IsCitizen = Convert.ToBoolean(Console.ReadLine());

            //collcting char values
            //Console.WriteLine("Enter your gender ('F' for female and 'M' for male)");  
           // char Gender = Convert.ToChar(Console.ReadLine());    

           // Console.WriteLine("=============================================");
            //Console.WriteLine("User input city is :" + city);
            //Console.WriteLine("And pincode is :" + pin);
            //Console.WriteLine("And Country Code is:" + ccode);
            //Console.WriteLine("And Phone Number is:" + phone);
            //Console.WriteLine("And He/She an Indian Citizen is:" + IsCitizen);
           // Console.WriteLine("And Gender is:" + Gender);
           // Console.WriteLine("=============================================");

           // Console.ReadLine();
           //Object -classname object name = new(keyword) class name

            Candidate candi = new Candidate();
            Console.WriteLine("Enter your candiate Sno:");
            candi.Sno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your candidate name:");
            candi.CName = Console.ReadLine();

            Console.WriteLine("Enter your candidate College name:");
            candi.CollegeName = Console.ReadLine();


            Console.WriteLine("Candidate Sno is : " + candi.Sno + " " + "Candidate Name is : " + candi.CName + "Candidate College Name :" + candi.CollegeName);
            Console.ReadLine();

        }

        
    }
    public class Candidate
    {
        public int Sno;
        public string CName;
        public long mobile;
        public string Email;
        public int Supersetid;
        public string CollegeName;
    }
}
