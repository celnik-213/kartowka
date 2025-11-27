namespace kartk_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string slowo = "programowanie";
            int licznik = 0;
            foreach (char litera in slowo)

            {
                if (litera == 'a' || litera == 'e' || litera == 'i' ||
                  litera == 'o' || litera == 'u')
                {
                    licznik++;
                }
            }
            Console.WriteLine($"Liczba samogłosek: {licznik}");
        }
    }
}
