namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Alexander Lundquist Klass: .NET 23

            //Definerar en int variabel för en siffta
            int number = 11;

            //Tittar om variabeln "number" är större än 10
            if (number > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj.Lågt tal!");
            }

            //Frågar användare vad ens namn är, Skriver sedan ut personens namn
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");


            // Loopen börjar på 0 och lägger till ett heltal varje loop så länge i är mindre eller lika med talet i variabeln number
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
