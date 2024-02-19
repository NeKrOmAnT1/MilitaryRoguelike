using UnityEngine;

public class Teammate : MonoBehaviour
{
    [SerializeField] private float attackDamageBaseValue;
    [SerializeField] private float attackSpeedBaseValue;
    [SerializeField] private float luckBaseValue;

    public Stat AttackDamage { get; private set; }
    public Stat AttackSpeed { get; private set; }
    public Stat Luck { get; private set; }


    void Start()
    {
        AttackDamage = new(attackDamageBaseValue);
        AttackSpeed = new(attackSpeedBaseValue);
        Luck = new(luckBaseValue, true);
    }
}
