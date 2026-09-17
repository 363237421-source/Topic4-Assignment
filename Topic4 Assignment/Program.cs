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
            int grade, average;

            Console.WriteLine("First name please.");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name please.");
            lastName = Console.ReadLine();
            Console.WriteLine("Login account please.");
            login = Console.ReadLine();

        }

        public static void Main(string[] args)
        {

            part2();

            part1();
         
        }
    }
}
