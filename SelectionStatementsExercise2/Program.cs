namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");

            var userinput = Console.ReadLine();

            switch (userinput)
            {
                case "Science":
                    Console.WriteLine("Science is a great subject!");
                    break;

                case "Math":
                    Console.WriteLine("Math is cool!");
                    break;

                case "Social Studies":
                    Console.WriteLine("I love Social Studies too!");
                    break;

                case "English":
                    Console.WriteLine("English is a wonderful subject!");
                    break;

                case "History":
                    Console.WriteLine("I also love learning about History!");
                    break;

                default:
                    Console.WriteLine("Hmmm I'm not familiar with that one.");
                    break;

            }
        }
    }
}