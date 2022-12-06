namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ask user for favorite subject
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            
            
            switch (subject)
            {
                case "Science":
                    Console.WriteLine("Man I hate Science.");
                    break;
                case "Math":
                    Console.WriteLine("Man I hate Math.");
                    break;
                case "English":
                    Console.WriteLine("Man I hate English.");
                    break;
                case "History":
                    Console.WriteLine("Man I hate History.");
                    break;
                case "Computer Science":
                    Console.WriteLine("Man I love Computer Science.");
                    break;
                default:
                    Console.WriteLine("School is for fools!");
                    break;
            }

        }
    }
}