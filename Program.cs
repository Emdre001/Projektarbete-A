namespace Projektarbete_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0;
            int numarticle = 0;

            Console.WriteLine("Welcome to the Shop!");
            do
            {
                Console.WriteLine("Enter a number between 1 and 10");
                var v = Console.ReadLine();
                i1 = int.Parse(v);
                numarticle = i1;

            }
            while (i1 < 1 || i1 > 10);

            string[] names = new string[numarticle];
            double[] prices = new double[numarticle];
            double total = 0;

            for (int i = 0; i < numarticle; i++)
            {
                Console.WriteLine($"Enter name and price for article {i + 1} seperated by a space (example: Gum 12,99)");

                string input = Console.ReadLine();
                string[] inputParts = input.Split(' ');

                if (inputParts.Length == 2 && double.TryParse(inputParts[1], out prices[i]) && prices[i] >= 0)
                {
                    names[i] = inputParts[0];
                    total += prices[i];
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                    i--;
                }
            }

            double vat = 0.25 * total;

            Console.WriteLine("\n Receipt:");
            Console.WriteLine("--------------------");
            for (int i = 0; i < numarticle; i++)
            {
                Console.WriteLine($"{names[i],-10} {prices[i],20:C}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Total: {total:C}");
            Console.WriteLine($"Including VAT (25%): {vat:C}");
        }
    }
}