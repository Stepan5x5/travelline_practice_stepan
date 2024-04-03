using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FighterGame.Models.Armors;
using FighterGame.Models.Races;
using FighterGame.Models.Weapons;
using FighterGamev2.Models.Class;

namespace FighterGame.Models.Fighters;
public class Fighter : IFighter
{
    public int MaxHealth => Race.Health;
    public int CurrentHealth { get; private set; }
    public int CurrentArmor => Race.Armor + Armor.Armor;

    public int Protection => Race.Protection + Class.IQ;


    public string Name { get; }

    public IClass Class { get; private set; }
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
        int baseDamage = Race.Damage + Weapon.Damage;
        Random random = new Random();
        double damageMultiplier = random.NextDouble() * 0.4 - 0.2;
        int finalDamage = ( int )( baseDamage * ( 1 + damageMultiplier ) );

        return finalDamage;
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
