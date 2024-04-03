using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Mercedes.CarConfigurations.CarColor;
using CarFactory.Mercedes.CarConfigurations.TypesOfBodyShapes;
using CarFactory.Mercedes.CarConfigurations.TypesOfMotors;

namespace CarFactory.Mercedes;
public class Configuration
{
    private readonly IMotor _motor;
    private readonly IBodyShapes _bodyShapes;
    private readonly IColor _color; 

    public Configuration (IMotor motor,  IBodyShapes bodyShapes, IColor color )
    {
        _motor = motor;
        _bodyShapes = bodyShapes;
        _color = color;
    }
    public string Name => "Mercedes";
    public string CarBody => _bodyShapes.GetType().Name;
    public string Color => _color.ColorName;
    public int Speed => _motor.HorsePower + _bodyShapes.Aerodynamics + _motor.NumberOfGears;
    public int NumberOfTransmissions => _motor.NumberOfGears;

}
