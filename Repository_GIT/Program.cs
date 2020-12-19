using System;

namespace SamplePrograms
{
    class SimpleCalculator
    {
       public static void Main()
       public static void MenuDrukowania()
       public static void Oblicz(int wybranaOpcja)
    }
}
      public static void Main()
      {
          string wyborUzytkownika = string.Empty;
          do
          {
              int wyborUzytkownika = Convert.ToInt32(Console.ReadLine());
              while (wyborUzytkownika < 1 || wyborUzytkownika > 4)
              {
                  Console.WriteLine("Niepoprawna opcja. Spróbuj ponownie");
                  MenuDrukowania();
                  wybórUzytkownika = Convert.ToInt32(Console.ReadLine());
              }
              
              Oblicz(wyborUzytkownika);
              
              Console.WriteLine("Czy chcesz kontynuować ?");
              wyborUżytkownika = Console.ReadLine();
              Console.Clear();
              
              while (wybórUżytkownika.ToUpper() != "N" && wybórUżytkownika.ToUpper() != "T")
              {
                  Console.WriteLine("Nieprawidłowe dane wejściowe - wpisz T lub N");
                  Console.WriteLine("Czy chcesz kontynuować ?");
                  wybórUżytkownika = Console.ReadLine();
              }
          }
          while (wybórUżytkownika.ToUpper() != "N");
          
          Console.WriteLine("Program zostanie teraz zakończony");
      }

public static void MenuDrukowania()
{
    Console.WriteLine();
    Console.WriteLine("Wybierz działanie do wykonania");
    Console.WriteLine("------------------------------");
    Console.WriteLine("1. Dodawanie");
    Console.WriteLine("2. Odejmowanie");
    Console.WriteLine("3. Mnożenie");
    Console.WriteLine("4. Dzielenie");
    Console.WriteLine();
}

public static void Oblicz(int wybranaOpcja)
{
    int wynik = 0;
    
    Console.WriteLine("Wpisz pierwszą liczbę");
    int pierwszaLiczba = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Wpisz drugą liczbę");
    int drugaLiczba = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    
    switch (wybranaOpcja)
    {
        case 1:
            wynik = pierwszaLiczba + drugaLiczba;
            Console.WriteLine("{0} - {1} = {2}", pierwszaLiczba, drugaLiczba, wynik);
            break;
        case 2:
            wynik = pierwszaLiczba - drugaLiczba;
            Console.WriteLine("{0} - {1} = {2}", pierwszaLiczba, drugaLiczba, wynik);
            break;
        case 3:
            wynik = pierwszaLiczba * drugaLiczba;
            Console.WriteLine("{0} * {1} = {2}", pierwszaLiczba. drugaLiczba, wynik);
            break;
        case 4:
            wynik = pierwszaLiczba / drugaLiczba;
            Console.WriteLine("{0} / {1} = {2}",pierwszaLiczba, drugaLiczba, wynik);
            break;
    }
}
