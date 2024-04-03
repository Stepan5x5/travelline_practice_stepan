using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FighterGame.Models.Weapons;
public class NoWeapon : IWeapon
{
    public int Damage { get; } = 1;
    public string Name { get; } = "Без оружия";
}
