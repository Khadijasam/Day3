using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Student
    {
        
        public static void GetData()
        {
            int mrks,rno;
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter the course");
            string crs = Console.ReadLine();
            Console.WriteLine("Enter the roll no");
            rno =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks");
            mrks = int.Parse(Console.ReadLine());
            

        }
        public static char CalGrade(int mrks)
        {
            if(mrks>=75&&mrks<=100)
            {
                return ('A');

            }
            else if(mrks>=60&&mrks<75)
            {
                return ('B');
            }
            else if (mrks >= 500 && mrks <=59)
            {
                return ('C');
            }
            else if (mrks >= 0 && mrks <=49)
            {
                return ('F');
            }
            return ('0');
        }
        public static void ShowData(string name,string crs, int rno, int mrks)
        {
            Console.WriteLine("name:{ 0}", name);
            Console.Read();
           
            Console.WriteLine("course:{ 0}", crs);
            Console.Read();
            Console.WriteLine("roll no:{ 0}", rno);
            Console.Read();
            Console.WriteLine("marks:{ 0}", mrks);
            Console.Read();
            //Console.WriteLine("grade:{ 0}", grade);
            //Console.Read();

        }



    }
}
