namespace ExchangeRateManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencies = { "USD", "RUB", "TRY" };
            decimal[] exchangeRates = { 1.70m, 0.018m, 0.052m };
            bool isContinue = true;
            while (isContinue)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Zehmet olmasa istediyiniz komandanı daxil edin:\n" +
                    "\n" +
                    "1.Mezennelerin kodları ve kurs qiymetleri ile birlikde gösterilmesi : /show-recent-currency-rates \n" +
                    "2.Spesifik bir mezennenin kodu ve kurs qiymeti ile birlikde gösterilmesi : /find-currency-rate-by-code  \n" +
                    "3.Verilmiş mezenneye ve qiymete uyğun olaraq mebleğin hesablanması : /calculate-amount-by-currency\n" +
                    "4.Programdan çıxış etmek : /exit" +
                    "\n" +
                    "\n");

                string userCommand = Console.ReadLine();
                if (userCommand == "/show-recent-currency-rates")
                {
                    int i = 0;
                    while (i < currencies.Length)
                    {
                        Console.WriteLine($"1 {currencies[i]} = {exchangeRates[i]} AZN");
                        i++;
                    }
                }
                else if (userCommand == "/find-currency-rate-by-code")
                {
                    bool currencySelected = false;
                    while (currencySelected == false)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Zehmet olmasa valyuta seçin (USD, RUB, TRY)");
                        string selectedCurrency = Console.ReadLine();
                        int i = 0;
                        while (i < currencies.Length)
                        {
                            if (currencies[i] == selectedCurrency)
                            {
                                Console.WriteLine($"1 {currencies[i]} = {exchangeRates[i]} AZN");
                                currencySelected = true;
                                break;
                            }
                            i++;
                        }
                        if (currencySelected == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Duzgun valyuta daxil edin!!!!");
                        }
                    }
                }
                else if (userCommand == "/calculate-amount-by-currency")
                {
                    bool correctAmountEntered = false;
                    while (correctAmountEntered == false)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Meblegi daxil edin:");
                        decimal amount;
                        if (decimal.TryParse(Console.ReadLine(), out amount) && amount >= 0)
                        {
                            bool validCurrencySelected = false;
                            while (validCurrencySelected == false)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Valyutani daxil edin (USD, RUB, TRY):");
                                string selectedCurrency = Console.ReadLine();
                                int i = 0;
                                while (i < currencies.Length)
                                {
                                    if (currencies[i] == selectedCurrency)
                                    {
                                        decimal result = amount / exchangeRates[i];
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"{amount}AZN = {result}{selectedCurrency}");
                                        validCurrencySelected = true;
                                        break;
                                    }
                                    i++;
                                }
                                if (validCurrencySelected == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Valyutani duzgun daxil edin!!");
                                }
                            }
                            correctAmountEntered = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Mebleg 0dan kicik ola bilmez! Duzgun daxil edin!!");
                        }
                    }
                }
                else if (userCommand == "/exit")
                {
                    Console.WriteLine("Konverterden istifade etdiyinize gore teşekkurler :) ");
                    isContinue = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bele komanda movcud deyil!Duzgun daxil edin!!!");
                }

            }


        }
    }
}