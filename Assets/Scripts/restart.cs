using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("Level01");
    }
}
