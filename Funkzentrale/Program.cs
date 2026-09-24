namespace Funkzentrale
{
    internal class Program
    {
        // declaration and signatur


        static void Main(string[] args)
        {

            string text = "Magna la merda";


            ChiffrierVerfahren chiff = Chiffren.Ruckwaerts;
            chiff += Chiffren.VokaleZuSterne;
            chiff += Chiffren.Leet;


            Console.WriteLine(Chiffren.Ruckwaerts(text));
            Console.WriteLine(Chiffren.VokaleZuSterne(text));
            Console.WriteLine(Chiffren.Leet(text));

            Console.WriteLine();
            Console.WriteLine();


            Zentrale.Senden("Zentrale", "Lage unklar", Chiffren.Ruckwaerts);
            Zentrale.Senden("Zentrale", "Lage unklar", Chiffren.Leet);


            Console.WriteLine();
            Console.WriteLine();
            Agent falke = new Agent("Falke", Chiffren.Ruckwaerts);
            Agent nachtigall = new Agent("Nachtigall", Chiffren.Ruckwaerts);

            falke.Melden("Der Kurier ist unterwegs");
            nachtigall.Melden("Treffen um acht");

            Zentrale.Senden("Falke", "Der Kurier ist unterwegs", Chiffren.Ruckwaerts);

        }

    }
}
