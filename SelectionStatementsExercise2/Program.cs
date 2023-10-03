namespace SelectionStatementsExercise2
{
    public class Program
    {

        static void FavSubject()
        {
            Console.WriteLine("What is you Favorite Subject?");
            string favSubject = Console.ReadLine();

            switch(favSubject = favSubject.ToLower())
            {
                case string x when favSubject.StartsWith("history"):
                    Console.WriteLine("History is the best.");
                    break;

                case string x when favSubject.StartsWith("music"):
                    Console.WriteLine("Music is nice.");
                    break;

                case string x when favSubject.StartsWith("english"):
                    Console.WriteLine("I fell asleep in English once.");
                    break;

                case string x when favSubject.StartsWith("spanish"):
                    Console.WriteLine("Spanish is fun.");
                    break;

                case string x when favSubject.StartsWith("math"):
                    Console.WriteLine("Math is boring.");
                    break;

                default:
                    Console.WriteLine("Sorry, I don't recognise that subject.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            FavSubject();
        }
    }
}