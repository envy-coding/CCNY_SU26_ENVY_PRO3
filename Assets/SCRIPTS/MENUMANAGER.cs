using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUMANAGER : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        GAMEMANAGER.OnGameStateChanged += GameManagerOnGameStateChanged;
    }

    public void OnDestroy()
    {
        GAMEMANAGER.OnGameStateChanged -= GameManagerOnGameStateChanged;
    }


    public void GameManagerOnGameStateChanged(GameState state)
    {
        SceneManager.LoadScene("MAIN MENU");
    }
}
