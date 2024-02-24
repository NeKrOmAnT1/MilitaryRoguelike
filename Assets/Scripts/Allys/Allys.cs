using UnityEngine;
[RequireComponent(typeof(Animator))]
public class Allys : MonoBehaviour
{
    private PlayerView playerView;
    private void Awake()
    {
        playerView = new(GetComponent<Animator>());
    }

    private void FixedUpdate()
    {
        
    }

    public void SetCorrectAnimation(Vector2 direction)
    {        
        playerView.AnimationMove(direction);
    }
}