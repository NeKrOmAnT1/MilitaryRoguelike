using System;
using UnityEngine;
[System.Serializable]
[CreateAssetMenu(fileName = "New PlayerSO", menuName = "PlayerSO")]
public class PlayerSO : ScriptableObject
{
    //���� ��� ���� �����
    [field: SerializeField, Range(1,float.MaxValue)]public float Hp { get; private set; }
    [field: SerializeField] public float Armour { get; private set; }
    [field: SerializeField, Range(1, float.MaxValue)] public float Movespeed { get; private set; }
    [field: SerializeField] public float Luck { get; private set; }
    [field: SerializeField, Range(1, float.MaxValue)] public float AttackSpeed { get; private set; }
    [field: SerializeField, Range(1, float.MaxValue)] public float AttackCD { get; private set; }
    [field: SerializeField, Range(1, float.MaxValue)] public float AttackDamage { get; private set; }
    [field: SerializeField, Range(1,float.MaxValue)] public float AttackAmount { get; private set; }
    [field: SerializeField] public Weapon MainWeapon { get; private set; }
}