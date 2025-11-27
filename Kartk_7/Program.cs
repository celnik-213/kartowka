namespace Kartk_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rzymska = "XLIX";
            Dictionary<char, int> wartosci = new Dictionary<char, int>
{
  {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}

};
            int wynik = 0;
            for (int i = 0; i < rzymska.Length; i++)
            {
                if (i < rzymska.Length - 1 &&
                  wartosci[rzymska[i]] < wartosci[rzymska[i + 1]])
                {
                    wynik -= wartosci[rzymska[i]];
                }
                else

                {
                    wynik += wartosci[rzymska[i]];
                }
            }
            Console.WriteLine($"Wynik: {wynik}");
        }
    }
}
// W kodzie zaimplementowano konwersję liczby rzymskiej na arabską, poprawiono dodając brakujące wartości do słownika.