using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterGame.Models.Races;
public interface IRace
{
    int Damage { get; }
    int Health { get; }
    int Armor { get; }
}
