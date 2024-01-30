using UnityEngine;

public class CameraScript : MonoBehaviour
{   [SerializeField] private Vector3 _сameraDistantseSettings;
    [SerializeField] private float _сameraMovingSpeed;

    private void CameraMove()
    {
        var CamPosition = new Vector3(_сameraDistantseSettings.x + Player.Instance.transform.position.x, _сameraDistantseSettings.y + Player.Instance.transform.position.y, _сameraDistantseSettings.z + Player.Instance.transform.position.z);
        transform.position = Vector3.Lerp(transform.position, CamPosition, _сameraMovingSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        CameraMove();
    }
}
