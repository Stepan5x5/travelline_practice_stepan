using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    internal class Program
    {
        public static void Main()
        {
            double balance, bet;
            string confirmation;
            int multiplicator = 2;
            double WinningAmount;
            balance = 10000;

            string BalanceText = "Ваш текущий баланс составляет:";
            while (balance > 0)
            {
                Console.WriteLine($"Добро пожаловать в Казино! {BalanceText} {balance}");
                do
                {
                    Console.WriteLine("Введите вашу ставку:");
                    bet = double.Parse(Console.ReadLine());

                    if (bet <= 0)
                    {
                        Console.WriteLine("Ставка должна быть больше нуля. Попробуйте снова.");
                    }
                    else if (bet > balance)
                    {
                        Console.WriteLine("Ставка не может превышать ваш баланс. Попробуйте снова.");
                    }
                    else if (bet > 10000)
                    {
                        Console.WriteLine("Ставка не может превышать 10000. Попробуйте снова.");
                    }
                } while (bet > balance || bet > 10000 || bet <= 0);
                Console.WriteLine($"Подтверждение ставки: Вы уверены что хотите поставить {bet} ? (да/нет)");
                confirmation = Console.ReadLine();
                InputHandler.ProcessInput(confirmation);
                Random random = new Random();
                int randomNumber = random.Next(1, 21);
                if (randomNumber == 18 || randomNumber == 19 || randomNumber == 20)
                {
                    WinningAmount = bet * (1 + (multiplicator * randomNumber % 17));
                    Console.WriteLine($"Ваш выигрыш составляет: {WinningAmount}");
                    balance = balance + WinningAmount;
                    Console.WriteLine($"{BalanceText} {balance}");
                }
                else
                {
                    balance = balance - bet;
                    Console.WriteLine($"Вы проиграли, {BalanceText} {balance}");

                }
            }
            Console.WriteLine("Игра завершена. Ваш баланс исчерпан.");
            Console.ReadLine();
        }
    }
}