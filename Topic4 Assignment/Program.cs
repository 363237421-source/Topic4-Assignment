namespace Topic4_Assignment
{
    internal class Program
    {
        public static void part1()
        {
            string name;

            Console.WriteLine("Part1");
            Console.WriteLine();

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
            Console.WriteLine("Part2");
            Console.WriteLine();
            

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
            Console.WriteLine("part3");
            Console.WriteLine();

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

        public static void part4()
        {
            Console.WriteLine("part4");
            Console.WriteLine();


            double firstNum, secondNum, thirdNum;

            Console.WriteLine("Hello, this is a dumb calculator.");
            Console.WriteLine("Please insert a number: ");
            Double.TryParse((Console.ReadLine()) ,out firstNum);
            Console.WriteLine("Please insert your second number: ");
            Double.TryParse((Console.ReadLine()), out secondNum);
            Console.WriteLine("Please insert your final number: ");
            Double.TryParse((Console.ReadLine()) , out thirdNum);
            Console.WriteLine("Thank you for your participation");

            Console.ReadLine();
            Console.Clear();

            
            Console.WriteLine("The answer is... " + ((firstNum + secondNum + thirdNum)/2));
            Console.ReadLine();
            Console.Clear();
            
            
        }

        public static void part5()
        {
            Double price1, price2;
            string item1, item2;


            Console.WriteLine("Please do this so I can create your reciept!");
            Console.WriteLine();
            Console.WriteLine("What is the name of your first item?");
            item1 = Console.ReadLine();
            Console.WriteLine("What is the price of " + item1);
            Double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine("What is your second item");
            item2 = Console.ReadLine();
            Console.WriteLine("What is the price of " + item2);
            Double.TryParse(Console.ReadLine(), out price2);


            Console.WriteLine();
            Console.WriteLine("Sales Receipt");

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

            part5();

            Console.WriteLine();

            part4();

            Console.WriteLine();

            part3();

            Console.ReadLine();

            part2();

            Console.ReadLine();

            part1();
         
        }
    }
}
