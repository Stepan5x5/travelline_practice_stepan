using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    public class Translation
    {
        public static void Add( Dictionary<string, string> interpreter, Dictionary<string, string> reverseDictionary )
        {
            Console.WriteLine( "Напишите слово для которого хотите добавить перевод:" );
            string word = Console.ReadLine();
            Console.WriteLine( $"Введите перевод для слова: {word} Ваш перевод:" );
            string converted = Console.ReadLine();
            interpreter[ word ] = converted;
            reverseDictionary[ converted ] = word;
            Console.WriteLine( $"Ваш перевод добавлен. Результат: {word} - {converted}" );
        }
        public static void Remove( Dictionary<string, string> interpreter )
        {
            Console.WriteLine( "Введите слово которое хотите удалить:" );
            string word = Console.ReadLine();
            if ( interpreter.ContainsKey( word ) )
            {
                interpreter.Remove( word );
                Console.WriteLine( "Слово удалено" );
            }
            else
            {
                Console.WriteLine( $"Слово {word} не найдено." );
            }
        }
        public static void Change( Dictionary<string, string> interpreter )
        {
            Console.WriteLine( "Напишите слово для которого хотите изминить перевод:" );
            string word = Console.ReadLine();
            Console.WriteLine( $"Напишите новый перевод для слова {word}:" );
            string converted = Console.ReadLine();
            if ( interpreter.ContainsKey( word ) )
            {
                interpreter[ word ] = converted;
                Console.WriteLine( $"Ваш перевод изменен. Результат: {word} - {converted}" );
            }
            else
            {
                Console.WriteLine( $"Слово {word} не найдено." );
            }
        }
        public static void Prepared( Dictionary<string, string> interpreter, Dictionary<string, string> reverseDictionary )
        {
            Console.WriteLine( "Напишите слово которое хотите перевести" );
            string word = Console.ReadLine();
            if ( interpreter.ContainsKey( word ) )
            {
                Console.WriteLine( $"Ваш перевод готов. Результат: {word} - {interpreter[ word ]}" );
            }
            else if ( reverseDictionary.ContainsKey( word ) )
            {
                Console.WriteLine( $"Обратный перевод слова готов. Результат: {word} - {reverseDictionary[ word ]}" );
            }
            else
            {
                Console.WriteLine( $"Слово {word} не найдено." );
            }
        }
    }
}
