using System;
using System.Collections.Generic;

namespace Dictionary
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
            Console.WriteLine( $"Ваш перевод добавлен. Результат: {word} - {converted}." );
        }
        public static void Remove( Dictionary<string, string> interpreter )
        {
            Console.WriteLine( "Введите слово которое хотите удалить:" );
            string word = Console.ReadLine();
            if ( interpreter.ContainsKey( word ) )
            {
                interpreter.Remove( word );
                Console.WriteLine( "Слово удалено." );
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
                Console.WriteLine( $"Ваш перевод изменен. Результат: {word} - {converted}." );
            }
            else
            {
                Console.WriteLine( $"Слово {word} не найдено." );
            }
        }
        public static void PreparedTranslation( Dictionary<string, string> interpreter, Dictionary<string, string> reverseDictionary )
        {
            Console.WriteLine( "Напишите слово которое хотите перевести." );
            string ReadWord = Console.ReadLine();
            string translation;

            if ( interpreter.TryGetValue( ReadWord, out translation ) )
            {
                Console.WriteLine( $"Ваш перевод готов. Результат: {ReadWord} - {translation}." );
            }
            else if ( reverseDictionary.TryGetValue( ReadWord, out translation ) )
            {
                Console.WriteLine( $"Обратный перевод слова готов. Результат: {ReadWord} - {translation}." );
            }
            else
            {
                Console.WriteLine( $"Слово {ReadWord} не найдено." );
            }
        }
    }
}
