using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartTime = 2f;

    public GameObject completeLevelUI;

    public void completeLevel()
    {
        Debug.Log("Level complete :D");
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over !!!");
            Invoke("Restart", restartTime);

        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void cakeEnding()
    {
        SceneManager.LoadScene("CakeEnding");
    }

    public void escapeEnding()
    {
        SceneManager.LoadScene("EscapeEnding");
    }
}
