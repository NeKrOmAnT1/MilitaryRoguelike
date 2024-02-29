using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon")]
public class WeaponStatsSO : ScriptableObject
{
    public enum Type 
    {
        Shoot,
        Throw,
        Melee
    }

    public Type type;
    public Stat damage;
    public Stat fireRate;
    public Stat projectileSpeed;
}
