using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //init varaible
            string name, father, grandFather, birthPlace, birthDate, job, marriage, livingPlace, fullName;
            string anotherJob, job2;
            int day, month, year, howManywife, ageSignin, phoneNumber;
            string correct;
            string wife2, wife3, wife4;
            string path;
            //Date
            DateTime now = DateTime.Now;
            //Getting User Input
            //Name
            Console.WriteLine("Name.");
            line();
            name = Console.ReadLine();
            line();
            Console.WriteLine("Father Name.");
            line();
            father = Console.ReadLine();
            line();
            Console.WriteLine("GrandFather Name.");
            line();
            grandFather = Console.ReadLine();
            line();
            fullName = $"{name}-{father}-{grandFather}";
            //Place of Birth
            Console.WriteLine("Place of birth.");
            line();
            birthPlace = Console.ReadLine();
            line();
            //Date of Birth
            Console.WriteLine("Date of birth.");
            line();
            repeat:
                Console.WriteLine("Day");
                day = Convert.ToInt32(Console.ReadLine());
                line();
                Console.WriteLine("Month");
                month = Convert.ToInt32(Console.ReadLine());
                line();
                Console.WriteLine("Year");
                year = Convert.ToInt32(Console.ReadLine());
                line();
                birthDate = ($"{day}-{month}-{year}");
                Console.WriteLine(birthDate);
                line();
                Console.WriteLine("Is it correct \"'yes' or 'no'\" ");
                line();
                correct = Console.ReadLine();
                if (correct == "yes")
                {
                    line();
                    Console.WriteLine("Date of birth has been assigned");
                    line();
                }
                else if (correct == "no")
                {
                    line();
                    Console.WriteLine("assigning date of birth again");
                    line();
                    goto repeat;
                }
                else
                {
                    line();
                    Console.WriteLine("Date of birth has been assigned");
                    line();
                }
            //Job
            Console.WriteLine("What is your Job currently");
            line();
            job = Console.ReadLine();
            line();
            Console.WriteLine("Have you worked any other job than this \"'yes' or 'no'\"");
            line();
            anotherJob = Console.ReadLine();
            line();
            if (anotherJob == "yes")
            {
                Console.WriteLine("What was it");
                line();
                job2 = Console.ReadLine();
            }
            else if (anotherJob == "no")
            {
                Console.WriteLine($"only {job}.");
                line();
            }
            else
            {
                Console.WriteLine($"only {job}.");
                line();
            }
            //Marriage
            Console.WriteLine("Are you married \"'yes' or 'no'\"");
            line();
            marriage = Console.ReadLine();
            line();
            if (marriage == "yes")
            {
                Console.WriteLine("Wife full name");
                line();
                marriage = Console.ReadLine();
                line();
                Console.WriteLine("How many wife did you married");
                line();
                howManywife = Convert.ToInt32(Console.ReadLine());
                line();
                if (howManywife > 1)
                {
                    if (howManywife == 2)
                    {
                        Console.WriteLine("Second Wife name");
                        line();
                        wife2 = Console.ReadLine();
                    }
                    if (howManywife == 3)
                    {
                        Console.WriteLine("Second Wife name");
                        line();
                        wife2 = Console.ReadLine();
                        line();
                        Console.WriteLine("Third Wife name");
                        line();
                        wife3 = Console.ReadLine();
                    }
                    if (howManywife == 4)
                    {
                        Console.WriteLine("Second Wife name");
                        line();
                        wife2 = Console.ReadLine();
                        line();
                        Console.WriteLine("Third Wife name");
                        line();
                        wife3 = Console.ReadLine();
                        line();
                        Console.WriteLine("Fourth Wife name");
                        line();
                        wife4 = Console.ReadLine();
                    }
                }
                else if (howManywife == 1)
                {
                    Console.WriteLine($"{marriage} is the only wife for {name} {father} {grandFather}");
                    line();
                }
            }
            else if (marriage == "no")
            {
                marriage = "single";
                Console.WriteLine(marriage);
                line();
            }
            //Living place
            Console.WriteLine("Where are you living currently");
            line();
            livingPlace = Console.ReadLine();
            line();
            //Phone number
            Console.WriteLine("Phone Number");
            line();
            phoneNumber = Convert.ToInt32(Console.ReadLine());
            line();
            //Age
            Console.WriteLine("How old are you.");
            line();
            ageSignin = Convert.ToInt32(Console.ReadLine());
            line();
            if (ageSignin >= 18)
            {
                Console.WriteLine("Your information will be seen soon wait for some weeks until the process finish.");
                line();
            }
            else if (ageSignin < 18)
            {
                Console.WriteLine("Your are not on the leagal age yet.");
                line();
                Console.WriteLine("Click enter to exit");
                line();
                Console.ReadLine();
                return;
            }
            //Generating random id number
            Random random = new Random();
            int genNum = random.Next(1000000000);
            //Genrate order number
            int ordNum = random.Next(1,1000000000);
            //Exporting user input to .txt file
            line();
            Console.WriteLine("-------------------------------------------------");
            line();
            Console.WriteLine($"Full Name:- {name} {father} {grandFather}");
            Console.WriteLine($"Date of birth:- {birthDate}");
            Console.WriteLine($"Current Job:- {job}");
            Console.WriteLine($"Wife:- {marriage}");
            Console.WriteLine($"Living place:- {livingPlace}");
            Console.WriteLine("Phone Number:- 0"+phoneNumber);
            Console.WriteLine($"ID number is :- {genNum}");
            line();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Order number is :- {ordNum}");
            //Creating the .txt file
            Console.WriteLine("Paste the path to where to export the text file");
            path = Console.ReadLine();
            try
            {
                TextWriter tw = new StreamWriter($"{path}/{fullName}-{genNum}-{ordNum}.txt", true);
                tw.WriteLine("Registration Date " + now);
                tw.WriteLine("-------------------------------------------------");
                line();
                tw.WriteLine($"Full Name:- {fullName}");
                tw.WriteLine($"Date of birth:- {birthDate}");
                tw.WriteLine($"Current Job:- {job}");
                tw.WriteLine($"Wife:- {marriage}");
                tw.WriteLine($"Living place:- {livingPlace}");
                tw.WriteLine($"Phone Number:- 0"+phoneNumber);
                tw.WriteLine($"ID number is :- {genNum}");
                line();
                tw.WriteLine("-------------------------------------------------");
                tw.WriteLine($"Order number is :- {ordNum}");
                tw.Close();
                Console.WriteLine("Form has been exported to .txt");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            //print the result
            Console.ReadKey();
            //our program ends here
            void line()
            {
                Console.WriteLine("\n");
            }
        }
    }
}