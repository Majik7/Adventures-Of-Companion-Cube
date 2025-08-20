using UnityEngine;

public class escapeEnding : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(Collider other)
    {
        gameManager.escapeEnding();
    }
}
