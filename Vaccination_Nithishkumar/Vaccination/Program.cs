using System;
using System.Collections.Generic;

namespace Vaccination
{
    class Program
    {
        static void Main(string[] args)
        {


            List<VaccineDetail> vaccineList = new List<VaccineDetail>();
            List<Benifier> benifierList = new List<Benifier>();
            do
            {
                Console.WriteLine("\nMAIN MENU:\n       1.REGISTER\n       2.LOGIN\n               ");
                Console.WriteLine("Enter your Choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    default:
                        break;



                }






            } while (true);             
            void Register()
             {
                Console.Write("Enter Name:");
                string userName = Console.ReadLine();
                Console.WriteLine("0.Other");
                Console.WriteLine("1.Male");
                Console.WriteLine("2.Female");
                Console.WriteLine("Enter Gender");
                string userGender1 = Console.ReadLine();
                var userGender = int.Parse(userGender1);
                Console.Write("Enter PhoneNumber:");
                String userPhoneNumber1 = Console.ReadLine();
                long userPhoneNumber = long.Parse(userPhoneNumber1);
                Console.Write("Enter Address:");
                string userCity = Console.ReadLine();
                Console.Write("Enter Age:");
                string userAge1 = Console.ReadLine();
                int userAge = int.Parse(userAge1);
                Console.Write("Enter registerNumber:");
                String registerNumber1 = Console.ReadLine();
                int registerNumber = int.Parse(registerNumber1);
                Benifier benifier = new Benifier(userName,userPhoneNumber,userCity,registerNumber, userGender,userAge);
                benifierList.Add(Benifier);
            }
            void Login()
            {
                Console.Write("Enter Register Number:");
                string registerNumber1 = Console.ReadLine();
                long registerNumber = long.Parse(registerNumber1);
                foreach(Benifier i in benifierList)
                {
                    if(RegisterId==registerNumber1)
                    {

                    }
                }
            }

        }

            } } 
          
