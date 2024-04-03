using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Mercedes.CarConfigurations.TypesOfMotors;
public class Type2_100hp_6g : IMotor
{
    public int HorsePower { get; } = 100;
    public int NumberOfGears { get; } = 6;
}
