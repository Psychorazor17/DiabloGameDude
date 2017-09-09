using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSkill : PlayerSkill
{
    public DamageOnTriggerEnter projectile;
    public float cooldown = 0.1f;
   

    private bool canShoot = true;

    void Start () {
		
	}



    void ResetShot()
    {
        canShoot = true;

    }

    public override void Cast()
    {
        base.Cast();
        if (canShoot)
        {
            DamageOnTriggerEnter instance = Instantiate(projectile, transform.position, transform.rotation) as DamageOnTriggerEnter;
            Weapon wep = GetComponentInChildren<Weapon>();
           

            instance.damageAmount = wep.WeaponDamage() * damagePercentage;

            
            canShoot = false;
            Invoke("ResetShot", cooldown);
        }
    }
}
