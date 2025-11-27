namespace kartk_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zdanie = "Programowanie w C# jest bardzo ciekawe";

            string[] slowa = zdanie.Split(' ');

            string najdluzsze = "";

            foreach (string slowo in slowa)

            {

                if (slowo.Length > najdluzsze.Length)

                {

                    najdluzsze = slowo;

                }

            }

            Console.WriteLine($"Najdłuższe słowo: {najdluzsze}");
        }
    }
}// Aby kod działa poprawnie należało zmienić w warunku na znak ">" gdyż najdłużsyz nie może mieć równego sobie 
