using UnityEngine;

public class cakeTrigger : MonoBehaviour
{

    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.cakeEnding();
    }
}
