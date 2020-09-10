using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the Number to check Prime: ");
        //    int n = int.Parse(Console.ReadLine());
        //    PrimeNum.CheckPrime(n);
        //}

        static void Main(String[] args)
        {
            string sname="", scrs="";
            int smrks=0, srno=0;
            
            Student.GetData();
            Student.ShowData(sname, scrs, srno, smrks);
            Console.ReadLine();
            char grade = Student.CalGrade(smrks);
            Console.Read();
            //Student.ShowData(sname, scrs, srno, smrks, grade);
            
        }
    }
}
