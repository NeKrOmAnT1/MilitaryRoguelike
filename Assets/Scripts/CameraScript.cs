using UnityEngine;

public class CameraScript : MonoBehaviour
{   [SerializeField] private Vector3 CameraDistantseSettings;
    [SerializeField] private float CameraMovingSpeed;
    [SerializeField] private Transform playerTransform;

    private void CameraMove()
    {
        var CamPosition = new Vector3(CameraDistantseSettings.x + playerTransform.position.x, CameraDistantseSettings.y + playerTransform.position.y, CameraDistantseSettings.z + playerTransform.position.z);
        transform.position = Vector3.Lerp(transform.position, CamPosition, CameraMovingSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        CameraMove();
    }
}
