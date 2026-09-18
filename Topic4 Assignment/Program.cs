namespace Topic4_Assignment
{
    internal class Program
    {
        public static void part1()
        {
            string name;

            Console.Write("Hello, what is your name? ");
            name = Console.ReadLine();

            int age;
            Console.WriteLine("Hi, " + name + " how old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So you are " + age + " years old, hmm? Your life has gone by in an instant huh?");

            double price;
            Console.WriteLine("Say, how much do you make an hour " + name);
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("Wow, " + price.ToString("C") + " is quite a bit of cash you are making. hourly");
            Console.WriteLine("Well, I hope have a wonderful and blessed life " + name);


        }

        public static void part2()
        {
            Console.WriteLine("I will be gathering information from you, please answer truthfully.");

            string firstName, lastName, login;
            int grade, ID;
            double average;

            Console.WriteLine("First name please.");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name please.");
            lastName = Console.ReadLine();
            Console.WriteLine("Login account please.");
            login = Console.ReadLine();
            Console.WriteLine("What is your ID number?");
            Int32.TryParse (Console.ReadLine(), out ID);
            Console.WriteLine("What grade are you? (9-12)");
            Int32.TryParse(Console.ReadLine(),out grade);
            while (grade < 8)
            {
                Console.WriteLine("Sorry but your grade must be over 8, please try again!");
                Int32.TryParse(Console.ReadLine(), out grade);
            }
            Console.WriteLine("What are you averaging right now?");
            Double.TryParse(Console.ReadLine()  ,out average);
            Console.WriteLine("Thank you for your information! =)");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Your information:");
            Console.WriteLine("\t Login: " + login);
            Console.WriteLine("\t Name: " + firstName + " " + lastName);
            Console.WriteLine("\t Grade: " + grade);
            Console.WriteLine("\t ID: " + ID);
            Console.WriteLine("\t Average: " + average + "%");
            Console.ReadLine();
            Console.Clear();



        }

        public static void part3()
        {
            string name;
            int age;

            Console.Write("Hi there, what is your name? ");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hello, " + name + "." + " How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();

            Console.WriteLine("Did you know in five years you will be " + (age + 5) + " years old?");
            Console.WriteLine("And five years ago you were " + (age - 5) + "! Imagine that!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Main(string[] args)
        {

            part3();

            Console.ReadLine();

            part2();

            Console.ReadLine();

            part1();
         
        }
    }
}
