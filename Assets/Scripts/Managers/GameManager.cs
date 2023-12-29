using UnityEngine;

public class GameManager : MonoBehaviour
        {
    [SerializeField] private Player player;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R)) 
        {
        player.ResetPlayer();
        }
    }
}
