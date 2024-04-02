﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FighterGame.Models.Armors;
using FighterGame.Models.Races;
using FighterGame.Models.Weapons;

namespace FighterGame.Models.Fighters;
public interface IFighter
{
    public int MaxHealth { get; }
    public int CurrentHealth { get; }

    public string Name { get; }

    public IWeapon Weapon { get; }
    public IRace Race { get; }
    public IArmor Armor { get; }

    public void TakeDamage( int damage );
    public int CalculateDamage();
}
