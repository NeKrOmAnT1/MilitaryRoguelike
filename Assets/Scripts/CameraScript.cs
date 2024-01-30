using UnityEngine;

public class CameraScript : MonoBehaviour
{   [SerializeField] private Vector3 _сameraDistantseSettings;
    [SerializeField] private float _сameraMovingSpeed;
    [SerializeField] private Transform _playerTransform;

    private void CameraMove()
    {
        var CamPosition = new Vector3(_сameraDistantseSettings.x + _playerTransform.position.x, _сameraDistantseSettings.y + _playerTransform.position.y, _сameraDistantseSettings.z + _playerTransform.position.z);
        transform.position = Vector3.Lerp(transform.position, CamPosition, _сameraMovingSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        CameraMove();
    }
}
