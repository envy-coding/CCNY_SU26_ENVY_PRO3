using System;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.SceneManagement;

public class GAMEMANAGER : MonoBehaviour
{
    public static GAMEMANAGER Instance;
    public GameState State;
    public static event Action <GameState> OnGameStateChanged;

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }

    void Start()
    {
        UpdateGameState(GameState.StartGame);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

       switch (newState)
        {
            case GameState.Tutorial:
                SceneManager.LoadScene("TUTORIAL");
                break;
            case GameState.StartGame:
                SceneManager.LoadScene("MAIN MENU");
                break;
            case GameState.Level1:
                SceneManager.LoadScene("LEVEL 1");
                break;
            case GameState.Level2:
                SceneManager.LoadScene("LEVEL 2");
                break;
            case GameState.Level3:
                SceneManager.LoadScene("LEVEL 3");
                break;
            case GameState.GameOver:
                SceneManager.LoadScene("GAME OVER");
                break;
            default:
                    throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
            }
            
            OnGameStateChanged?.Invoke(newState);

        }
    } 


public enum GameState
    {
        Tutorial,
        StartGame,
        Level1,
        Level2,
        Level3,
        GameOver
    }