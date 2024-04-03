using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Mercedes;
public interface ICar
{
    string Name { get; }
    string CarBody { get; }
    string Color { get; }
    int Speed { get; }
    int NumberOfTransmissions { get; }

}
