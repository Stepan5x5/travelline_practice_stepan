using CarFactory.Mercedes;
using CarFactory.Mercedes.CarConfigurations.CarColor;
using CarFactory.Mercedes.CarConfigurations.TypesOfBodyShapes;
using CarFactory.Mercedes.CarConfigurations.TypesOfMotors;

internal class Program
{
    static void Main( string[] args )
    {
        Console.WriteLine( "Добро пожаловать на завод Mercedes, какую машину хотите построить ?" );
        DisplayMercedes displayMercedes = new DisplayMercedes();
        Console.WriteLine( "Выберите конфигурацию машины:" );
        Console.WriteLine( "1. Type1_80hp_5g, Type1_Hatchback, Color_Red" );
        Console.WriteLine( "2. Type2_100hp_6g, Type2_Universal, Color_Green" );
        Console.WriteLine( "Введите номер конфигурации:" );

        if ( int.TryParse( Console.ReadLine(), out int choice ) )
        {
            switch ( choice )
            {
                case 1:
                    displayMercedes.DisplayConfiguration( new Type1_80hp_5g(), new Type1_Hatchback(), new Color_Red() );
                    break;
                case 2:
                    displayMercedes.DisplayConfiguration( new Type2_100hp_6g(), new Type2_Universal(), new Color_Green() );
                    break;
                default:
                    Console.WriteLine( "Ошибка: неверный выбор." );
                    break;
            }
        }
        else
        {
            Console.WriteLine( "Ошибка: неверный ввод." );
        }
    }
}