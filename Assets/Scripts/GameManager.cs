using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerSO player;
    public Player play;
    public Ally ally;
    private void Start()
    {
        play.Init(player, 2);
    }

    #region Test
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)) 
        {
            Player.Instance.GetNewAlly(ally);
        }
    }
    #endregion
}
