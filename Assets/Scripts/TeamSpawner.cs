using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TeamSpawner : MonoBehaviour
{
    public List<GameObject> spawnList = new();

    private List<GameObject> list = new();
    public float spawnRadius;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCharacter(spawnList[Random.Range(0, spawnList.Count)], list, spawnRadius);
        }
    }

    void SpawnCharacter(GameObject unitPrefab, List<GameObject> unitList, float radius) 
    {
        GameObject prefab = Instantiate(unitPrefab, transform);
        
            unitList.Add(prefab);

            foreach (var unit in unitList)
            {
                if (unitList.Count > 1) 
                {
                    float angle = unitList.IndexOf(unit) * -Mathf.PI / unitList.Count;
                    float x = Mathf.Cos(angle) * radius;
                    float z = Mathf.Sin(angle) * radius;
                    Vector3 pos = transform.position + new Vector3(x, 0, z);
                    float angleDegrees = (-angle + Mathf.PI / 2) * Mathf.Rad2Deg;
                    Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);

                    unit.transform.SetPositionAndRotation(pos, rot);
                }
            }   
    }
}
