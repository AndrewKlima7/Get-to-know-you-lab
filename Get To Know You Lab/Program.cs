using System;
using System.Collections.Generic;
using System.IO;

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
                    string filePath = @"whole class.txt";
                    StreamReader read = new StreamReader(filePath);
                    string output = read.ReadToEnd();

                    string[] lines = output.Split('\n');
                    List<students> student = new List<students>();
                    foreach(string line in lines)
                    {
                        students stu = ConvertToStudent(line);
                        if(stu != null)
                        {
                            student.Add(stu);
                        }
                    }
                    foreach(students s in student)
                    {
                        Console.WriteLine($"{s.Name}");
                    }

                    int inputStudent = GetuserInput($"Please a pick a student, any number between 0 and {student.Count - 1} please: ");
                    if (inputStudent > student.Count - 1 || inputStudent <= -1)
                    {
                        Console.WriteLine($"Must be  number between 0-{student.Count - 1}");
                        wrongInput = true;
                    }
                    else
                    {
                        wrongInput = false;
                        students s = student[inputStudent];
                        GetOutput(s);
                        read.Close();
                        continue;
                    }                   
                }
                
                Console.WriteLine("Now lets add a new student");
                AddStudent();
                again = GoAgain();
            }
        }

        public static void AddStudent()
        {
            string filePath = @"whole class.txt";
            students s = new students();
            Console.WriteLine("Please input a name for the new student");
            s.Name = Console.ReadLine();

            Console.WriteLine($"Please input {s.Name}'s Hometown");
            s.HomeTown = Console.ReadLine();

            Console.WriteLine($"Please input {s.Name}'s favorite food");
            s.FavoriteFood = Console.ReadLine();

            string line = StudentToString(s);
            Console.WriteLine(line);

            StreamReader reader = new StreamReader(filePath);
            string original = reader.ReadToEnd();
            reader.Close();

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(original + line);
            writer.Close();
        }

        public static string StudentToString(students s)
        {
            string output = $"\n{s.Name}, {s.HomeTown}, {s.FavoriteFood}";
            return output;
        }

        public static students ConvertToStudent(string line)
        {
            string[] prop = line.Split(',');
            students s = new students();

            if(prop.Length == 3)
            {
                s.Name = prop[0];
                s.HomeTown = prop[1];
                s.FavoriteFood = prop[2];
                return s;
            }
            else
            {
                return null;
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

        public static bool GetOutput(students student)
        {

            Console.WriteLine($"That student is {student.Name}");
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Would you like to learn about their hometown or favorite food? ");
                string learn = Console.ReadLine();

                if (learn.ToLower() == "hometown" || learn.ToLower().Contains("home"))
                {
                    bool another = true;
                    Console.WriteLine($"{student.Name}'s hometown is {student.HomeTown}");

                    while (another == true)
                    {
                        Console.WriteLine("Would you like to learn more? Y/N ");
                        string more = Console.ReadLine();

                        if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                        {
                            Console.WriteLine($"{student.Name}'s favorite food is {student.FavoriteFood}");
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
                    Console.WriteLine($"{student.Name}'s favorite food is {student.FavoriteFood}");

                    while (another == true)
                    {
                        Console.WriteLine("Would you like to learn more? Y/N");
                        string more = Console.ReadLine();

                        if (more.ToLower() == "yes" || more.ToLower().Contains("y"))
                        {
                            Console.WriteLine($"{student.Name}'s hometown is {student.HomeTown}");
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
            Console.Write("Would you like to learn about another student? Y/N");
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
