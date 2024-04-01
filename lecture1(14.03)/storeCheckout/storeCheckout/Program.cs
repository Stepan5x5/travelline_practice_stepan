using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeCheckout
{
    internal class Program
    {
        public static void Main()
        {
            string productName, name, deliveryAddress, addressFormat;
            int quantity;
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Добро пожаловать в Магазин. Вам необходимо вести некоторые данные.");
            Console.WriteLine("Введите пожалуйста название товара:");
            productName = Console.ReadLine();
            Console.WriteLine("Введите пожалуйста количество товара:");
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Некорректное количество. Пожалуйста, введите целое число:");
            }
            Console.WriteLine("Введите пожалуйста Ваше имя:");
            name = Console.ReadLine();
            addressFormat = "Формат ввода: Город, Улица, Дом, Квартира";
            Console.WriteLine("Введите пожалуйста адрес доставки: " + addressFormat);
            deliveryAddress = Console.ReadLine();

            // Этап подтверждения заказа
            Console.WriteLine($"Здравствуйте, {name}, Вы заказали {productName}, в кол-ве: {quantity}, на адрес: {deliveryAddress}, все верно? (да/нет)");
            string confirmation = Console.ReadLine();
            InputHandler.ProcessInput(confirmation);

            Console.WriteLine($"Ваш заказ {productName} в кол-ве: {quantity} оформлен!");
            DateTime futureDate = currentDate.AddDays(3);
            Console.WriteLine($"Ожидайте доставку по адресу {deliveryAddress} к {futureDate}");
            Console.ReadLine();
        }
    }
}
