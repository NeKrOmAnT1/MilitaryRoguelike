using System.Collections.Generic;
using UnityEngine;

public class SquadScript : MonoBehaviour
{
    private List<Vector3> _pointsPosition;
    private List<GameObject> _points;
    private int _countPoints = 0;
    private int _maxPoints;

    public Transform playerTransform;
    public float distanceBehindPlayer = 5f;
    private Vector3 offset;
    private void MoveForPlayer()
    {

    }



    private void Awake()
    {
    }

    private void Start()
    {
        // playerTransform = PlayerController.Instance.PlayerTransform;
        // Рассчитываем начальное смещение объекта squad относительно игрока
        // offset = playerTransform.TransformDirection(Vector3.back) * -distanceBehindPlayer;
    }

    private void LateUpdate()
    {
        // Обновляем позицию объекта squad, учитывая вращение игрока по оси Y
        // transform.position = playerTransform.position - playerTransform.TransformDirection(offset);
    }
}
