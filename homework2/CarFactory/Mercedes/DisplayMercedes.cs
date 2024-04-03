using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Mercedes.CarConfigurations.CarColor;
using CarFactory.Mercedes.CarConfigurations.TypesOfBodyShapes;
using CarFactory.Mercedes.CarConfigurations.TypesOfMotors;

namespace CarFactory.Mercedes;
public class DisplayMercedes
{
    public void DisplayConfiguration ( IMotor motor, IBodyShapes bodyShapes, IColor color )
    {
        Configuration configuration = new Configuration (motor, bodyShapes, color);
        DisplayConfiguration( configuration );
    }
    private void DisplayConfiguration ( Configuration configuration )
    {
        Console.WriteLine( "Car Configuration:" );
        Console.WriteLine( $"Name: {configuration.Name}" );
        Console.WriteLine( $"Body: {configuration.CarBody}" );
        Console.WriteLine( $"Color: {configuration.Color}" );
        Console.WriteLine( $"Speed: {configuration.Speed}" );
        Console.WriteLine( $"Number of Transmissions: {configuration.NumberOfTransmissions}" );
    }
}
