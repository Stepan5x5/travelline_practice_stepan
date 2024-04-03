using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Mercedes.CarConfigurations.TypesOfMotors;
public interface IMotor
{
    public int HorsePower { get; }
    public int NumberOfGears { get; }
}
