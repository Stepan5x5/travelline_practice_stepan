using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        public static void Main()
        {
            Dictionary<string, string> interpreter = new Dictionary<string, string>();
            Dictionary<string, string> reverseDictionary = new Dictionary<string, string>();
            while ( true )
            {

                Console.WriteLine( "Меню:" );
                Console.WriteLine( "1. Добавить перевод " );
                Console.WriteLine( "2. Удалить перевод " );
                Console.WriteLine( "3. Изменить перевод " );
                Console.WriteLine( "4. Перевести слово " );
                Console.WriteLine( "5. Выйти из программы" );

                Console.Write( "Выберите команду: " );

                string choice = Console.ReadLine();
                switch ( choice )
                {
                    case "1":
                        Translation.Add( interpreter, reverseDictionary );
                        break;
                    case "2":
                        Translation.Remove( interpreter );
                        break;
                    case "3":
                        Translation.Change( interpreter );
                        break;
                    case "4":
                        Translation.Prepared( interpreter, reverseDictionary );
                        break;
                    case "5":
                        Console.WriteLine( "Программа завершена" );
                        return;
                    default:
                        Console.WriteLine( "Неизвестная команда." );
                        break;
                }
            }
        }
    }
}
