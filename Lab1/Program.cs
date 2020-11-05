using System;
using System.Globalization;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Problems for:  Basic User Interaction and Data-Parsing


            #region //Name
            string name = String.Empty;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your name: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Hello, {name}");
            #endregion

            #region //Birthday
            string dobInput = String.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your date-of-birth: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            dobInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            //To use the var 'dob' as an output in the TryParse() method, the var 'dob'
            //must be initialized with some 'valid' value
            DateTime dob = DateTime.MinValue;

            if (DateTime.TryParse(dobInput, out dob))
            {
                Console.WriteLine($"Your birthday is  {dob.ToShortDateString()}  which was a {dob.DayOfWeek}.");
            }
            else
            {
                Console.WriteLine("That is an invalid birthday!");
            }
            #endregion


            //Prof Schurter: If a program is written using an older version of C# (say anything below v7)
            //would features in newer versions be available? For instance, setting 'int' as 'default' - could
            //such a method be used in C# 'version X < version 7'?
            #region //ID
            string inputID = String.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your student ID: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            inputID = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            //Validate the value of 'studentID' and output appropriate response:
            if (int.TryParse(inputID, out int outID))
            {
                Console.WriteLine($"Your studentID is: {outID}");
            }
            else
            {
                Console.WriteLine("That is an invalid studentID!");
            }
            #endregion

            #region //Salary
            string salaryIn = String.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Please enter your salary: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            salaryIn = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;


            if (decimal.TryParse(salaryIn, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal salaryOut) == true)
            {
                //Where {0:13} represents {salaryOut, formatCode 'Currency2decimalPlaces}
                Console.WriteLine("Your salary is: {0:C2}", salaryOut); 
            }
            else
            {
                Console.WriteLine("That was an invalid salary!");
            }
            #endregion

            #region //Employment Status
            string employedIn = string.Empty;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Are you currently employed? [True/False]");
            Console.ForegroundColor = ConsoleColor.Magenta;
            employedIn = (Console.ReadLine()).ToUpper();
            Console.ForegroundColor = ConsoleColor.White;

            
            try
            {
                Convert.ToBoolean(employedIn, CultureInfo.CurrentCulture);
                
                if (Convert.ToBoolean(employedIn, CultureInfo.CurrentCulture) == true )
                {
                    Console.WriteLine($"Yes - your are employed.");
                }
                else if (Convert.ToBoolean(employedIn, CultureInfo.CurrentCulture) == false)
                {
                    Console.WriteLine($"No - you are not employed.");
                }
                else
                {
                    Console.WriteLine("Invalid entry - your employment status remains unclear.");
                }
           }
           catch
           { 
               Console.WriteLine("Invalid entry - your employment status remains unclear."); 
           }
  
            #endregion

            #endregion


            #region //Problems for: Math Operations

            #region    //Problem #1:
            double width = 6.5;
            double height = 3.0;
            double answer1 = width * height;

            Console.WriteLine($"#1 <{answer1}>");
            #endregion


            #region //Problem #2
            double radius = 7.1;
            double area = Math.PI * Math.Pow(radius,2);
            //Formatting answer to only show two-decimal-places
            Console.WriteLine("#2 <{0:N}>", area);
            #endregion

            #region //Problems #3.1, #3.2 , #3.3
            for (int loopCount = 1; loopCount < 4; loopCount++) {
                
                double x1 = default;
                double y1 = default;
                double x2 = default;
                double y2 = default;
                double sum1 = default;
                double sum2 = default;
                double finalSum = default;

                switch (loopCount)
                {
                    case 1:
                            x1 = 2;
                            y1 = 5;
                            x2 = -3;
                            y2 = 7;
                            sum1 = x2 - x1;
                            sum2 = y2 - y1;
                         finalSum = Math.Sqrt(Math.Pow(sum1, 2) + Math.Pow(sum2, 2));
                        //Formatting answer to show only two-decimal-places
                        Console.WriteLine("#3.{1} <{0:N}>", finalSum, loopCount);
                        break;

                    case 2:
                        x1 = -5;
                        y1 = 4;
                        x2 = 1;
                        y2 = 0;
                        sum1 = x2 - x1;
                        sum2 = y2 - y1;
                         finalSum = Math.Sqrt(Math.Pow(sum1, 2) + Math.Pow(sum2, 2));
                        //Formatting answer to show only two-decimal-places
                        Console.WriteLine("#3.{1} <{0:N}>", finalSum, loopCount);
                        break;

                    case 3:
                        x1 = 6;
                        y1 = -2;
                        x2 = -4;
                        y2 = -6;
                        sum1 = x2 - x1;
                        sum2 = y2 - y1;
                         finalSum = Math.Sqrt(Math.Pow(sum1, 2) + Math.Pow(sum2, 2));
                        //Formatting answer to show only two-decimal-places
                        Console.WriteLine("#3.{1} <{0:N}>", finalSum, loopCount);
                        break;
                }
            }
            #endregion

            #endregion

            Console.WriteLine("Press <ENTER> to quit...");
            Console.ReadLine();
        }
    }
}
