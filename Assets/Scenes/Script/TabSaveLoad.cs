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
        // Assurez-vous que le Canvas est d�sactiv� au d�marrage
        if (canvasSaveLoad != null)
        {
            canvasSaveLoad.SetActive(false);
        }
        else
        {
            Debug.LogError("Le Canvas Save/Load n'est pas assign� dans l'inspecteur !");
        }

        if(Buttonlobby != null)
        {
            Buttonlobby.onClick.AddListener(LoadSceneLobby);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) // D�tection de la touche TAB
        {
            if (canvasSaveLoad != null)
            {
                // Basculer entre activ� et d�sactiv�
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
            Debug.LogError("Le nom de la sc�ne 'Lobby' n'est pas d�fini !");
        }
    }
}
//

