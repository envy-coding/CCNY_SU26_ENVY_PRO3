using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVER : MonoBehaviour
{
    public void OnTryAgainClick()
    {
        SceneManager.LoadScene("LEVEL 1");
    }

    public void OnMainMenuClick()
    {
        SceneManager.LoadScene("MAIN MENU");
    }
}
