using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : Singleton<UpgradesManager>
{
    public Bullet bullet;
    public GunControl gun;
 
    public void UpgradeHealth()
    {
        _P.maxHealth += 10;
    }

    public void UpgradeSpeed()
    {
        _PC.moveSpeed += 0.2f;
    }

    public void UpgradeDamage()
    {
        bullet.damage += 2;
    }

    public void UpgradeBulletSpeed()
    {
        gun.bulletSpeed += 0.2f;
    }

    public void UpgradeFireRate()
    {
        gun.timeBetweenShots -= 0.003f;
    }

    public void Heal()
    {
        _P.currentHealth = _P.maxHealth;
    }
}
