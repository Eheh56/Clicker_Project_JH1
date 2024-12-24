using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TabSaveLoad : MonoBehaviour
{
    public GameObject canvasSaveLoad;

    public string SceneLobby;
    public Button Buttonlobby;

    // Start is called before the first frame update
    void Start()
    {
        // Assurez-vous que le Canvas est désactivé au démarrage
        if (canvasSaveLoad != null)
        {
            canvasSaveLoad.SetActive(false);
        }
        else
        {
            Debug.LogError("Le Canvas Save/Load n'est pas assigné dans l'inspecteur !");
        }

        if(Buttonlobby != null)
        {
            Buttonlobby.onClick.AddListener(LoadSceneLobby);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) // Détection de la touche TAB
        {
            if (canvasSaveLoad != null)
            {
                // Basculer entre activé et désactivé
                canvasSaveLoad.SetActive(!canvasSaveLoad.activeSelf);
            }
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
//

