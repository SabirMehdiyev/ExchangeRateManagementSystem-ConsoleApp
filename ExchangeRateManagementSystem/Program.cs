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

                }
                else if (userCommand == "/calculate-amount-by-currency")
                {

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