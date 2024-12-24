using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetourLobby : MonoBehaviour
{
    public string SceneLobby;
    public Button Buttonlobby;

    void Start()
    {
        if (Buttonlobby != null)
        {
            Buttonlobby.onClick.AddListener(LoadSceneLobby);
        }
    }

    void LoadSceneLobby()
    {
        if (!string.IsNullOrEmpty(SceneLobby))
        {
            SceneManager.LoadScene(SceneLobby);
        }
        else
        {
            Debug.LogError("Le nom de la scène 'Lobby' n'est pas défini !");
        }
    }
}