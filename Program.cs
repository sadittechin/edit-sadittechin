using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Grade System =====");

        Console.Write("Enter Course ID: ");
        string courseId = Console.ReadLine();

        Console.Write("Enter Course Name: ");
        string courseName = Console.ReadLine();

        Course course = new Course(courseId, courseName);

        while (true)
        {
            Console.WriteLine("\n------ MENU ------");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Show Max Score");
            Console.WriteLine("4. Show Min Score");
            Console.WriteLine("5. Show Average Score");
            Console.WriteLine("6. Exit");

            Console.Write("Select Menu: ");
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a number.");
                continue;
            }

            if (choice == 1)
            {
                Console.Write("Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Student ID: ");
                string id = Console.ReadLine();

                Console.Write("Score: ");
                double score;

                if (!double.TryParse(Console.ReadLine(), out score))
                {
                    Console.WriteLine("Invalid score.");
                    continue;
                }

                Student s = new Student(name, id, score);
                course.AddStudent(s);

                Console.WriteLine("Student added successfully.");
            }

            else if (choice == 2)
            {
                Console.WriteLine("\nStudent List");
                course.ShowStudents();
            }

            else if (choice == 3)
            {
                course.ShowMaxScore();
            }

            else if (choice == 4)
            {
                course.ShowMinScore();
            }

            else if (choice == 5)
            {
                course.ShowAverageScore();
            }

            else if (choice == 6)
            {
                Console.WriteLine("Exit Program...");
                break;
            }

            else
            {
                Console.WriteLine("Invalid menu.");
            }
        }
    }
}