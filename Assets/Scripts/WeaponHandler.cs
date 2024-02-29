using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    private Transform player;
    private bool readyToShoot = true;
    [SerializeField] private GameObject projectile;
    [SerializeField] private WeaponStatsSO weapon;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if(readyToShoot)
        {
            switch (weapon.type)
            {
                case WeaponStatsSO.Type.Shoot:
                    readyToShoot = false;
                    GameObject obj = Instantiate(projectile, player.position, player.rotation);
                    obj.transform.Translate(Time.deltaTime * weapon.projectileSpeed.Value * player.forward);
                    Invoke(nameof(ResetShoot), weapon.fireRate.Value);
                    break;
                default:
                    break;
            }
        }
    }

    private void ResetShoot() => readyToShoot = true;
}
