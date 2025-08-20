using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public AudioSource yayplayer;
    public GameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.completeLevel();
        yayplayer.Play();
    }
}
