using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWeapon : Weapon

{

    public override float WeaponDamage()
  {
      return Random.Range(minDamage, maxDamage);
  }
  
}
