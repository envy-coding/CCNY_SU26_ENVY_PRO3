using UnityEngine;
using UnityEngine.SceneManagement;

public class STARTMENU : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("LEVEL 1");
    }

    public void OnExitClick()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
            Application.Quit();
    }

    public void OnTutorialClick()
    {
        SceneManager.LoadScene("TUTORIAL");
    }
}
 