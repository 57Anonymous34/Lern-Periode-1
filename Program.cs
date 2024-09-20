namespace Zahlenraten_Spiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -Addieren-

            Console.WriteLine("___Addierung___");
            Console.WriteLine("Zahl1:");
            string Aigel = Console.ReadLine();
            double a = Convert.ToDouble(Aigel);
            
            Console.WriteLine("Zahl2:");
            string Bigel = Console.ReadLine();
            double b = Convert.ToDouble(Bigel); 

            Console.WriteLine("Zahl3:");
            string Cigel = Console.ReadLine();
            double c = Convert.ToDouble(Cigel);

            // Verarbeitung
            double d = a + b + c;
            Console.WriteLine($"-Lösungen:{d}");

            
            
            
            // -Subraction-
            
            Console.WriteLine("\n___Subtraction___");
            Console.WriteLine("Zahl1:");
            string Aagel = Console.ReadLine();
            double e = Convert.ToDouble(Aagel);

            Console.WriteLine("Zahl2:");
            string Bagel = Console.ReadLine();
            double f = Convert.ToDouble(Bagel);
            
            // Verarbeitung
            double g = e - f;
            Console.WriteLine($"-lösungen:{g}");

            
           
            
            // -Dividieren-
           
            Console.WriteLine("\n___Dividerung___");
            Console.WriteLine("Zahl1:");
            string Auto = Console.ReadLine();
            double h = Convert.ToDouble(Auto);

            Console.WriteLine("Zahl2:");
            string Buto = Console.ReadLine();
            double i= Convert.ToDouble(Buto);
            // Verarbeitung
            double j = h / i;
            Console.WriteLine($"-Lösung:{j}");

            
            
         

            // -Multiplikation-
            
            Console.WriteLine("\n___Multiplikation___");
            Console.WriteLine("Zahl1:");
            string Aingabe = Console.ReadLine();
            double k = Convert.ToDouble(Aingabe);

            Console.WriteLine("Zahl2:");
            string Bingabe = Console.ReadLine();
            double l = Convert.ToDouble(Bingabe);

            Console.WriteLine("Zahl3:");
            string Cingabe = Console.ReadLine();
            double m = Convert.ToDouble(Cingabe);
           
            // Verarbeitung
            double n = k * l * m;
            Console.WriteLine($"-Lösung:{n}");




            //Notendurchschnitt
            Console.WriteLine("\n\nNotenberechner");
            Console.WriteLine("\nGeben ihre Note ein ein:");
            string eingabe = Console.ReadLine();
            double Note1 = Convert.ToDouble(eingabe);

            Console.WriteLine("Geben sien die andere Note ein:");
            string Zahl1 = Console.ReadLine();
            double Note2 = Convert.ToDouble(Zahl1);


            // Verarbeitung
            double rechnung = (Note1 + Note2 );
            double Resultat = (rechnung / 2);

            Console.WriteLine($"Ihr durchschnitt beträgt:{Resultat}");


        }
    }
}