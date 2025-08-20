using UnityEngine;
using UnityEngine.SceneManagement;
public class ShowCredits : MonoBehaviour
{
    public void ShowCreditScene()
    {
        SceneManager.LoadScene("Credits");
    }
}