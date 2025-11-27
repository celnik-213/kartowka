namespace kartk_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string haslo = "Haslo123!";
            bool maMalaLitere = false;
            bool maDuzaLitere = false;
            bool maCyfre = false;
            bool maZnakSpecjalny = false;
            foreach (char znak in haslo)
            {
                if (char.IsLower(znak)) maMalaLitere = true;
                if (char.IsUpper(znak)) maDuzaLitere = true;
                if (char.IsDigit(znak)) maCyfre = true;
                if (!char.IsLetterOrDigit(znak)) maZnakSpecjalny = true;
            }

            bool silneHaslo = maMalaLitere && maDuzaLitere && maCyfre && maZnakSpecjalny;

            Console.WriteLine(silneHaslo ? "Silne" : "Słabe");
        }
    }
}//Aby kod działał poprawnie, zmieniłem znak || na && w warunku określającym, czy hasło jest silne. Teraz hasło musi spełniać wszystkie kryteria, aby zostać uznane za silne.
