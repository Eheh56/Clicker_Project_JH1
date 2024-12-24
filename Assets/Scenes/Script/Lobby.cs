using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    public string SceneBase; 
    public Button Play;      
    public Button Quit;      

    void Start()
    {
        if (Play != null)
        {
            Play.onClick.AddListener(LoadScene);
        }

        if (Quit != null)
        {
            Quit.onClick.AddListener(QuitGame);
        }
    }

    void LoadScene()
    {
        if (!string.IsNullOrEmpty(SceneBase))
        {
            SceneManager.LoadScene(SceneBase);
        }
        else
        {
            Debug.LogError("Le nom de la scène 'SceneBase' n'est pas défini !");
        }
    }

    void QuitGame()
    {
        Debug.Log("Quitter le jeu...");
        Application.Quit();
    }
}
