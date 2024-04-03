using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterGame.Models.Armors;
public class NoArmor : IArmor
{
    public int Armor { get; } = 0;
    public string Name { get; } = "Без брони";
}
