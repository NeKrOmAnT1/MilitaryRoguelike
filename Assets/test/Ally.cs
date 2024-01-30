using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    [field: SerializeField]public Weapon Gun { get; private set; }
    public void Init(Weapon _gun)
    {
        Gun = _gun;
    }
    
}
