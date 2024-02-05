using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerSO player;
    public Player play;
    private void Start()
    {
        play.Init(player, 2);
    }
}
