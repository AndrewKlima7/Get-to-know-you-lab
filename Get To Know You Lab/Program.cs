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
                    List<string> hometowns = new List<string>() { "Grayslake", "Grand Rapids", "Toledo", "Raleigh NC", "Montrose, MI", "Milwaukee, WI", "Rochester, MI", "Indian River, Mi", "Detroit", "Northville, MI", "Eaton Rapids MI", "Zeeland, MI" };
                    List<string> foods = new List<string>() { "Sushi", "Cilantro", "Sushi", "Chicken Curry", "Movie Theatre Popcorn", "Italian Cuisine", "Tacos", "Broccoli", "Asain cuisine", "Nalesniki", "MEAT", "Pizza" };
                    PrintWholeList(students);                    

                    Console.WriteLine("Please a pick a student, any number between 1 and 11 please: ");
                    string input = Console.ReadLine();
                    int inputStudent = int.Parse(input);


                    if (inputStudent > 12 || inputStudent < 0)
                    {
                        Console.WriteLine("Must be  number between 1-12.");
                        wrongInput = true;
                    }
                    /* #1 */
                    else if (inputStudent == 1 || input == students[0])
                    {
                        Console.WriteLine($"That student is {students[0]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[0]}'s hometown is {hometowns[0]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[0]}'s favorite food is {foods[0]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[0]}'s favorite food is {foods[0]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[0]}'s hoemtown is {hometowns[0]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }

                    } /* #2 */
                    else if (inputStudent == 2 || input == students[1])
                    {
                        Console.WriteLine($"That student is {students[1]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[1]}'s hometown is {hometowns[1]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[1]}'s favorite food is {foods[1]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[1]}'s favorite food is {foods[1]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[1]}'s hoemtown is {hometowns[1]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    } /* #3 */
                    else if (inputStudent == 3 || input == students[2])
                    {
                        Console.WriteLine($"That student is {students[2]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[2]}'s hometown is {hometowns[2]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[2]}'s favorite food is {foods[2]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[2]}'s favorite food is {foods[2]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[2]}'s hoemtown is {hometowns[2]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    } /* #4 */
                    else if (inputStudent == 4 || input == students[3])
                    {
                        Console.WriteLine($"That student is {students[3]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[3]}'s hometown is {hometowns[3]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[3]}'s favorite food is {foods[3]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[3]}'s favorite food is {foods[3]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[3]}'s hoemtown is {hometowns[3]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    } /* #5 */
                    else if (inputStudent == 5 || input == students[4])
                    {
                        Console.WriteLine($"That student is {students[4]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[4]}'s hometown is {hometowns[4]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[4]}'s favorite food is {foods[4]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[4]}'s favorite food is {foods[4]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[4]}'s hoemtown is {hometowns[4]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    }/* #6 */
                    else if (inputStudent == 6 || input == students[5])
                    {
                        Console.WriteLine($"That student is {students[5]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[5]}'s hometown is {hometowns[5]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[5]}'s favorite food is {foods[5]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[5]}'s favorite food is {foods[5]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[5]}'s hoemtown is {hometowns[5]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    } /* #7 */
                    else if (inputStudent == 7 || input == students[6])
                    {
                        Console.WriteLine($"That student is {students[6]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[6]}'s hometown is {hometowns[6]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[6]}'s favorite food is {foods[6]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[6]}'s favorite food is {foods[6]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[6]}'s hoemtown is {hometowns[6]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    } /* #8 */
                    else if (inputStudent == 8 || input == students[7])
                    {
                        Console.WriteLine($"That student is {students[7]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[7]}'s hometown is {hometowns[7]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[7]}'s favorite food is {foods[7]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[7]}'s favorite food is {foods[7]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[7]}'s hoemtown is {hometowns[7]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    } /* #9 */
                    else if (inputStudent == 9 || input == students[8])
                    {
                        Console.WriteLine($"That student is {students[8]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[8]}'s hometown is {hometowns[8]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[8]}'s favorite food is {foods[8]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[8]}'s favorite food is {foods[8]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[8]}'s hoemtown is {hometowns[8]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    } /* #10 */
                    else if (inputStudent == 10 || input == students[9])
                    {
                        Console.WriteLine($"That student is {students[9]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[9]}'s hometown is {hometowns[9]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[9]}'s favorite food is {foods[9]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[9]}'s favorite food is {foods[9]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[9]}'s hoemtown is {hometowns[9]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    } /* #11 */
                    else if (inputStudent == 11 || input == students[10])
                    {
                        Console.WriteLine($"That student is {students[10]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[0]}'s hometown is {hometowns[0]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[10]}'s favorite food is {foods[10]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[10]}'s favorite food is {foods[10]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[10]}'s hoemtown is {hometowns[10]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    }
                    else if (inputStudent == 12 || input == students[11])
                    {
                        Console.WriteLine($"That student is {students[11]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[11]}'s hometown is {hometowns[11]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[11]}'s favorite food is {foods[11]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
                            {
                                bool another = true;
                                Console.WriteLine($"{students[11]}'s favorite food is {foods[11]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[11]}'s hoemtown is {hometowns[11]}");
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        wrongInput = false;
                                        repeat = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid");
                                        another = true;
                                    }
                                }
                            }
                        }
                    }
                    }
                again = GoAgain();
            }
        }

        public static void PrintWholeList(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i]}");
            }
        }

        /* public static string GetOutput(int inputStudent)
        {
            
                List<string> students = new List<string>() { "Andrew", "Mark", "James", "Tommy", "Maggie", "Jerome", "Trent", "Troy", "Kevin", "Joshua", "Sean" };
                List<string> hometowns = new List<string>() { "Grayslake", "Grand Rapids", "Toledo", "Raleigh NC", "Montrose, MI", "Milwaukee, WI", "Rochester, MI", "Indian River, Mi", "Detroit", "Northville, MI", "Eaton Rapids MI", "Zeeland, MI" };
                List<string> foods = new List<string>() { "Sushi", "Cilantro", "Sushi", "Chicken Curry", "Movie Theatre Popcorn", "Italian Cuisine", "Tacos", "Broccoli", "Asain cuisine", "Nalesniki", "MEAT", "Pizza" };
                bool wrongInput = true;
            while (wrongInput == true)
            {
                if (inputStudent > 11 || inputStudent < 0)
                {
                    Console.WriteLine("Must be  number between 1-11.");
                    wrongInput = true;
                }
                /* #1 
                else
                {
                    for (int i = inputStudent; i == inputStudent; i++)
                    {


                        Console.WriteLine($"That student is {students[i - 1]}");
                        bool repeat = true;
                        while (repeat == true)
                        {
                            Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                            string learn = Console.ReadLine();

                            if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                            {
                                bool another = true;
        Console.WriteLine($"{students[i - 1]}'s hometown is {hometowns[i - 1]}");

                                while (another == true)
                                {
                                    Console.WriteLine("Would you like to learn more? ");
                                    string more = Console.ReadLine();

                                    if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                                    {
                                        Console.WriteLine($"{students[i - 1]}'s favorite food is {foods[i - 1]}");
                                        another = false;
                                        repeat = false;
                                        wrongInput = false;                                        
                                        break;
                                    }
                                    else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
                                    {
                                        Console.WriteLine("okay then");
                                        Console.WriteLine();
                                        another = false;
                                        repeat = false;
                                        wrongInput = false;
                                        break;
                                    }
                                    else
{
    Console.WriteLine("Not valid");
    another = true;
}
                                }
                            }
                            else if (learn.ToLower() == "favoritefood" || learn.ToLower().Contains("food"))
{
    bool another = true;
    Console.WriteLine($"{students[i - 1]}'s favorite food is {foods[i - 1]}");

    while (another == true)
    {
        Console.WriteLine("Would you like to learn more? ");
        string more = Console.ReadLine();

        if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
        {
            Console.WriteLine($"{students[i - 1]}'s hoemtown is {hometowns[i - 1]}");
            another = false;
            repeat = false;
            wrongInput = false;
            break;
        }
        else if (more.ToLower() == "no" || more.ToLower().Contains("n"))
        {
            Console.WriteLine("okay then");
            Console.WriteLine();
            another = false;
            repeat = false;
            wrongInput = false;
            break;
        }
        else
        {
            Console.WriteLine("Not valid");
            another = true;
        }

    }


}
                           

                        }
                    }
                }
 
            }
            
            return GetOutput(inputStudent);
            
        } */
       
        public static bool GoAgain()
        {
            Console.Write("Would you like to learn about another student again? ");
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
    }
}
