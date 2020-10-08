using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab_5_Selection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string results = Priority(3);
            //Console.WriteLine(results);

            int mark = 70;
            int stars = mark > 60 ? 3 : 4; //don't think this is right
        }

        public static string PassFail(int mark)
        {
            var grade = "Fail";
            
            if (mark >= 40)
            {
                grade = "Pass";
            }

            return grade;
        }

        public static string Grade(int mark)
        {
            var grade = "";

            if (mark >= 40)
            {
                grade = "Pass";
                if (mark >= 75)
                {
                    grade += " with Distinction";
                }
                else if (mark >= 60)
                {
                    grade += " with Merit";
                }
            }
            else
            {
                grade = "Fail";
            }

            return grade;
        }

        public static string Priority(int level)
        {
            string priority = "Code";

            switch (level)
            {
                case 3:
                    priority = priority + " Red";
                    break;
                case 2:
                case 1:
                    priority = priority + " Amber";
                    break;
                case 0:
                    priority = priority + " green";
                    break;
                default:
                    priority = "Error";
                    break;

            }
        }

        public static string PassFailTernary(int mark)
        {
            // if(condition) > then do this: otherwise do this
            return mark >= 40 ? "Pass" : "Fail";
        }

    }
}
