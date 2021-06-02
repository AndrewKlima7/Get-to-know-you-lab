using System;
using System.Collections.Generic;

namespace Get_To_Know_You_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {
                bool wrongInput = true;
                while (wrongInput == true)
                {
                    List<string> students = new List<string>() { "Andrew", "Mark", "James", "Tommy", "Maggie", "Jerome", "Trent", "Troy", "Kevin", "Joshua", "Sean", "Kate" };
                    PrintWholeList(students);                    

                    int inputStudent = GetuserInput("Please a pick a student, any number between 1 and 12 please: ");
                    if (inputStudent > 12 || inputStudent <= 0)
                    {
                        Console.WriteLine("Must be  number between 1-12.");
                        wrongInput = true;
                    }
                    else
                    {
                        wrongInput = false;
                        GetOutput(inputStudent);
                        continue;
                    }
                }
                again = GoAgain();
            }
        }

        public static int GetuserInput(string inputType)
        {
            int input;
            Console.WriteLine(inputType);
            input = int.Parse(Console.ReadLine());
            return input;
        }

        public static void PrintWholeList(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i]}");
            }
        }

        public static bool GetOutput(int inputStudent)
        {   
           List<string> students = new List<string>() { "Andrew", "Mark", "James", "Tommy", "Maggie", "Jerome", "Trent", "Troy", "Kevin", "Joshua", "Sean", "Kate" };
           List<string> hometowns = new List<string>() { "Grayslake", "Grand Rapids", "Toledo", "Raleigh NC", "Montrose, MI", "Milwaukee, WI", "Rochester, MI", "Indian River, Mi", "Detroit", "Northville, MI", "Eaton Rapids MI", "Zeeland, MI" };
           List<string> foods = new List<string>() { "Sushi", "Cilantro", "Sushi", "Chicken Curry", "Movie Theatre Popcorn", "Italian Cuisine", "Tacos", "Broccoli", "Asain cuisine", "Nalesniki", "MEAT", "Pizza" };

           Console.WriteLine($"That student is {students[inputStudent - 1]}");
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                string learn = Console.ReadLine();
                

                if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                {
                    bool another = true;
                    Console.WriteLine($"{students[inputStudent - 1]}'s hometown is {hometowns[inputStudent - 1]}");

                    while (another == true)
                    {
                        Console.WriteLine("Would you like to learn more? ");
                        string more = Console.ReadLine();

                        if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                        {
                            Console.WriteLine($"{students[inputStudent - 1]}'s favorite food is {foods[inputStudent - 1]}");
                            another = false;
                            repeat = false;
                            continue;
                        }
                        else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                        {
                            Console.WriteLine("okay then");
                            Console.WriteLine();
                            another = false;
                            repeat = false;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                        }
                    }
                }
                else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                {
                    bool another = true;
                    Console.WriteLine($"{students[inputStudent - 1]}'s favorite food is {foods[inputStudent - 1]}");

                    while (another == true)
                    {
                        Console.WriteLine("Would you like to learn more? ");
                        string more = Console.ReadLine();

                        if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                        {
                            Console.WriteLine($"{students[inputStudent - 1]}'s hometown is {hometowns[inputStudent - 1]}");
                            another = false;
                            repeat = false;
                            continue;
                        }
                        else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                        {
                            Console.WriteLine("okay then");
                            Console.WriteLine();
                            another = false;
                            repeat = false;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Not valid");
                            another = true;
                        }
                    }
                }
                else
                {
                    repeat = true;
                }
            }
            return false;    
        } 
       
        public static bool GoAgain()
        {
            Console.Write("Would you like to learn about another student? ");
            string input = Console.ReadLine();

            if (input.ToUpper() == "Y" || input.ToUpper() == "YES")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                return true;
            }
            else if (input.ToUpper() == "N" || input.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Must input a valid response.");
                return GoAgain();
            }
        }

        //this is for validation i didnt use it but will be useful in the future
        public static bool IsValidIndex(int collectionLength, int index)
        {
            if (index >= 0 && index < collectionLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
