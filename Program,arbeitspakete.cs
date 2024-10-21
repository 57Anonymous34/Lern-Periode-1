namespace Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Begrüßung und Auswahlmenü
            Console.WriteLine("Willkommen zum Rechenprogramm!");
            Console.WriteLine("Bitte wählen Sie aus, was Sie tun möchten:");
            Console.WriteLine("1 - Addieren");
            Console.WriteLine("2 - Subtrahieren");
            Console.WriteLine("3 - Dividieren");
            Console.WriteLine("4 - Multiplizieren");
            Console.WriteLine("5 - Notendurchschnitt berechnen");

            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    double sum = PerformOperation("Addition");
                    Console.WriteLine($"Ergebnis der Addition: {sum}");
                    break;
                case "2":
                    double diff = PerformOperation("Subtraktion");
                    Console.WriteLine($"Ergebnis der Subtraktion: {diff}");
                    break;
                case "3":
                    double quotient = DivideNumbers();
                    Console.WriteLine($"Ergebnis der Division: {quotient}");
                    break;
                case "4":
                    double product = PerformOperation("Multiplikation");
                    Console.WriteLine($"Ergebnis der Multiplikation: {product}");
                    break;
                case "5":
                    double average = PerformOperation("Durchschnitt");
                    Console.WriteLine($"Ihr Notendurchschnitt beträgt: {average}");
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte starten Sie das Programm erneut und wählen Sie eine gültige Option.");
                    break;
            }
        }

        // Allgemeine Methode für Addition, Subtraktion, Multiplikation und Durchschnitt
        static double PerformOperation(string operation)
        {
            Console.WriteLine($"Wie viele Zahlen möchten Sie für die {operation} eingeben?");
            int count = Convert.ToInt32(Console.ReadLine());

            double result = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Zahl {i}:");
                double number = GetValidNumber();

                switch (operation)
                {
                    case "Addition":
                        result += number;
                        break;
                    case "Subtraktion":
                        if (i == 1)
                            result = number;
                        else
                            result -= number;
                        break;
                    case "Multiplikation":
                        if (i == 1)
                            result = number;
                        else
                            result *= number;
                        break;
                    case "Durchschnitt":
                        result += number;
                        break;
                }
            }

            // Für den Durchschnitt muss das Ergebnis durch die Anzahl geteilt werden
            if (operation == "Durchschnitt")
            {
                result /= count;
            }

            return result;
        }

        // Methode für Division
        static double DivideNumbers()
        {
            Console.WriteLine("Zahl 1:");
            double dividend = GetValidNumber();
            Console.WriteLine("Zahl 2 (nicht null):");
            double divisor;
            do
            {
                divisor = GetValidNumber();
                if (divisor == 0)
                    Console.WriteLine("Bitte eine Zahl ungleich null eingeben.");
            } while (divisor == 0);

            return dividend / divisor;
        }

        // Methode zum validieren der Eingabe
        static double GetValidNumber()
        {
            double number;
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    return number;
                }
                Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Zahl eingeben.");
            }
        }
    }
}

