namespace kartk_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cenaNetto = 100;
            double vat = 1.23; // 23% 
            double cenaBrutto = cenaNetto * vat;
            Console.WriteLine($"Cena brutto: {cenaBrutto}");
        }
    }
}//w kodzie zmieniłem wartość vat z 0.23 na 1.23 aby poprawnie obliczyć cenę brutto dodając 23% do ceny netto
