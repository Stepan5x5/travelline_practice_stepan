using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Mercedes.CarConfigurations.TypesOfMotors;
public class Type1_80hp_5g : IMotor
{
    public int HorsePower { get; } = 80;
    public int NumberOfGears { get; } = 5;
}
