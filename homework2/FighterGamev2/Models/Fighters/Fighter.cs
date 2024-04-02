using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FighterGame.Models.Armors;
using FighterGame.Models.Races;
using FighterGame.Models.Weapons;

namespace FighterGame.Models.Fighters;
public class Fighter : IFighter
{
    public int MaxHealth => Race.Health;
    public int CurrentHealth { get; private set; }

    public string Name { get; }

    public IRace Race { get; }
    public IWeapon Weapon { get; private set; } = new NoWeapon();
    public IArmor Armor { get; private set; } = new NoArmor();

    public Fighter( string name, IRace race )
    {
        Name = name;
        Race = race;
        CurrentHealth = MaxHealth;
    }

    public int CalculateDamage()
    {
        return Race.Damage + Weapon.Damage;
    }

    public void TakeDamage( int damage )
    {
        CurrentHealth -= damage;
        if ( CurrentHealth < 0 )
        {
            CurrentHealth = 0;
        }
    }
}
