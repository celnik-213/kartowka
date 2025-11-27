namespace Kartk_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = 0;

            if (liczba > 0)
            {
                Console.WriteLine("Liczba dodatnia");
            }
            if (liczba == 0)
            {
                Console.WriteLine("Liczba nieujemna niedodatnia");
            }
            else
            {
                Console.WriteLine("Liczba ujemna");
            }
        }
    }
}// zostało poprawione tak aby program działał zgodnie z założeniami czyli dodanie iż liczba 0 jest ani dodatnia ani ujemna
