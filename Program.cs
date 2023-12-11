using System;
using System.Runtime.InteropServices.Marshalling;
using LAB5V2;

class Program
{
    static void Main(string[] args)
    {

        Twiek wiek = new Twiek();
        Tsamochod s1 = new Tsamochod();
        int wybor;
        bool wypelnioneDane = false;
        bool wypelnionyWiek = false;
        do
        {
            Console.WriteLine();
            Console.WriteLine($"---------MENU POJAZDU---------");
            Console.WriteLine($"1. WYSWIETL WIEK POJAZDU");
            Console.WriteLine($"2. WPISZ WIEK POJAZDU");
            Console.WriteLine($"3. WYSWIETL DANE DODATKOWE POJAZDU");
            Console.WriteLine($"4. WPROWADZ DANE DODATKOWE pojazdu");
            Console.WriteLine($"5. ZAKONCZ PROGRAM");
            Console.WriteLine($"");

            do
            {
                Console.Write("Wybierz opcję: ");
            } while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 1 || wybor > 5);

            switch (wybor)
            {
                case 1:
                    {
                        Console.WriteLine($"WYBRALES OPCJE 1");
                        if (wypelnionyWiek == false)
                        {
                            int odpowiedz;
                            Console.WriteLine($"Nie podałes jeszcze danych do wyswietlenia wieku");
                            Console.WriteLine();
                            Console.WriteLine($"Czy chcesz podac dane?");
                            Console.WriteLine("1. TAK");
                            Console.WriteLine("2. NIE");
                            odpowiedz = Convert.ToInt32(Console.ReadLine());
                            switch (odpowiedz)
                            {
                                case 1:
                                    {
                                        Console.WriteLine($"WYBIERZ OPCJE 2");
                                        break;
                                    }
                                case 2:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine($"Nieprawidlowa odp");
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Wiek pojazdu to: {wiek.Lata} lat," +
                                $" {wiek.Dni} dni {wiek.Godziny} godzin");
                        }

                        break;
                    }
                case 2:
                    {
                        wypelnionyWiek = true;

                        Console.WriteLine($"WYBRALES OPCJE 2");

                        Console.Write($"1. Podaj wiek pojazdu w latach: ");
                        wiek.Lata = Convert.ToInt32(Console.ReadLine());

                        Console.Write($"2. Podaj wiek pojazdu w dniach: ");
                        wiek.Dni = Convert.ToInt32(Console.ReadLine());

                        Console.Write($"3. Podaj wiek pojazdu w godzinach: ");
                        wiek.Godziny = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Wiek pojazdu to: {wiek.Lata} lat," +
                                $" {wiek.Dni} dni {wiek.Godziny} godzin");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"WYBRALES OPCJE 3");
                        if (wypelnioneDane == false)
                        {
                            Console.WriteLine($"Nie podałes jeszcze danych do ich wyswietlenia");
                            Console.WriteLine($"Czy chcesz podac dane?");
                            Console.WriteLine("1. TAK");
                            Console.WriteLine("2. NIE");
                            Console.WriteLine();
                            int odpowiedz = Convert.ToInt32(Console.ReadLine());
                            switch (odpowiedz)
                            {
                                case 1:
                                    {
                                        Console.WriteLine($"WYBIERZ OPCJE 4");
                                        break;
                                    }
                                case 2:
                                    {
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine($"Nieprawidlowa odp");
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Marka pojazdu to: {s1.Marka}, model to" +
                                $" {s1.Model} a moc to {s1.Moc} KM");
                        }
                        break;
                    }
                case 4:
                    {
                        wypelnioneDane = true;

                        Console.WriteLine($"WYBRALES OPCJE 4");

                        Console.Write($"1. Podaj marke pojazdu: ");
                        s1.Marka = Console.ReadLine();

                        Console.Write($"2. Podaj model pojazdu: ");
                        s1.Model = Console.ReadLine();

                        Console.Write($"3. Podaj moc pojazdu: ");
                        s1.Moc = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"Marka pojazdu to: {s1.Marka}, model to " +
                                $" {s1.Model} a moc to {s1.Moc} KM");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine($"DZIEKUJEMY ZA WIZYTE");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Niepoprawny wybór!");
                        break;
                    }
            }
        } while (wybor != 5 || int.TryParse(Console.ReadLine(), out wybor));
    }
    
}