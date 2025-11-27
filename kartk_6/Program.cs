namespace kartk_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> lista2 = new List<int> { 1, 2, 3, 4, 5 };
            bool saRowne = lista1.SequenceEqual(lista2);
            Console.WriteLine(saRowne ? "Równe" : "Różne");
        }
    }
}
// W kodzie zostało zmienione porównanie list z użyciem metody SequenceEqual, która poprawnie porównuje zawartość dwóch list.