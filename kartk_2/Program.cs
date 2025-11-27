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
                if (litera == 'a' || litera == 'ą' || litera == 'e' || litera == 'ę' || litera == 'i' ||
                  litera == 'o' || litera == 'ó' || litera == 'u' || litera =='y')
                {
                    licznik++;
                }
            }
            Console.WriteLine($"Liczba samogłosek: {licznik}");
        }
    }
}
//W kodzie brakowało spółgłosek diakrytycznych, zostały one dodane aby program liczył wszystkie samogłoski w języku polskim.