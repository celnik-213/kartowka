namespace kartk_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rok = 2024;
            if (rok % 4 == 0)
            {
                Console.WriteLine("Rok przestępny");
            }
            else
            {
                Console.WriteLine("Rok nieprzestępny");
            }
        }
    }
}//kod działa poprawnie
