using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeCheckout
{
    public class InputHandler
    {
        public static bool IsYes(string input)
        {
            return input.ToLower() == "да";
        }

        public static bool IsNo(string input)
        {
            return input.ToLower() == "нет";
        }

        public static void ProcessInput(string input)
        {
            if (IsYes(input))
            {
                Console.WriteLine("Вы выбрали 'да'.");


            }
            else if (IsNo(input))
            {
                Console.WriteLine("Вы выбрали 'нет'.");
                Program.Main();
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите 'да' или 'нет'.");
                string newInput = Console.ReadLine();
                ProcessInput(newInput);
            }
        }
    }
}