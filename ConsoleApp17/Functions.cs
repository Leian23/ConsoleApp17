using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpExercises
{
    class Functions
    {


        internal static string DisplayMenu()
        {
            string code;
            Console.WriteLine("\t\t\t\t\tStudent Attendance Management System\n");
            Console.WriteLine($"Date and Time today: {DateTime.Now.ToString()}\n");
            Console.WriteLine("Input '1' to logged for attendance");
            Console.WriteLine("Input '2' to display text in console\n");
            Console.WriteLine("Code: ");
            code = Console.ReadLine();
            return code;

        }

       


        internal static List<string> GetData() //will get data input from user that will be passed in data class for saving
        {
            List<string> dataList = new List<string>();


            string Name;


                Console.WriteLine("\nLast Name: ");
                string Lastname = Console.ReadLine();
                Console.WriteLine("First Name: ");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Middle Initial: ");
                string MiddleInitial = Console.ReadLine();

                if (Lastname.Length == 0 && FirstName.Length == 0 && MiddleInitial.Length == 0)
                {
                    Console.WriteLine("Inputs Cannot be blank, recent input has been saved");
                    ViewFile();
                }

                else if (Lastname.Length == 0)
                {
                    Console.WriteLine("Last Name cannot be blank");

                }
                else if (FirstName.Length == 0)
                {
                    Console.WriteLine("First Name cannot be blank");

                }

                else if (MiddleInitial.Length == 0)
                {
                    Console.WriteLine("Middle Initial cannot be blank");

                }

                Name = Lastname + " " + FirstName + " " + MiddleInitial;


                dataList.Add(Name);
          

                return dataList;
           
        }


        


        public static void ViewFile()
        {
            string read;
            Console.WriteLine("View File in Console?");
            read = Console.ReadLine();

            if (read.Equals("yes") || read.Equals("yes"))
            {
                Read();
            }

            else
            {
                Console.WriteLine("Okay...");
            }

        }


        public static void Read()
        {
            try
            {
                Console.WriteLine("Displaying your inputs in console....\n");
                DisplayData();
                Console.WriteLine("\nSuccesfully displayed");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        internal static void DisplayData()
        {
            List<string> dataContent = FileStream.ReadFile();

            foreach (var data in dataContent)
            {
                Console.WriteLine(data);
            }
        }


        internal static List<string> Datetime()
        {
            List<string> TimeData = new List<string>();
           

            string date = ($"{DateTime.Now.ToString()}");

            TimeData.Add(date);

            return TimeData;

        }


        internal static List<string> Validator()
        {
            List<string> Validate = new List<string>();

            string validation;


            if (Datetime() != null)

            {
                validation = "Present";
            }

            else
            {
                validation = "Absent";

            }

            Validate.Add(validation);

            return Validate;
        }
    }

}
